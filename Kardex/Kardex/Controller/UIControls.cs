using Kardex.Model;
using Kardex.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kardex.Controller
{
    class UIControls
    {
        public static void AbrirFormulario<T>(Panel panel_forms) where T : Form, new()
        {
            panel_forms.Controls.Clear();
            Form formulario = panel_forms.Controls.OfType<T>().FirstOrDefault();
            if (formulario != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                formulario.BringToFront();
                return;
            }
            //Se abre el form
            formulario = new T();
            formulario.TopLevel = false;
            panel_forms.Controls.Add(formulario);
            panel_forms.Tag = formulario;
            formulario.Show();
        }

        public static void GrupoSU(SU_Grupo sUG_, int i, List<Grupo> grupos)
        {
            sUG_.txt_grupo.Text = grupos[i].id_grupo;
            sUG_.txt_salon.Text = grupos[i].salon;
            string[] temp = grupos[i].horario.Split('-');
            sUG_.txt_hi.Text = temp[0];
            sUG_.txt_hf.Text = temp[1];
            sUG_.txt_dc.Text = grupos[i].dias_clase;

            for (int x = 0; x < sUG_.cB_materia.Items.Count; x++)
            {
                temp = sUG_.cB_materia.Items[x].ToString().Split('-');
                if (grupos[i].materia.ToString() == temp[0])
                {
                    sUG_.cB_materia.SelectedIndex = x;
                    break;
                }
            }
            
            for (int x = 0; x < sUG_.cB_profesor.Items.Count; x++)
            {
                temp = sUG_.cB_profesor.Items[x].ToString().Split('-');
                if (grupos[i].profesor.ToString() == temp[0])
                {
                    sUG_.cB_profesor.SelectedIndex = x;
                    break;
                }
            }
            sUG_.btn_update.Visible = true;
            sUG_.btn_register.Visible = false;
            sUG_.Show();
        }

        public static void ProfesorSU(SU_Profesor sU_, int i, List<Profesor> profesors)
        {
            sU_.lbl_NUE.Text = profesors[i].NUE.ToString();
            sU_.txt_nombre.Text = profesors[i].nombre;
            sU_.txt_apaterno.Text = profesors[i].a_pateno;
            sU_.txt_amaterno.Text = profesors[i].a_materno;
            sU_.txt_dir.Text = profesors[i].direccion;
            sU_.txt_tel.Text = profesors[i].tel;
            sU_.txt_ext.Text = profesors[i].ext.ToString();
            sU_.txt_cub.Text = profesors[i].cub.ToString();
            sU_.txt_correo.Text = profesors[i].correo;
            sU_.btn_update.Visible = true;
            sU_.btn_register.Visible = false;
            sU_.Show();
        }

        public static void AlumnosSU(SU_Alumno sU_, int i, List<Alumno> alumnos)
        {
            sU_.lbl_NUA.Text = alumnos[i].NUA.ToString();
            sU_.txt_nombre.Text = alumnos[i].nombre;
            sU_.txt_apaterno.Text = alumnos[i].a_paterno;
            sU_.txt_amaterno.Text = alumnos[i].a_materno;
            sU_.txt_dir.Text = alumnos[i].direccion;
            sU_.txt_tel.Text = alumnos[i].tel;
            sU_.txt_correo.Text = alumnos[i].correo;

            for (int x = 0; x < sU_.CB_div.Items.Count; x++)
            {
                if (alumnos[i].division == sU_.CB_div.Items[x].ToString())
                {
                    sU_.CB_div.SelectedIndex = x;
                    break;
                }
            }

            for (int j = 0; j < sU_.CB_carrera.Items.Count; j++)
            {
                if (alumnos[i].carrera == sU_.CB_carrera.Items[j].ToString())
                {
                    sU_.CB_carrera.SelectedIndex = j;
                    break;
                }
            }
            for (int z = 0; z < sU_.cB_tutor.Items.Count; z++)
            {
                if (alumnos[i].tutor.ToString() == sU_.cB_tutor.Items[z].ToString())
                {
                    sU_.cB_tutor.SelectedIndex = z;
                    break;
                }
            }
            sU_.btn_update.Visible = true;
            sU_.btn_register.Visible = false;
            sU_.Show();
        }

        public static void MateriasSU(SU_Materias sU_, int i, List<Materia> materias)
        {
            sU_.lbl_mat.Text = materias[i].id_materia.ToString();
            sU_.txt_nombre.Text = materias[i].nombre;
            sU_.txt_descrip.Text = materias[i].descrip;
            sU_.txt_cred.Text = materias[i].creditos.ToString();
            sU_.btn_update.Visible = true;
            sU_.btn_register.Visible = false;
            sU_.Show();
        }

        public static void Detail_Tutorado(List<Alumno> list, ListView list_tutorados)
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

        public static void Detail_Materia(ListView list_materias)
        {
            string grupo = list_materias.Items[list_materias.FocusedItem.Index].SubItems[1].Text;
            Detail_materia details = new Detail_materia(grupo);
            details.lbl_materia.Text = list_materias.Items[list_materias.FocusedItem.Index].SubItems[0].Text;
            details.lbl_grupo.Text = grupo;
            details.Show();
            details.BringToFront();
        }

        public static void putKardex(List<kardex> kardices,ListView listView, string periodo)
        {
            listView.Items.Clear();
            
            
            foreach (kardex kardex in kardices)
            {              
                if (kardex.periodo == periodo)
                {
                    ListViewItem item = new ListViewItem(kardex.materia.ToString());
                    item.SubItems.Add(kardex.nombre_materia);
                    item.SubItems.Add(kardex.cal);
                    listView.Items.Add(item);
                }
            }
        }

        public static void putPeriodos(ComboBox comboBox)
        {
            int year = Convert.ToInt32(Datagenerators.GetActualSemester().Substring(0, 4));
            int period = Convert.ToInt32(Datagenerators.GetActualSemester().Substring(6, 1));

            comboBox.Items.Add(Datagenerators.GetActualSemester());
            for (int i = 1; i < User.semestre; i++)
            {
                if (period == 1)
                {
                    year--;
                    period = 2;
                }
                else
                {
                    period = 1;
                }
                comboBox.Items.Add(year.ToString()+"-0"+period.ToString());
            }
            comboBox.SelectedIndex = 0;           
        }

        public static void LabelKardex(Label label, string period, ListView list, int i)
        {
            double prom = 0;

            foreach (ListViewItem item in list.Items)
            {
                if (item.SubItems[2].Text != null)
                {
                    prom += Convert.ToInt32(item.SubItems[2].Text);
                }
            }
            prom = prom / list.Items.Count;
            string intervalo = " AGOSTO - DICIEMBRE ";
            if (period.Substring(6, 1) == "1")
            {
                intervalo = " ENERO - JUNIO ";
            }
            int semestre = User.semestre - i;
            label.Text = "NIVEL: " + semestre.ToString();
            label.Text += intervalo + period.Substring(0, 4);
            label.Text += " - PROMEDIO " + prom.ToString();
        }

        public static void Detail_Kardex(List<kardex> kardices, int index)
        {
            Details_Kardex details = new Details_Kardex();
            details.nombre_materia.Text = kardices[index].nombre_materia;
            details.lbl_op.Text = kardices[index].op.ToString();
            details.lbl_status.Text = kardices[index].estatus;
            details.lbl_cal.Text = kardices[index].cal;
            details.lbl_asis.Text = kardices[index].asistencia.ToString();
            details.lbl_grupo.Text = kardices[index].grupo;
            details.cadena = getData.GetProfesor(kardices[index].grupo);
            details.lbl_profesor.Text = details.cadena[0] + " " + details.cadena[1] + " " + details.cadena[2];
            details.BringToFront();
            details.WindowState = FormWindowState.Normal;
            details.Show();
        }

    }
}
