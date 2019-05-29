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

    }
}
