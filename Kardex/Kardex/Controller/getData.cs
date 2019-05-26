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

        public static int GenerateNU()
        {
            Random random = new Random();
            int NU = random.Next(1,99999);
            return NU;
        }

        public static string GeneratePassword(int longitud)
        {
            string contraseña = string.Empty;
            string[] letras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            Random EleccionAleatoria = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int LetraAleatoria = EleccionAleatoria.Next(0, 100);
                int NumeroAleatorio = EleccionAleatoria.Next(0, 9);

                if (LetraAleatoria < letras.Length)
                {
                    contraseña += letras[LetraAleatoria];
                }
                else
                {
                    contraseña += NumeroAleatorio.ToString();
                }
            }
            return contraseña;
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
                            semestre = reader.GetString(6)
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
    }

    
}
