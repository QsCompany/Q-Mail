using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mail
{
    public partial class PrintScreen : Form
    {
        NotifyIcon n;
        move m1, m2;
       
        public PrintScreen()
        {
            InitializeComponent();
            m1 = new move(p1);
            m2 = new move(p2);
            n = new NotifyIcon();
            n.Click += n_Click; n.Icon = new System.Drawing.Icon("./icons/printscreen.ico"); ;
            n.Visible = true;
            this.FormClosed += PrintScreen_FormClosed;
              this.Icon = n.Icon;
            p1.BackgroundImage = Image.FromFile("./icons/alu.png");
            p2.BackgroundImage = Image.FromFile("./icons/ard.png");
        }
        public void toHide(Form f) { this.parent = f; }
        public void FHide() { this.Opacity = 0;if(parent!=null) parent.Opacity = 0; }
        public void FShow() { Opacity = 1; if (parent != null)parent.Opacity = 1; }
        void PrintScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            n.Visible = false;
        }

        void n_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.TopMost = true;
        }

        private void MailInterface_Load(object sender, EventArgs e)
        {

        }
        public Bitmap  printScreen()
        {

            Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(printscreen as Image);

            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);

            return printscreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FHide();
            Thread.Sleep(1000*(int)numericUpDown1.Value);       
            var x =printScreen();
            this.pictureBox1.Image = x;
            FShow();
            this.TopMost = false;
            this.TopMost = true;
            this.BringToFront();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Point p2 = this.p2.Location + this.p2.Size ;
            var p1 = this.p1.Location;
            min(ref p1, ref p2);
            Size s = new Size(p2.X - p1.X+1, p2.Y - p1.Y+1);
            Bitmap b = (Bitmap)this.pictureBox1.Image;
            var x = Copy(b, new Rectangle(p1, s));
            result = x;
            this.Visible = false;
            
        }
        public Bitmap result;
        private Form parent;
        static public Bitmap Copy(Bitmap srcBitmap, Rectangle section)
        {
            if (srcBitmap == null) return null;
            // Create the new bitmap and associated graphics object
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            Graphics g = Graphics.FromImage(bmp);

            // Draw the specified section of the source bitmap to the new one
            g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);

            // Clean up
            g.Dispose();

            // Return the bitmap
            return bmp;
        }

        public void min(ref Point p,ref Point t)
        {
            Point f = p; Point s = t;
            p = new Point(Math.Min(f.X, s.X), Math.Min(f.Y, s.Y));
            t = new Point(Math.Max(f.X, s.X), Math.Max(f.Y, s.Y)); 
        }

       

    }
    class move
    {
        Point p,ml;
        Button b;
        bool v;
        public move(Button b)
        {
            b.MouseDown += p1_MouseDown;
                   
            this.b = b;
        }
        Point f;
        void Parent_MouseMove(object sender, MouseEventArgs e)
        {
            if (!v) return;
            var l = Button.MousePosition;
            b.Location = new Point(p.X + l.X - ml.X, p.Y + l.Y - ml.Y);
        }

        
        private void p1_MouseDown(object sender, MouseEventArgs e)
        {
            
            ml = Control.MousePosition;
            p = b.Location;
            v = true;
            b.MouseMove += Parent_MouseMove;
            b.Parent.MouseMove += Parent_MouseMove;
            b.Parent.MouseUp += p1_MouseUp;
            b.MouseUp += p1_MouseUp;    
        }

        private void p1_MouseUp(object sender, MouseEventArgs e)
        {
            p = default(Point);
            v = false;
           
            b.Parent.MouseMove -= Parent_MouseMove;
            b.MouseMove -= Parent_MouseMove;
            b.Parent.MouseUp -= p1_MouseUp;
            b.MouseUp -= p1_MouseUp;
        }
    }
}
