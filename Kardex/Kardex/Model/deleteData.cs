using Kardex.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kardex.Controller
{
    class deleteData
    {
        public static void DeleteAlumno(int alumno)
        {
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter NUAParameter = new SqlParameter("@NUA", alumno);


                    SqlCommand command = new SqlCommand("DELETE FROM ALUMNOS WHERE NUA=@NUA", connection);

                    command.Parameters.Add(NUAParameter);

                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("El alumno " + alumno.ToString() + " ha sido borrado", "Operación exitosa",MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Critical ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void DeleteMateria(int materia)
        {
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter idParameter = new SqlParameter("@materia", materia);

                    SqlCommand command = new SqlCommand("DELETE FROM MATERIA WHERE id_materia=@materia", connection);
                    command.Parameters.Add(idParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("La materia " + materia.ToString() + " ha sido borrado", "Operación exitosa", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Critical ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void DeleteProfesor(int profesor)
        {
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter NUEParameter = new SqlParameter("@NUE", profesor);
                    SqlCommand commandProf = new SqlCommand("DELETE FROM PROFESORES WHERE NUE=@NUE", connection);
                    commandProf.Parameters.Add(NUEParameter);
                    commandProf.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("El profesor " + profesor.ToString() + " ha sido borrado", "Operación exitosa", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Critical ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void DeleteGrupo(string grupo)
        {
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter NUAParameter = new SqlParameter("@grupo", grupo);


                    SqlCommand command = new SqlCommand("DELETE FROM GRUPO WHERE id_grupo=@grupo", connection);

                    command.Parameters.Add(NUAParameter);

                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("El grupo " + grupo + " ha sido borrado", "Operación exitosa", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Critical ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
