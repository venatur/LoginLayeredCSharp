namespace Presentacion
{
    partial class fpass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fpass));
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_error = new System.Windows.Forms.PictureBox();
            this.l_msg = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.img_error);
            this.panel1.Controls.Add(this.l_msg);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 450);
            this.panel1.TabIndex = 8;
            // 
            // img_error
            // 
            this.img_error.Image = ((System.Drawing.Image)(resources.GetObject("img_error.Image")));
            this.img_error.Location = new System.Drawing.Point(39, 275);
            this.img_error.Name = "img_error";
            this.img_error.Size = new System.Drawing.Size(25, 25);
            this.img_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_error.TabIndex = 10;
            this.img_error.TabStop = false;
            this.img_error.Visible = false;
            // 
            // l_msg
            // 
            this.l_msg.AutoSize = true;
            this.l_msg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_msg.Location = new System.Drawing.Point(70, 280);
            this.l_msg.Name = "l_msg";
            this.l_msg.Size = new System.Drawing.Size(69, 13);
            this.l_msg.TabIndex = 4;
            this.l_msg.Text = "Fill all spaces";
            this.l_msg.Visible = false;
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.Silver;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.ForeColor = System.Drawing.Color.White;
            this.tb_email.Location = new System.Drawing.Point(31, 244);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(161, 13);
            this.tb_email.TabIndex = 2;
            this.tb_email.Text = "EMAIL";
            this.tb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(48, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.Silver;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.ForeColor = System.Drawing.Color.White;
            this.tb_username.Location = new System.Drawing.Point(31, 189);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(161, 13);
            this.tb_username.TabIndex = 1;
            this.tb_username.Text = "USERNAME";
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fpass";
            this.Opacity = 0.9D;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox img_error;
        private System.Windows.Forms.Label l_msg;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_username;
    }
}