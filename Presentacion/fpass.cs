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
    public partial class fpass : Form
    {
        public fpass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new UserModel();
            var result = user.recoverPassword(tb_username.Text);
            l_msg.Text = result;

        }
    }
}
