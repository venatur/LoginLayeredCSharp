using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=XgtmiWBZk2c");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_username.Text != "USERNAME")
            {
                if (tb_password.Text != "PASSWORD")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(tb_username.Text, tb_password.Text);
                    if (validLogin == true)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else
                        msgError("Wrong Credentials");
                        img_error.Visible = true;

                }
                else
                    msgError("please enter password");
                    img_error.Visible = true;

            }
            else
                msgError("please enter username");
                img_error.Visible = true;
        }

        private void msgError(string msg)
        {
            l_error.Text = "  " + msg;
            l_error.Visible = true;
            img_error.Visible = true;
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_username_Enter(object sender, EventArgs e)
        {
            if (tb_username.Text == "USERNAME")
            {
                tb_username.Text = "";
                tb_username.ForeColor = Color.White;
                
            }
        }
        private void tb_username_Leave(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                tb_username.Text = "USERNAME";
                tb_username.ForeColor = Color.White;
            }
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "PASSWORD")
            {
                tb_password.Text = "";
                tb_password.ForeColor = Color.White;
                tb_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.Text = "PASSWORD";
                tb_password.ForeColor = Color.White;
                tb_password.UseSystemPasswordChar = false;
            }
        }

        private void l_forgotpass_Click(object sender, EventArgs e)
        {
            var recoveredPassword = new fpass();
            recoveredPassword.ShowDialog();
        }
    }
}
