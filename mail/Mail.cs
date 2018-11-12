using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace mail
{
    public  class TMail 
    {
        public MailCount From;
        public readonly List<MailAddress> To = new List<MailAddress>();
        private MailAddress from;
        public MailAddress to;
        public string subject="[No subject]";
        public string msg="[Body Not Setted]";
        public TMail()
        {
            from = new MailAddress(mail + "@gmail.com");
            to = new MailAddress(tomail, "my Brother");
            
        }
        public TMail(string[] args):this()
        {
            foreach (var s in args)
            {
                
                var c = s.Split(':');
                if (c.Length == 1) { msg = s; continue; }
                if (c.Length < 2) continue;
                
                switch (c[0].ToLower())
                {
                    case "from":
                        from = new MailAddress(c[1]);
                        continue;

                    case "to":
                        to = new MailAddress(c[1]);
                        continue;

                    case "subject":
                        subject = c[1];
                        continue;

                    case "msg":
                        msg = c[1];
                        continue;
                }
            }

        }
        //private string mail="lantabourvpr16";
        //private string pwd="AHMED2015";

        private string mail="ammi.said.kaidi";
        private string pwd="as023942332";

        private string tomail = "babouksmail@gmail.com";
        public event Action<TMail> OnSuccess;
        public event Action<TMail,string> OnFail;

        private List<Attachment> files = new List<Attachment>();
        public void AddFile(string path)
        {
            files.Add(new Attachment(path));
        }
        static string clientID = "8311023649-qvdqcn34e8ahm84uak8h9n31aiqbvm2u.apps.googleusercontent.com";
        static string clientSecret = "npVM3Igw05_IN04QO7a4o9jW";
        internal void send()
        {
            Console.WriteLine("from:" + from.ToString());
            Console.WriteLine("to:" + to.ToString());
            Console.WriteLine("subject:" +subject .ToString());
            Console.WriteLine("message:" + msg.ToString());
            

            MailMessage _msg = new MailMessage(from, to);
            foreach (var a in files)
                _msg.Attachments.Add(a);
            _msg.Body = msg;
            _msg.Subject = subject;
            
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 25);
            smtp.Port =  587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Timeout = 100000;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(mail + "@gmail.com", pwd);
            
            try
            {
                smtp.Send(_msg);
                if (OnSuccess != null)OnSuccess(this);
            }
            catch (Exception e)
            {
                if (OnFail != null) OnFail(this,e.Message);           
            }
           
        }

        internal void Reset()
        {
            this.files.Clear();
            this.subject = null;
            this.msg = null;
        }
        public void SetFrom(MailCount f)
        {
            From = f;
            from = new MailAddress(f.user, f.name);
        }
        public void AddTo(MailCount f)
        {
            To.Add(new MailAddress(f.user, f.name));
        }
        public void AddTo(IList< MailCount> f)
        {
            foreach (var i in f)
            {
                To.Add(new MailAddress(i.user, i.name));
            }            
        }


    }
    public class Mail
    {
        private readonly List<MailCount> To = new List<MailCount>();
        private readonly List<Attachment> files = new List<Attachment>();

        public MailCount From { get; private set; }
        public string Subject { get; private set; }
        public string Msg { get; private set; }
        
        public event Action<Mail> OnSuccess;
        public event Action<Mail, string> OnFail;

        public bool Send()
        {
            MailMessage _msg = new MailMessage();
            _msg.From = new MailAddress(From.Address, From.name);
            foreach (var t in To)            
                _msg.To.Add(new MailAddress(t.Address, t.name));
            
            foreach (var a in files)
                _msg.Attachments.Add(a);
            _msg.Body = Msg;
            _msg.Subject = Subject;
            Host h = From.Host ?? Hosts.GetHost(From);
            if (h == null) { if (OnFail != null) OnFail(this, "host not defined"); return false; }
            SmtpClient smtp = From.Host.SMTP;
            From.SetAuth(smtp);            
            try
            {
                smtp.Send(_msg);
                if (OnSuccess != null) OnSuccess(this);
                return true;
            }
            catch (Exception e)
            {
                if (OnFail != null) OnFail(this, "host not defined"); return false;
            }
           
        }
        public void AddFile(string path)
        {
            files.Add(new Attachment(path));
        }
        public void Add(MailCount to)
        {
            To.Add(to);
        }
        public void Add(string to)
        {
            var x = new MailCount() { user = to };
            To.Add(x);
        }
        public void Add(IEnumerable<MailCount> tos) { To.AddRange(tos); }
        public void Add(IEnumerable<string> tos) {
            var l = from a in tos select new MailCount() { user = a };
            To.AddRange(l);
        }
    }
}
