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
    public  class Mail 
    {
        private MailAddress from;
        private MailAddress to;
        public string subject="[No subject]";
        public string msg="[Body Not Setted]";
        public Mail()
        {
            from = new MailAddress(mail + "@gmail.com");
            to = new MailAddress(tomail, "my Brother");
            
        }
        public Mail(string[] args):this()
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
        private string mail="lantabourvpr16";
        private string pwd="AHMED2015";
        private string tomail = "babouksmail@gmail.com";
        public event Action<Mail> OnSuccess;
        public event Action<Mail,string> OnFail;

        private List<Attachment> files = new List<Attachment>();
        public void AddFile(string path)
        {
            files.Add(new Attachment(path));
        }
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
            smtp.Timeout = 10000;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(mail + "@gmail.com", pwd);
            try
            {
                smtp.Send(_msg);
            }
            catch (Exception e)
            {
                if (OnFail != null) OnFail(this,e.Message);
                return;
            }
            finally { if (OnSuccess != null)OnSuccess(this); }
        }

        internal void Reset()
        {
            this.files.Clear();
        }
    }
}
