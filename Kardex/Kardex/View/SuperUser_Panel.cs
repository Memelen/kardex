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
    public partial class SuperUser_Panel : Form
    {
        public SuperUser_Panel()
        {
            InitializeComponent();
        }

        private List<Materia> materias { get; set; }
        private List<Profesor> profesors { get; set; }
        private List<Alumno> alumnos { get; set; }
        private List<Grupo> grupos { get; set; }

        private void SuperUser_Panel_Load(object sender, EventArgs e)
        {
            dropBox_options.Items.Insert(0, "-- Seleccione una opción --");
            dropBox_options.Items.Add("Profesores");
            dropBox_options.Items.Add("Alumnos");
            dropBox_options.Items.Add("Materias");
            dropBox_options.Items.Add("Grupo");
            dropBox_options.selectedIndex = 0;
            LoadList();
        }

        private void LoadList()
        {
            materias = getData.GetMateriasSU();
            profesors = getData.GetProfesoresSU();
            alumnos = getData.GetAlumnosSU();
            grupos = getData.GetGruposSU();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadList();
            list_detail.Items.Clear();
            dropBox_options.selectedIndex = 0;
            MessageBox.Show("Refresh");
        }

        private void dropBox_options_onItemSelected(object sender, EventArgs e)
        {
            list_detail.Items.Clear();

            if (dropBox_options.selectedIndex == 1)
            {
                list_detail.Columns[1].Text = "Nombre";
                foreach (Profesor profesor in profesors)
                {
                    ListViewItem item = new ListViewItem(profesor.NUE.ToString());
                    item.SubItems.Add(profesor.nombre +" "+profesor.a_pateno+" "+profesor.a_materno);
                    item.SubItems.Add(profesor.correo);                    
                    list_detail.Items.Add(item);
                }
            }
            else if (dropBox_options.selectedIndex == 2)
            {
                foreach (Alumno alumno in alumnos)
                {
                    list_detail.Columns[1].Text = "Nombre";
                    ListViewItem item = new ListViewItem(alumno.NUA.ToString());
                    item.SubItems.Add(alumno.nombre + " " + alumno.a_paterno + " " + alumno.a_materno);
                    item.SubItems.Add(alumno.correo);
                    list_detail.Items.Add(item);
                }
            }
            else if (dropBox_options.selectedIndex == 3)
            {
                list_detail.Columns[1].Text = "Nombre";
                foreach (Materia materia in materias)
                {
                    ListViewItem item = new ListViewItem(materia.id_materia.ToString());
                    item.SubItems.Add(materia.nombre);
                    item.SubItems.Add(materia.descrip);
                    list_detail.Items.Add(item);
                }
            }
            else if (dropBox_options.selectedIndex == 4)
            {
                list_detail.Columns[1].Text = "Salón";
                foreach (Grupo grupo in grupos)
                {
                    ListViewItem item = new ListViewItem(grupo.id_grupo);
                    item.SubItems.Add(grupo.salon);
                    item.SubItems.Add(grupo.semestre);
                    list_detail.Items.Add(item);
                }
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dropBox_options.selectedIndex == 1 && list_detail.SelectedItems.Count != 0)
            {
                SU_Profesor sUP_ = new SU_Profesor();
                int i = list_detail.FocusedItem.Index;                
                UIControls.ProfesorSU(sUP_, i, profesors);

            }
            else if (dropBox_options.selectedIndex == 2 && list_detail.SelectedItems.Count != 0)
            {
                SU_Alumno sUA_ = new SU_Alumno();
                int i = list_detail.FocusedItem.Index;
                UIControls.AlumnosSU(sUA_, i, alumnos);
            }
            else if (dropBox_options.selectedIndex == 3 && list_detail.SelectedItems.Count != 0)
            {
                SU_Materias sUM_ = new SU_Materias();
                int i = list_detail.FocusedItem.Index;
                UIControls.MateriasSU(sUM_, i, materias);
            }
            else if (dropBox_options.selectedIndex == 4 && list_detail.SelectedItems.Count != 0)
            {
                SU_Grupo sUG_ = new SU_Grupo();
                int i = list_detail.FocusedItem.Index;
                UIControls.GrupoSU(sUG_, i, grupos);
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            switch (dropBox_options.selectedIndex)
            {
                case 1:
                    new SU_Profesor().Show();
                    break;
                case 2:
                    new SU_Alumno().Show();
                    break;
                case 3:
                    new SU_Materias().Show();
                    break;
                case 4:
                    new SU_Grupo().Show();
                    break;
                default:
                    MessageBox.Show("Seleccione una opción");
                    break;
            }
        }


        private void btn_borrar_Click(object sender, EventArgs e)
        {
            switch (dropBox_options.selectedIndex)
            {
                case 1:
                    deleteData.DeleteProfesor(profesors[list_detail.FocusedItem.Index].NUE);
                    break;
                case 2:
                    deleteData.DeleteAlumno(alumnos[list_detail.FocusedItem.Index].NUA);
                    break;
                case 3:
                    deleteData.DeleteMateria(materias[list_detail.FocusedItem.Index].id_materia);
                    break;
                case 4:
                    deleteData.DeleteGrupo(grupos[list_detail.FocusedItem.Index].id_grupo);
                    break;
                default:
                    MessageBox.Show("Seleccione una opción");
                    break;
            }
        }
    }
}
