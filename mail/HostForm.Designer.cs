namespace mail
{
    partial class HostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostForm));
            this.host = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enablessl = new System.Windows.Forms.CheckBox();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.SuspendLayout();
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(47, 28);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(198, 20);
            this.host.TabIndex = 0;
            this.host.Text = "smtp.gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // enablessl
            // 
            this.enablessl.AutoSize = true;
            this.enablessl.BackColor = System.Drawing.Color.Transparent;
            this.enablessl.Location = new System.Drawing.Point(47, 81);
            this.enablessl.Name = "enablessl";
            this.enablessl.Size = new System.Drawing.Size(82, 17);
            this.enablessl.TabIndex = 2;
            this.enablessl.Text = "Enable SSL";
            this.enablessl.UseVisualStyleBackColor = false;
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel.BackgroundImage")));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(169, 108);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save.Location = new System.Drawing.Point(88, 108);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(47, 55);
            this.port.Maximum = new decimal(new int[] {
            70000,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(197, 20);
            this.port.TabIndex = 5;
            this.port.Value = new decimal(new int[] {
            587,
            0,
            0,
            0});
            // 
            // HostForm
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::mail.Properties.Resources.Sans_titre;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(259, 143);
            this.ControlBox = false;
            this.Controls.Add(this.port);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.enablessl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.host);
            this.Name = "HostForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "HostForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox enablessl;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.NumericUpDown port;
    }
}