using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kardex.View
{
    public partial class LoginSU : Form
    {
        public LoginSU()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "admin" && txt_pass.Text == "pass")
            {
                new SuperUser_Panel().Show();
                this.Close();
            }
        }
    }
}
