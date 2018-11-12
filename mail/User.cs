using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace mail
{
   
   [Serializable]
    public partial class User : Form,System.Runtime.Serialization.ISerializable
    {
        private Hosts hosts = Hosts.New();
        private MailCounts counts = MailCounts.New();
        public MailCount mail;
        public User()
        {
            InitializeComponent();
            hosts.Created += hosts_Created;
            hosts.Removed += hosts_Removed;
            Load += User_Load;

        }

        void User_Load(object sender, EventArgs e)
        {
            UpdateH();
        }
        public void UpdateH()
        {
            host.Items.Clear();
            foreach (var h in hosts)
            {
                host.Items.Add(h);
            }
        }
        void hosts_Removed(Host h, int i)
        {
            host.Items.Remove(h);
        }

        void hosts_Created(Host h)
        {
            if (h == null) return;
            host.Items.Add(h);
        }
        public User(MailCount mc):this()
        {
            mail = mc;
            UpdateBoxes();
        }

        private void UpdateBoxes()
        {
            if (mail == null) mail = new MailCount();
            host.SelectedItem = this.mail.Host;            
            this.email.Text = mail.user;
            this.pwd.Text = mail.pwd;
            this.name.Text = mail.name;
        }
        private void _Save()
        {
            if (mail == null) mail = new MailCount();
            this.mail.Host = (Host)host.SelectedItem;
            if (mail.Host != null)
                this.mail.code = mail.Host.code;
            else Message("Host Not Selected");

            mail.user = this.email.Text;
            mail.pwd = this.pwd.Text;
            mail.name = this.name.Text;
        }
        private void Message(string p)
        {
        }
   

        private void addhost_Click(object sender, EventArgs e)
        {
            if (hostf.IsDisposed) hostf = new HostForm();
            if (hostf.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
               
                this.hosts.Add(hostf.Result);
                SelectHost(hostf.Result);
            }
        }

        public void SelectHost(Host h)
        {
            if (host.Items.IndexOf(h) == -1) host.Items.Add(h);
            host.SelectedItem = h;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (mail == null) mail = new MailCount();
            _Save();
            if (!counts.Contains(mail)) counts.Add(mail);
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        HostForm hostf = new HostForm();


        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            
        }
    }

   //partial class User : IXmlSerializable
   //{

   //    public System.Xml.Schema.XmlSchema GetSchema()
   //    {
   //        throw new NotImplementedException();
   //    }

   //    public void ReadXml(System.Xml.XmlReader reader)
   //    {

   //    }

   //    public void WriteXml(System.Xml.XmlWriter writer)
   //    {

   //    }
   //}
    [Serializable]
    public class Host
    {

        public string host;
        public int port;
        public bool enableSSL;
        public Guid code = Guid.NewGuid();
        [NonSerialized]
        private SmtpClient smtp;
        public SmtpClient SMTP
        {
            get
            {
                return this.smtp ?? (smtp = new SmtpClient(host, port) { EnableSsl = enableSSL, DeliveryMethod = SmtpDeliveryMethod.Network, UseDefaultCredentials = false }) ;
            
            }
        }
        public override string ToString()
        {
            return string.Format("{0} on Port {1} {2}", host, port.ToString(), enableSSL ? "(SSL enabled)" : "");
        }

        public string Ext
        {
            get
            {
                var x = host.LastIndexOf('.');
                if (x == -1) return null;
                return host.Substring(x + 1);
            }
        }

        public  string Domain
        {
            get
            {
                var ext = Ext;
                if (ext == null) return host;
                var y=host.LastIndexOf('.');
                var x = host.LastIndexOf('.', y - 1);
                return host.Substring(x + 1, y - x - 1);
            }
        }
    }
    [Serializable]
    public class Hosts
    {
        public  List<Host> a = new List<Host>();
        public Hosts()
        {

        }
        [NonSerialized]
        public static Hosts _boits;
        public static Hosts hosts
        {
            get
            {
                return _boits ?? (_boits = New());
            }
        }
        [NonSerialized,XmlIgnore]
        Action<Host> c;
        [NonSerialized,XmlIgnore]
        Action<Host,int> r;

        public event Action<Host> Created { add { c += value; } remove { c -= value; } }

        public event Action<Host, int> Removed { add { r += value; } remove { r -= value; } }
        [NonSerialized]
        private static Hosts _inst;
        public static Hosts New()
        {

            try
            {
                if (_inst != null) return _inst;
                var file = File.Open("./res/hosts.bin", FileMode.OpenOrCreate);

                try
                {
                    if (file.Length != 0)
                    {
                        XmlSerializer f = new XmlSerializer(typeof(Hosts));
                        return _inst = ((Hosts)f.Deserialize(file) ?? new Hosts());
                    }
                }
                catch (Exception e)
                {
                    file.Close();
                }
                finally { file.Close(); }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return _inst = new Hosts();
        }
        public bool Save()
        {
            var file = File.Open("./res/hosts.bin", FileMode.OpenOrCreate);
            try
            {
                XmlSerializer f = new XmlSerializer(typeof(Hosts));

                file.Flush();
                file.Seek(0, SeekOrigin.Begin);
                f.Serialize(file, this);

            }
            catch (Exception e)
            {
                file.Close();
                return false;

            }
            finally { file.Close(); } return true;
        }

        public bool Add(string host, int port, bool enableSSL)
        {
            var x = new Host() { host = host, port = port, enableSSL = enableSSL };
            a.Add(x);
            if (c != null) c(x);
            return Save();
        }
        public bool Add(Host x)
        {
            
            a.Add(x);
            if (c != null) c(x);
            return Save();
        }

        public bool Remove(Host h)
        {
            var i = a.IndexOf(h);
            if (i == -1) return true;
            a.RemoveAt(i);
            if (r != null) r(h, i);
            return true;
        }


        public IEnumerator<Host> GetEnumerator()
        {
            return a.GetEnumerator();
        }



        internal static Host GetHost(MailCount From)
        {
            throw new NotImplementedException();
        }
    }
    [Serializable]
    public class MailCount
    {
        public string user;
        public string pwd;
        public Guid code;
        public string name;
        [NonSerialized,XmlIgnore]
        public Host Host;
        public bool setHost(Hosts h)
        {
            foreach (var _ in h)
            {
                if (_.code == code)
                {
                    this.Host = _;
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {

            return name??"";
        }
        public string GetInfo(out string ext, out string domain)
        {
            var ia = user.IndexOf('@');
            var idot = user.LastIndexOf('.');
            var hdot = idot != -1;
            bool ha = ia != -1;
            bool isReg = ha && hdot & idot > ia;
            if (isReg)
            {
                var usr = user.Substring(0, ia);
                ext = user.Substring(idot + 1);
                domain=user.Substring(ia + 1, idot - ia - 1);;
                return usr;
            }
            else if (ha)
            {
                var usr = user.Substring(0, ia); ext = Host.Ext; domain = user.Substring(ia + 1); return usr;
            }
            else
            {
                var usr = user; ext = Host.Ext; domain = Host.Domain; return usr;
            }
        }

        public string Address
        {
            get
            {
                string ext, dom;
                string usr = GetInfo(out ext, out dom);
                if (usr == null) return null;
                return usr + "@" + dom + "." + ext;
            }
        }

        public void SetAuth(SmtpClient smtp)
        {
            smtp.Credentials = new System.Net.NetworkCredential(Address, pwd);
        }
    }
    [Serializable]
    public class MailCounts
    {
        public  List<MailCount> a = new List<MailCount>();
        public MailCounts()
        {

        }

        [NonSerialized,XmlIgnore]
        public Action<MailCount> c;
        [NonSerialized,XmlIgnore]
        public Action<MailCount, int> r;

        public event Action<MailCount> Created { add { c += value; } remove { c -= value; } }


        public event Action<MailCount, int> Removed { add { r += value; } remove { r -= value; } }
       

        [NonSerialized,XmlIgnore]
        public static MailCounts counts;
        [XmlIgnore]
        public static MailCounts Counts
        {
            get
            {
                return counts ?? (counts = New());
            }
        }
        [NonSerialized,XmlIgnore]
        public static MailCounts _inst;
        public static MailCounts New()
        {
            if (_inst != null) return _inst;
            var file = File.Open("./res/Counts.bin", FileMode.OpenOrCreate);
           
                try
                {
                    if (file.Length != 0)
                    {

                        XmlSerializer f = new XmlSerializer(typeof(MailCounts));
                        return _inst = ((MailCounts)f.Deserialize(file) ?? new MailCounts());
                    }

                }
                catch (Exception e)
                {
                    file.Close();
                }
                finally { file.Close(); }

            return _inst= new MailCounts();
        }


        public bool Add(string name, string usr, string pwd, Host host)
        {
            var x = new MailCount() { name = name, user = usr, pwd = pwd, code = host.code };
          return  Add(x);
        }
        public bool Remove(MailCount h)
        {
            var i = a.IndexOf(h);
            if (i == -1) return true;
            a.RemoveAt(i);
            if (r != null) r(h, i);
            return true;
        }
        public bool Save()
        {
            var file = File.Open("./res/Counts.bin", FileMode.OpenOrCreate);
            try
            {
                XmlSerializer f = new XmlSerializer(typeof(MailCounts));

                file.Flush();
                file.Seek(0, SeekOrigin.Begin);
                f.Serialize(file, this);

            }
            catch (Exception e)
            {
                file.Close();
                return false;

            }
            finally { file.Close(); } return true;
        }



        internal bool Contains(MailCount mail)
        {
            return a.Contains(mail);
        }

        internal bool  Add(MailCount x)
        {
            a.Add(x);
            if (c != null) c(x);
            return  Save();
        }

        public IEnumerator<MailCount> GetEnumerator()
        {
            return a.GetEnumerator();
        }

          }

}
