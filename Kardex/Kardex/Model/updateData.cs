using Kardex.Model;
using Kardex.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kardex.Controller
{
    class updateData
    {
        public static void UpdateAlumno(Alumno alumno)
        {
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter NUAParameter = new SqlParameter("@NUA", alumno.NUA);
                    SqlParameter nombreParameter = new SqlParameter("@nombre", alumno.nombre);
                    SqlParameter a_paternoParameter = new SqlParameter("@apaterno", alumno.a_paterno);
                    SqlParameter a_maternoParameter = new SqlParameter("@amaterno", alumno.a_materno);
                    SqlParameter dirParameter = new SqlParameter("@dir", alumno.direccion);
                    SqlParameter telParameter = new SqlParameter("@tel", alumno.tel);
                    SqlParameter semestreParameter = new SqlParameter("@semestre", alumno.semestre);
                    SqlParameter divParameter = new SqlParameter("@div", alumno.division);
                    SqlParameter carreraParameter = new SqlParameter("@carrera", alumno.carrera);
                    SqlParameter tutorParameter = new SqlParameter("@tutor", alumno.tutor);
                    SqlParameter emailParameter = new SqlParameter("@correo", alumno.correo);

                    SqlCommand command = new SqlCommand("UPDATE ALUMNOS " +
                        "SET nombre=@nombre , a_paterno=@apaterno , a_materno=@amaterno , direccion=@dir , " +
                        "tel=@tel , division=@div , carrera=@carrera , tutor=@tutor , correo=@correo WHERE NUA=@NUA", connection);

                    command.Parameters.Add(NUAParameter);
                    command.Parameters.Add(nombreParameter);
                    command.Parameters.Add(a_paternoParameter);
                    command.Parameters.Add(a_maternoParameter);
                    command.Parameters.Add(dirParameter);
                    command.Parameters.Add(telParameter);
                    command.Parameters.Add(semestreParameter);
                    command.Parameters.Add(divParameter);
                    command.Parameters.Add(carreraParameter);
                    command.Parameters.Add(tutorParameter);
                    command.Parameters.Add(emailParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("El alumno " + alumno.NUA.ToString()
                        + " ha sido actualizado", "Operación exitosa", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Critical ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void UpdateMateria(Materia materia)
        {
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter idParameter = new SqlParameter("@materia", materia.id_materia);
                    SqlParameter nombreParameter = new SqlParameter("@nombre", materia.nombre);
                    SqlParameter desParameter = new SqlParameter("@descrip", materia.descrip);
                    SqlParameter credParameter = new SqlParameter("@creditos", materia.creditos);

                    SqlCommand command = new SqlCommand("UPDATE MATERIA SET nombre=@nombre, " +
                        "descrip=@descrip, creditos=@creditos WHERE id_materia=@materia", connection);
                    command.Parameters.Add(idParameter);
                    command.Parameters.Add(nombreParameter);
                    command.Parameters.Add(desParameter);
                    command.Parameters.Add(credParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("La materia " + materia.id_materia.ToString() + " ha sido actualizado", "Operación exitosa", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Critical ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void UpdateProfesor(Profesor profesor)
        {
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter NUEParameter = new SqlParameter("@NUE", profesor.NUE);
                    SqlParameter nombreParameter = new SqlParameter("@nombre", profesor.nombre);
                    SqlParameter a_paternoParameter = new SqlParameter("@apaterno", profesor.a_pateno);
                    SqlParameter a_maternoParameter = new SqlParameter("@amaterno", profesor.a_materno);
                    SqlParameter dirParameter = new SqlParameter("@dir", profesor.direccion);
                    SqlParameter telParameter = new SqlParameter("@tel", profesor.tel);
                    SqlParameter extParameter = new SqlParameter("@ext", profesor.ext);
                    SqlParameter cubParameter = new SqlParameter("@cub", profesor.cub);
                    SqlParameter emailParameter = new SqlParameter("@correo", profesor.correo);
                    SqlCommand commandProf = new SqlCommand("UPDATE PROFESORES SET " +
                        "nombre=@nombre , a_paterno=@apaterno , a_materno=@amaterno , direccion=@dir , " +
                        "tel=@tel , ext=@ext , cub=@cub , correo=@correo WHERE NUE=@NUE", connection);
                    commandProf.Parameters.Add(NUEParameter);
                    commandProf.Parameters.Add(nombreParameter);
                    commandProf.Parameters.Add(a_paternoParameter);
                    commandProf.Parameters.Add(a_maternoParameter);
                    commandProf.Parameters.Add(dirParameter);
                    commandProf.Parameters.Add(telParameter);
                    commandProf.Parameters.Add(extParameter);
                    commandProf.Parameters.Add(cubParameter);
                    commandProf.Parameters.Add(emailParameter);
                    commandProf.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("El profesor " + profesor.NUE.ToString() + " ha sido actualizado", "Operación exitosa", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Critical ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void UpdateGrupo(Grupo grupo)
        {
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter grupoParameter = new SqlParameter("@grupo", grupo.id_grupo);
                    SqlParameter profParameter = new SqlParameter("@profesor", grupo.profesor);
                    SqlParameter horarioParameter = new SqlParameter("@horario", grupo.horario);
                    SqlParameter salonParameter = new SqlParameter("@salon", grupo.salon);
                    SqlParameter dcParameter = new SqlParameter("@dias_clase", grupo.dias_clase);
                    SqlParameter matParameter = new SqlParameter("@materia", grupo.materia);
                    SqlCommand commandProf = new SqlCommand("UPDATE GRUPO SET " +
                        "profesor=@profesor, horario=@horario, salon=@salon, dias_clase=@dias_clase, materia=@materia" +
                        " WHERE id_grupo=@grupo", connection);
                    commandProf.Parameters.Add(grupoParameter);
                    commandProf.Parameters.Add(profParameter);
                    commandProf.Parameters.Add(horarioParameter);
                    commandProf.Parameters.Add(salonParameter);
                    commandProf.Parameters.Add(dcParameter);
                    commandProf.Parameters.Add(matParameter);
                    commandProf.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("El grupo " + grupo.id_grupo + " ha sido actualizado", "Operación exitosa", MessageBoxButtons.OK,
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
