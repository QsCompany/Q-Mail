using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mail
{
    public partial class MailForm : Form
    {
        NotifyIcon n=new NotifyIcon();
       
        private MailCounts counts = MailCounts.New();

        private void UpdateFT()
        {
            var fi = From.SelectedItem;
            var ti = To.SelectedItem;
            From.Items.Clear();
            To.Items.Clear();
            foreach (var obj in counts)
            {
                this.From.Items.Add(obj);
                this.To.Items.Add(obj);
            }
            
            if (fi!=null && From.Items.Contains(fi)) From.SelectedItem = fi;
            if (ti!=null && To.Items.Contains(ti)) To.SelectedItem = ti;

        }
        public MailForm()
        {
            InitializeComponent();
            m.OnSuccess += m_OnSuccess;
            m.OnFail += m_OnFail;
            n.Click += n_Click; n.Icon = new System.Drawing.Icon("./icons/mail.ico");
            n.Visible = true;
            FormClosed += MailForm_FormClosed;
            this.Icon = n.Icon;
            files.DoubleClick += MailForm_DoubleClick;
            counts.Created += counts_Created;
            counts.Removed += counts_Removed;
            UpdateFT();
           
        }

        void counts_Removed(MailCount arg1, int arg2)
        {
            UpdateFT();
        }

        void counts_Created(MailCount obj)
        {
            UpdateFT();
        }

        void MailForm_DoubleClick(object sender, EventArgs e)
        {
            if (files.SelectedItem == null) return;
            Process.Start((string)files.SelectedItem);
        }

        void MailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            n.Visible = false;
        }
        void n_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.TopMost = true;
        }
        void m_OnFail(TMail obj,string e)
        {
            MessageBox.Show("Message Failed\r\n"+e);
        }

        void m_OnSuccess(TMail obj)
        {

            MessageBox.Show("Message Send correctly");
            
        }
        
        private void add_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                bool x=false;
                foreach (var i in f.FileNames)
                {
                    files.Items.Add(i);
                    x = true;
                }
                if (!x) files.Items.Add(f.FileName);                
            }
        }

        private void addpi_Click(object sender, EventArgs e)
        {
            if (p == null || p.IsDisposed) p = new PrintScreen();
            p.toHide(this);
            if (p.ShowDialog(this) != System.Windows.Forms.DialogResult.OK) return;
            if (p.result == null) return;
            var x = p.result;
            var path = Path.Combine(Path.GetTempPath(), Path.GetTempFileName() + ".bmp");
            x.Save(path);
            files.Items.Add(path);
        }
        PrintScreen p;

        private void remove_Click(object sender, EventArgs e)
        {
            if (files.SelectedIndex != -1)
                files.Items.RemoveAt(files.SelectedIndex);
        }
        TMail m = new TMail();
        private void send_Click(object sender, EventArgs e)
        {
            if (To.SelectedItem == null) return;
            if (From.SelectedItem == null) return;
            

            m.Reset();
            m.msg = msg.Text;
            m.subject = sub.Text;
            
            m.to = new System.Net.Mail.MailAddress(((MailCount)To.SelectedItem).user);
            foreach (var f in files.Items)
            {
                m.AddFile((string)f);
            }
            m.send();
        }

        private void MailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void adduser_Click(object sender, EventArgs e)
        {
         user = new User();
            var x = user.ShowDialog();
            if (x == System.Windows.Forms.DialogResult.OK)
            {
                
            }

        }
        User user;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
