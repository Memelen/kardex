using Kardex.Model;
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
    public partial class Profile_alumno : Form
    {
        public Profile_alumno()
        {
            InitializeComponent();
            lbl_nombre.Text = User.nombre;
            lbl_NUA.Text = User.NUA.ToString();
            lbl_carrera.Text = User.carrera;
            lbl_tel.Text = User.tel;
            lbl_sem.Text = User.semestre.ToString();
            lbl_div.Text = User.division;
            lbl_dir.Text = User.direccion;
            btn_correo.Text = User.correo;
        }

        private void btn_correo_Click(object sender, EventArgs e)
        {
            new SendMail(string.Empty).Show();
        }
    }
}
