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
    public partial class Tutorados_profesor : Form
    {
        public Tutorados_profesor()
        {
            InitializeComponent();
            
        }


        private List<Alumno> list = new List<Alumno>(getData.GetTutorados());

        private void LoadData()
        {         
            foreach (Alumno alumno in list)
            {
                ListViewItem item = new ListViewItem(alumno.nombre);                
                item.SubItems.Add(alumno.correo);                
                list_tutorados.Items.Add(item);
            }                   
        }

        private void Tutorados_profesor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void list_tutorados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Details_tutorado details = new Details_tutorado();
            details.lbl_nombre.Text = list[list_tutorados.FocusedItem.Index].nombre;
            details.lbl_carrera.Text = list[list_tutorados.FocusedItem.Index].carrera;
            details.lbl_semestre.Text = list[list_tutorados.FocusedItem.Index].semestre.ToString() + " Semestre";
            details.lbl_correo.Text = list[list_tutorados.FocusedItem.Index].correo;
            details.lbl_NUA.Text = list[list_tutorados.FocusedItem.Index].NUA.ToString();
            details.BringToFront();
            details.WindowState = FormWindowState.Normal;
            details.Show();
            
        }
    }
}
