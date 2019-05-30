using Kardex.Model;
using Kardex.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kardex.Controller
{
    class getData
    {
        public static List<Alumno> GetTutorados()
        {
            List<Alumno> list = new List<Alumno>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
                {
                    connection.Open();
                    SqlParameter tutorParameter = new SqlParameter("@tutor", User.NUE);
                    SqlCommand command = new SqlCommand("SELECT NUA, nombre, a_paterno, a_materno, semestre, carrera, correo FROM ALUMNOS WHERE tutor=@tutor", connection);
                    command.Parameters.Add(tutorParameter);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Alumno alumno = new Alumno
                        {
                            NUA = reader.GetInt32(0),
                            nombre = reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3),
                            semestre = reader.GetInt32(4),
                            carrera = reader.GetString(5),
                            correo = reader.GetString(6)
                        };

                        list.Add(alumno);
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static void GetInfoClases(string days, ListView listView)
        {
            listView.Items.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
                {
                    connection.Open();
                    SqlParameter profesorParameter = new SqlParameter("@profesor", User.NUE);
                    SqlCommand command = new SqlCommand("SELECT materia, M.nombre, salon, horario, id_grupo FROM GRUPO, MATERIA M WHERE (dias_clase LIKE '%%" + days + "%%' AND materia=id_materia AND profesor=@profesor AND semestre='2019-01')", connection);
                    command.Parameters.Add(profesorParameter);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["materia"].ToString());
                        item.SubItems.Add(reader.GetString(1));
                        item.SubItems.Add(reader.GetString(2));
                        item.SubItems.Add(reader.GetString(3));
                        item.SubItems.Add(reader.GetString(4));
                        listView.Items.Add(item);
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GetMaterias(ListView listView, string semestre)
        {
            listView.Items.Clear();
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter semestreParameter = new SqlParameter("@semestre", semestre);
                    SqlParameter profesorParameter = new SqlParameter("@profesor", User.NUE);
                    SqlCommand command = new SqlCommand("SELECT nombre, descrip, id_grupo FROM MATERIA, GRUPO WHERE profesor=@profesor AND id_materia=materia AND semestre=@semestre", connection);
                    command.Parameters.Add(profesorParameter);
                    command.Parameters.Add(semestreParameter);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["nombre"].ToString());
                        item.SubItems.Add(reader["id_grupo"].ToString());
                        item.SubItems.Add(reader["descrip"].ToString());
                        listView.Items.Add(item);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void GetSemestres(ComboBox comboBox)
        {
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT DISTINCT semestre FROM GRUPO ORDER BY semestre DESC", connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["semestre"].ToString());
                    }
                    comboBox.SelectedIndex = 0;
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void GetAlumnos(ListView listView, string grupo)
        {
            listView.Items.Clear();
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter grupoParameter = new SqlParameter("@grupo", grupo);
                    SqlCommand command = new SqlCommand("SELECT DETALLE_GRUPO.NUA, nombre, a_paterno, a_materno, asistencias, cali FROM DETALLE_GRUPO, ALUMNOS, KARDEX WHERE KARDEX.grupo=@grupo AND DETALLE_GRUPO.NUA = KARDEX.NUA AND KARDEX.GRUPO LIKE DETALLE_GRUPO.grupo AND KARDEX.NUA = ALUMNOS.NUA", connection);
                    command.Parameters.Add(grupoParameter);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["NUA"].ToString());
                        item.SubItems.Add(reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3));
                        item.SubItems.Add(reader["asistencias"].ToString());
                        item.SubItems.Add(reader["cali"].ToString());
                        listView.Items.Add(item);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static List<Materia> GetMateriasSU()
        {
            List<Materia> list = new List<Materia>();
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM MATERIA", connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Materia materia = new Materia
                        {
                            id_materia = reader.GetInt32(0),
                            nombre = reader.GetString(1),
                            descrip = reader.GetString(2),
                            creditos = reader.GetInt32(3)
                        };
                        list.Add(materia);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return list;
        }           
          
        public static List<Profesor> GetProfesoresSU()
        {
            List<Profesor> list = new List<Profesor>();
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM PROFESORES", connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Profesor profesor = new Profesor
                        {
                            NUE = reader.GetInt32(0),
                            nombre = reader.GetString(1),
                            a_pateno = reader.GetString(2),
                            a_materno = reader.GetString(3),
                            direccion = reader.GetString(4),
                            tel = reader.GetString(5),
                            ext =  reader.GetInt32(6),
                            cub = reader.GetInt32(7),
                            correo = reader.GetString(8)
                        };
                        list.Add(profesor);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message +"here");
                }
            }
            return list;
        }

        public static List<Alumno> GetAlumnosSU()
        {
            List<Alumno> list = new List<Alumno>();
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT NUA, A.nombre, A.a_paterno, A.a_materno, A.direccion, A.tel, semestre, division, carrera, A.correo, tutor," +
                        "P.nombre+' '+P.a_paterno+' '+P.a_materno as n_tutor FROM ALUMNOS A, PROFESORES P WHERE P.NUE = tutor", connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Alumno alumno = new Alumno
                        {
                            NUA = reader.GetInt32(0),
                            nombre = reader.GetString(1),
                            a_paterno = reader.GetString(2),
                            a_materno = reader.GetString(3),
                            direccion = reader.GetString(4),
                            tel = reader.GetString(5),
                            semestre = reader.GetInt32(6),
                            division = reader.GetString(7),
                            carrera = reader.GetString(8),
                            correo = reader.GetString(9),
                            tutor = reader.GetInt32(10),
                            nombre_tutor = reader.GetString(11),
                        };
                        list.Add(alumno);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+ "HERE");
                }
            }
            return list;
        }

        public static void GetDivisiones(ComboBox div, ComboBox box)
        {
            div.Items.Clear();
            box.Items.Clear();
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {                    
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM DIVISION", connection);

                    SqlDataReader reader = command.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        div.Items.Add(reader["division"].ToString());
                        box.Items.Add(reader["carrera"].ToString());
                    }
                    
                    div.SelectedIndex = 0;
                    box.SelectedIndex = 0;
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static List<Grupo> GetGruposSU()
        {
            List<Grupo> list = new List<Grupo>();
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    
                    SqlCommand command = new SqlCommand("SELECT * FROM GRUPO ORDER BY semestre DESC", connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Grupo grupo = new Grupo
                        {
                            id_grupo = reader.GetString(0),
                            profesor = reader.GetInt32(1),
                            horario = reader.GetString(2),
                            salon = reader.GetString(3),
                            dias_clase = reader.GetString(4),
                            materia = reader.GetInt32(5),
                            semestre = reader.GetString(6),                       
                        };
                        list.Add(grupo);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return list;
        }

        public static List<kardex> GetKadex()
        {
            List<kardex> list = new List<kardex>();

            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter NUAParameter = new SqlParameter("@NUA",User.NUA);
                    SqlCommand command = new SqlCommand("SELECT NUA, KARDEX.materia, nombre, op, grupo, cali, estatus, KARDEX.semestre, asistencias, GRUPO.semestre " +
                        "FROM KARDEX, MATERIA, GRUPO WHERE NUA=@NUA AND KARDEX.materia=id_materia AND grupo=id_grupo ", connection);
                    command.Parameters.Add(NUAParameter);
                             
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        kardex kardex = new kardex
                        {
                            NUA = reader.GetInt32(0),
                            materia = reader.GetInt32(1),
                            nombre_materia = reader.GetString(2),
                            op = reader.GetInt32(3),
                            grupo = reader.GetString(4),
                            cal = reader.GetString(5),
                            estatus = reader.GetString(6),
                            semestre = reader.GetInt32(7),
                            asistencia = reader.GetInt32(8),
                            periodo = reader.GetString(9)
                        };
                        list.Add(kardex);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return list;
            }
        }

        public static void GetMateriasInscrip(ListView listView)
        {
            listView.Items.Clear();
            string grupos = User.carrera.Substring(0, 3).ToUpper();

            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    
                    SqlCommand command = new SqlCommand("SELECT id_materia, MATERIA.nombre,creditos, id_grupo, horario, dias_clase, salon, PROFESORES.a_paterno+' '+' '+PROFESORES.a_materno+' '+PROFESORES.nombre AS profesor " +
                        "FROM GRUPO, MATERIA, PROFESORES WHERE id_materia=materia AND profesor=NUE AND semestre='2019-02' AND id_grupo LIKE '"+grupos+"%%' ORDER BY MATERIA.nombre ASC", connection);
                    
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {                       
                        ListViewItem item = new ListViewItem(reader["id_materia"].ToString());
                        item.SubItems.Add(reader["nombre"].ToString());
                        item.SubItems.Add(reader["creditos"].ToString());
                        item.SubItems.Add(reader["id_grupo"].ToString());
                        item.SubItems.Add(reader["horario"].ToString());
                        item.SubItems.Add(reader["dias_clase"].ToString());
                        item.SubItems.Add(reader["salon"].ToString());
                        item.SubItems.Add(reader["profesor"].ToString());
                        listView.Items.Add(item);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }

        public static void GetInfoClasesA(string days, ListView listView)
        {
            listView.Items.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
                {
                    connection.Open();
                    SqlParameter alumnoParameter = new SqlParameter("@alumno", User.NUA);
                    SqlCommand command = new SqlCommand("SELECT materia, M.nombre, salon, horario, id_grupo FROM GRUPO, MATERIA M, DETALLE_GRUPO " +
                        "WHERE (dias_clase LIKE '%%"+days+"%%' AND materia=id_materia AND NUA=@alumno AND semestre='2019-01' AND id_grupo=grupo)", connection);
                    command.Parameters.Add(alumnoParameter);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["materia"].ToString());
                        item.SubItems.Add(reader.GetString(1));
                        item.SubItems.Add(reader.GetString(2));
                        item.SubItems.Add(reader.GetString(3));
                        item.SubItems.Add(reader.GetString(4));
                        listView.Items.Add(item);
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string[] GetProfesor(string grupo)
        {
            string[] cadena = new string[4];
            try
            {
                using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
                {
                    connection.Open();
                    SqlParameter Parameter = new SqlParameter("@grupo", grupo);
                    SqlCommand command = new SqlCommand("SELECT nombre,a_paterno,a_materno,correo FROM PROFESORES, GRUPO WHERE id_grupo=@grupo AND NUE=profesor", connection);
                    command.Parameters.Add(Parameter);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cadena[0] = reader.GetString(0);
                        cadena[1] = reader.GetString(1);
                        cadena[2] = reader.GetString(2);
                        cadena[3] = reader.GetString(3);
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cadena;
        }

    }

    
}
