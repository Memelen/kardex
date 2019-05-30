using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kardex.Model;
using Kardex.View;

namespace Kardex
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                Log log = new Log();

                bool student = log.LoginStudent(txt_user.Text, txt_pass.Text);
                bool teacher = log.LoginTeacher(txt_user.Text, txt_pass.Text);

                if (teacher)
                {
                    Console_maestro maestro = new Console_maestro();
                    maestro.Show();
                    this.Hide();
                }
                else if (student)
                {
                    new Console_alumnos().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ERROR: Nombre o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            new LoginSU().Show();
            this.Hide();

        }
    }
}
