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
    public partial class SU_Grupo : Form
    {
        public SU_Grupo()
        {
            InitializeComponent();
            foreach (var item in getData.GetMateriasSU())
            {
                cB_materia.Items.Add(item.id_materia.ToString()+"-"+item.nombre);
            }
            foreach (var item in getData.GetProfesoresSU())
            {
                cB_profesor.Items.Add(item.NUE.ToString() + "-" + item.nombre + " " + item.a_pateno);
            }
            btn_update.Visible = false;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string[] prof = cB_profesor.SelectedItem.ToString().Split('-');            
            string[] mat = cB_materia.SelectedItem.ToString().Split('-');
            Grupo grupo = new Grupo()
            {
                id_grupo = txt_grupo.Text,
                profesor = Convert.ToInt32(prof[0]),
                horario = txt_hi.Text+"-"+txt_hf.Text,
                salon = txt_salon.Text,
                dias_clase = txt_dc.Text,
                materia = Convert.ToInt32(mat[0]),               
            };
            insertData.AddGrupo(grupo);
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string[] prof = cB_profesor.SelectedItem.ToString().Split('-');
            string[] mat = cB_materia.SelectedItem.ToString().Split('-');
            Grupo grupo = new Grupo()
            {
                id_grupo = txt_grupo.Text,
                profesor = Convert.ToInt32(prof[0]),
                horario = txt_hi.Text + "-" + txt_hf.Text,
                salon = txt_salon.Text,
                dias_clase = txt_dc.Text,
                materia = Convert.ToInt32(mat[0]),
            };
            updateData.UpdateGrupo(grupo);
        }
    }
}
