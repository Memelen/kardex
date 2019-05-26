using Kardex.Controller;
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
    public partial class SU_Alumno : Form
    {
        public SU_Alumno()
        {
            InitializeComponent();
            btn_update.Visible = false;
            foreach (var item in getData.GetProfesoresSU())
            {
                cB_tutor.Items.Add(item.NUE);
            }
            getData.GetDivisiones(CB_div, CB_carrera);

            lbl_NUA.Text = NUA.ToString();
        }

        private int NUA = getData.GenerateNU();

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_amaterno.Text))
            {
                txt_amaterno.Text = "";
            }

            Alumno alumno = new Alumno()
            {
                NUA = this.NUA,
                nombre = txt_nombre.Text,
                a_paterno = txt_amaterno.Text,
                a_materno = txt_amaterno.Text,
                direccion = txt_dir.Text,
                tel = txt_tel.Text,
                semestre = 0,
                division = CB_div.SelectedItem.ToString(),
                carrera = CB_carrera.SelectedItem.ToString(),
                tutor = Convert.ToInt32(cB_tutor.SelectedItem.ToString()),
                correo = txt_correo.Text,
                passw = getData.GeneratePassword(5)
            };
            
            insertData.AddAlumno(alumno);          
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_amaterno.Text))
            {
                txt_amaterno.Text = "";
            }

            Alumno alumno = new Alumno()
            {
                NUA = Convert.ToInt32(lbl_NUA.Text),
                nombre = txt_nombre.Text,
                a_paterno = txt_amaterno.Text,
                a_materno = txt_amaterno.Text,
                direccion = txt_dir.Text,
                tel = txt_tel.Text,
                division = CB_div.SelectedItem.ToString(),
                carrera = CB_carrera.SelectedItem.ToString(),
                tutor = Convert.ToInt32(cB_tutor.SelectedItem.ToString()),
                correo = txt_correo.Text
            };
            updateData.UpdateAlumno(alumno);
        }
    }
}
