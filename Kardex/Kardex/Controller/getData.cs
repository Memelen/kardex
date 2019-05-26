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
        public static void getKardex(ListView listView)
        {
            listView.Items.Clear();
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter nuaParameter = new SqlParameter("@nua", User.NUA);
                    SqlCommand command = new SqlCommand("select nombre, op, grupo, cali, estatus, semestre from dbo.kardex, dbo.materia where dbo.kardex.NUA=@nua and dbo.kardex.materia=dbo.materia.id_materia;", connection);
                    command.Parameters.Add(nuaParameter);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["nombre"].ToString());
                        item.SubItems.Add(reader["op"].ToString());
                        item.SubItems.Add(reader["grupo"].ToString());
                        item.SubItems.Add(reader["cali"].ToString());
                        item.SubItems.Add(reader["estatus"].ToString());
                        item.SubItems.Add(reader["semestre"].ToString());
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
        public static void getMateriasAl(ListView listView)
        {
            listView.Items.Clear();
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter nuaParameter = new SqlParameter("@nua", User.NUA);
                    SqlCommand command = new SqlCommand("select id_materia, nombre, descrip, creditos from dbo.kardex, dbo.materia where dbo.kardex.NUA=@nua and dbo.kardex.materia=dbo.materia.id_materia;", connection);
                    command.Parameters.Add(nuaParameter);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["nombre"].ToString());
                        item.SubItems.Add(reader["descrip"].ToString());
                        item.SubItems.Add(reader["creditos"].ToString());
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
    }

    
}
