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
    public partial class Materias_profesor : Form
    {
        public Materias_profesor()
        {
            InitializeComponent();
        }

        private void Details_materia_Load(object sender, EventArgs e)
        {
            getData.GetSemestres(cB_semestre);
            getData.GetMaterias(list_materias, "2019-01");
        }

        private void cB_semestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            getData.GetMaterias(list_materias, cB_semestre.SelectedItem.ToString());
        }

        private void list_materias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grupo = list_materias.Items[list_materias.FocusedItem.Index].SubItems[1].Text;
            Detail_materia details = new Detail_materia(grupo);
            details.lbl_materia.Text = list_materias.Items[list_materias.FocusedItem.Index].SubItems[0].Text;
            details.lbl_grupo.Text = grupo;            
            details.Show();
            details.BringToFront();
        }

    }
}
