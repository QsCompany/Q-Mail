using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mail
{
    public partial class HostForm : Form
    {
        public HostForm()
        {
            InitializeComponent();
        }
        public Host Result { get; private set; }
        public HostForm(Host h)
        {
            Result = h;
            Update();
        }
        public void setHost(Host host)
        {
            this.Result = host;
            Update();
        }

        public void Update()
        {
            host.Text = Result.host;
            port.Value = Result.port;
            enablessl.Checked = Result.enableSSL;            
        }
        private void save_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            if (Result == null) Result = new Host();
            this.Result.host = host.Text;
            this.Result.port = (int)port.Value;
            this.Result.enableSSL = enablessl.Checked;
        }
    }
}
