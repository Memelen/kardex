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
    public partial class Detail_materia : Form
    {
        public Detail_materia(string grupo)
        {
            InitializeComponent();
            getData.GetAlumnos(list_alumnos, grupo);
            consult_grupo = grupo;
        }
        private string consult_grupo { get; set; }

        private void Detail_materia_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_asistencias_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_alumnos.SelectedItems)
            {
                insertData.InsertAsistencia(Convert.ToInt32(txt_values.Text), Convert.ToInt32(item.SubItems[0].Text));
            }
            getData.GetAlumnos(list_alumnos, consult_grupo);
        }

        private void btn_cali_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_alumnos.SelectedItems)
            {
                insertData.InsertCalificacion(txt_values.Text, Convert.ToInt32(item.SubItems[0].Text));
            }
            getData.GetAlumnos(list_alumnos, consult_grupo);
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
