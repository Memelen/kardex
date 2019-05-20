using Kardex.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                getProfesores profesores = new getProfesores();
                getAlumnos alumnos = new getAlumnos();

                Boolean teacher = profesores.login(txt_user.Text, txt_pass.Text);
                Boolean student = alumnos.login(txt_user.Text, txt_pass.Text);

                if (teacher)
                {
                    Console_maestro maestro = new Console_maestro();
                    maestro.Show();
                    this.Hide();
                }
                else if (student)
                {
                    Control_Alumno alumno = new Control_Alumno();
                    alumno.Show();
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
    }
}
