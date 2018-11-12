namespace mail
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.Save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.host = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addhost = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save.Location = new System.Drawing.Point(197, 117);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancel
            // 
            this.cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel.BackgroundImage")));
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.Location = new System.Drawing.Point(278, 117);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // host
            // 
            this.host.Cursor = System.Windows.Forms.Cursors.Hand;
            this.host.FormattingEnabled = true;
            this.host.Location = new System.Drawing.Point(103, 12);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(169, 21);
            this.host.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(103, 66);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(169, 20);
            this.email.TabIndex = 3;
            this.email.Text = "Ammi.SAid.Kaidi@gmail.com";
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(103, 92);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(169, 20);
            this.pwd.TabIndex = 3;
            this.pwd.Text = "023942332as";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // addhost
            // 
            this.addhost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addhost.BackgroundImage")));
            this.addhost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addhost.Location = new System.Drawing.Point(278, 10);
            this.addhost.Name = "addhost";
            this.addhost.Size = new System.Drawing.Size(75, 23);
            this.addhost.TabIndex = 0;
            this.addhost.Text = "Add Host";
            this.addhost.UseVisualStyleBackColor = true;
            this.addhost.Click += new System.EventHandler(this.addhost_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(103, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(169, 20);
            this.name.TabIndex = 3;
            this.name.Text = "Achour Brahim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mail.Properties.Resources.Sans_titre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 147);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.name);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.host);
            this.Controls.Add(this.addhost);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Save);
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox host;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addhost;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
    }
}