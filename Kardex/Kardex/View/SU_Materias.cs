using Kardex.Controller;
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
    public partial class SU_Materias : Form
    {
        public SU_Materias()
        {
            InitializeComponent();
            lbl_mat.Text = Materia.ToString();
            btn_update.Visible = false;
        }

        private int Materia = getData.GenerateNU();

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_descrip.Text))
            {
                txt_descrip.Text = "Sin descripción";
            }

            Materia materia = new Materia
            {
                id_materia = Materia,
                nombre = txt_nombre.Text,
                descrip = txt_descrip.Text,
                creditos = Convert.ToInt32(txt_cred.Text)
            };
            insertData.AddMateria(materia);
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_descrip.Text))
            {
                txt_descrip.Text = "Sin descripción";
            }

            Materia materia = new Materia
            {
                id_materia = Convert.ToInt32(lbl_mat.Text),
                nombre = txt_nombre.Text,
                descrip = txt_descrip.Text,
                creditos = Convert.ToInt32(txt_cred.Text)
            };
            updateData.UpdateMateria(materia);
        }
    }
}
