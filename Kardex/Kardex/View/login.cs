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
                    MessageBox.Show("Es alumno " +  User.NUA);
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
    }
}
