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
    public partial class SU_Profesor : Form
    {
        public SU_Profesor()
        {
            InitializeComponent();
            lbl_NUE.Text = NUE.ToString();
            btn_update.Visible = false;
        }

        private int NUE = Datagenerators.GenerateNU();
        
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

            if (string.IsNullOrEmpty(txt_ext.Text))
            {
                txt_ext.Text = "0";
            }

            if (string.IsNullOrEmpty(txt_cub.Text))
            {
                txt_cub.Text = "0";
            }

            Profesor profesor = new Profesor
            {
                NUE = this.NUE,
                nombre = txt_nombre.Text,
                a_pateno = txt_apaterno.Text,
                a_materno = txt_amaterno.Text,
                direccion = txt_dir.Text,
                tel = txt_tel.Text,
                ext = Convert.ToInt32(txt_ext.Text),
                cub = Convert.ToInt32(txt_cub.Text),
                correo = txt_correo.Text,
                passw = Datagenerators.GeneratePassword(5)            
            };
            insertData.AddProfesor(profesor);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_amaterno.Text))
            {
                txt_amaterno.Text = "";
            }

            if (string.IsNullOrEmpty(txt_ext.Text))
            {
                txt_ext.Text = "0";
            }

            if (string.IsNullOrEmpty(txt_cub.Text))
            {
                txt_cub.Text = "0";
            }

            Profesor profesor = new Profesor
            {
                NUE = Convert.ToInt32(lbl_NUE.Text),
                nombre = txt_nombre.Text,
                a_pateno = txt_apaterno.Text,
                a_materno = txt_amaterno.Text,
                direccion = txt_dir.Text,
                tel = txt_tel.Text,
                ext = Convert.ToInt32(txt_ext.Text),
                cub = Convert.ToInt32(txt_cub.Text),
                correo = txt_correo.Text,
                passw = Datagenerators.GeneratePassword(5)
            };
            updateData.UpdateProfesor(profesor);
        }
    }
}
