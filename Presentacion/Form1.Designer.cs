namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.l_signup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_forgotpass = new System.Windows.Forms.Label();
            this.img_error = new System.Windows.Forms.PictureBox();
            this.l_error = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.btn_min = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 262);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.tb_username.Enter += new System.EventHandler(this.tb_username_Enter);
            this.tb_username.Leave += new System.EventHandler(this.tb_username_Leave);
            // 
            // l_signup
            // 
            this.l_signup.AutoSize = true;
            this.l_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_signup.ForeColor = System.Drawing.SystemColors.Control;
            this.l_signup.Location = new System.Drawing.Point(13, 420);
            this.l_signup.Name = "l_signup";
            this.l_signup.Size = new System.Drawing.Size(48, 13);
            this.l_signup.TabIndex = 0;
            this.l_signup.Text = "SignUp";
            this.l_signup.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.l_forgotpass);
            this.panel1.Controls.Add(this.img_error);
            this.panel1.Controls.Add(this.l_error);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.l_signup);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 450);
            this.panel1.TabIndex = 7;
            // 
            // l_forgotpass
            // 
            this.l_forgotpass.AutoSize = true;
            this.l_forgotpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_forgotpass.ForeColor = System.Drawing.SystemColors.Control;
            this.l_forgotpass.Location = new System.Drawing.Point(141, 420);
            this.l_forgotpass.Name = "l_forgotpass";
            this.l_forgotpass.Size = new System.Drawing.Size(119, 13);
            this.l_forgotpass.TabIndex = 11;
            this.l_forgotpass.Text = "Password Recovery";
            this.l_forgotpass.Click += new System.EventHandler(this.l_forgotpass_Click);
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
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_error.Location = new System.Drawing.Point(70, 280);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(69, 13);
            this.l_error.TabIndex = 4;
            this.l_error.Text = "Fill all spaces";
            this.l_error.Visible = false;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.Silver;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.ForeColor = System.Drawing.Color.White;
            this.tb_password.Location = new System.Drawing.Point(31, 244);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(161, 13);
            this.tb_password.TabIndex = 2;
            this.tb_password.Text = "PASSWORD";
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            this.tb_password.Enter += new System.EventHandler(this.tb_password_Enter);
            this.tb_password.Leave += new System.EventHandler(this.tb_password_Leave);
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
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(777, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 24);
            this.btn_close.TabIndex = 8;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_min
            // 
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(754, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(24, 24);
            this.btn_min.TabIndex = 9;
            this.btn_min.TabStop = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManPower";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label l_signup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.PictureBox btn_min;
        private System.Windows.Forms.Label l_error;
        private System.Windows.Forms.PictureBox img_error;
        private System.Windows.Forms.Label l_forgotpass;
    }
}

