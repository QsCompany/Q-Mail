namespace mail
{
    partial class MailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailForm));
            this.sub = new System.Windows.Forms.TextBox();
            this.msg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.files = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.addpi = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.From = new System.Windows.Forms.ComboBox();
            this.To = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adduser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sub
            // 
            this.sub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sub.Location = new System.Drawing.Point(101, 87);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(288, 20);
            this.sub.TabIndex = 0;
            // 
            // msg
            // 
            this.msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msg.Location = new System.Drawing.Point(101, 113);
            this.msg.Multiline = true;
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(288, 188);
            this.msg.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Files";
            // 
            // files
            // 
            this.files.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.files.FormattingEnabled = true;
            this.files.Location = new System.Drawing.Point(101, 313);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(288, 212);
            this.files.TabIndex = 2;
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.Location = new System.Drawing.Point(16, 339);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remove.BackgroundImage")));
            this.remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.remove.Location = new System.Drawing.Point(16, 397);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 3;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // addpi
            // 
            this.addpi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addpi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addpi.BackgroundImage")));
            this.addpi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addpi.Location = new System.Drawing.Point(16, 368);
            this.addpi.Name = "addpi";
            this.addpi.Size = new System.Drawing.Size(75, 23);
            this.addpi.TabIndex = 3;
            this.addpi.Text = "Add Picture";
            this.addpi.UseVisualStyleBackColor = true;
            this.addpi.Click += new System.EventHandler(this.addpi_Click);
            // 
            // send
            // 
            this.send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.send.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("send.BackgroundImage")));
            this.send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.send.Location = new System.Drawing.Point(16, 502);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 3;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // From
            // 
            this.From.FormattingEnabled = true;
            this.From.Location = new System.Drawing.Point(101, 34);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(244, 21);
            this.From.TabIndex = 4;
            // 
            // To
            // 
            this.To.FormattingEnabled = true;
            this.To.Location = new System.Drawing.Point(101, 60);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(244, 21);
            this.To.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(13, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "From";
            // 
            // adduser
            // 
            this.adduser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adduser.BackgroundImage")));
            this.adduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adduser.Location = new System.Drawing.Point(352, 34);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(37, 42);
            this.adduser.TabIndex = 7;
            this.adduser.Text = "Add User";
            this.adduser.UseVisualStyleBackColor = true;
            this.adduser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(314, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::mail.Properties.Resources.Sans_titre;
            this.ClientSize = new System.Drawing.Size(401, 558);
            this.ControlBox = false;
            this.Controls.Add(this.adduser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.addpi);
            this.Controls.Add(this.add);
            this.Controls.Add(this.files);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.sub);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QsMail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MailForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sub;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox files;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button addpi;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.ComboBox From;
        private System.Windows.Forms.ComboBox To;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button adduser;
        private System.Windows.Forms.Button button1;
    }
}