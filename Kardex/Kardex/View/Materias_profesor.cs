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
            UIControls.Detail_Materia(list_materias);
            new Console_maestro().WindowState = FormWindowState.Minimized;
        }

    }
}
