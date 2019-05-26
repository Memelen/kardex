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
    class insertData
    {
        public static void SendingMail(string to, string body, string subject)
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add(to);
            message.Subject = subject;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.Bcc.Add(User.correo);
            message.Body = body;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            message.From = new System.Net.Mail.MailAddress(User.correo);

            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(User.correo, User.passw);
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "SMTP.Office365.com";

            try
            {
                client.Send(message);
                MessageBox.Show("Correo enviado");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void InsertAsistencia(int asistencia, int NUA)
        {
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                try
                {
                    connection.Open();
                    SqlParameter asisParameter = new SqlParameter("@asistencia", asistencia);
                    SqlParameter NUAParameter = new SqlParameter("@NUA", NUA);
                    SqlCommand command = new SqlCommand("UPDATE KARDEX SET asistencias=@asistencia WHERE NUA=@NUA", connection);
                    command.Parameters.Add(asisParameter);
                    command.Parameters.Add(NUAParameter);
                    command.ExecuteNonQuery();                    
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void InsertCalificacion(int calificacion, int NUA)
        {            
            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                string status = "Aprobado";

                if (calificacion < 7)
                {
                    status = "Reprobado";
                }

                try
                {
                    connection.Open();
                    SqlParameter caliParameter = new SqlParameter("@cali", calificacion);
                    SqlParameter NUAParameter = new SqlParameter("@NUA", NUA);
                    SqlParameter statusParameter = new SqlParameter("@status", status);
                    SqlCommand command = new SqlCommand("UPDATE KARDEX SET cali=@cali, estatus=@status WHERE NUA=@NUA", connection);
                    command.Parameters.Add(caliParameter);
                    command.Parameters.Add(NUAParameter);
                    command.Parameters.Add(statusParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void AddProfesor(Profesor profesor)
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
                    SqlParameter passParameter = new SqlParameter("@passw", profesor.passw);
                    SqlCommand commandProf = new SqlCommand("INSERT INTO PROFESORES (NUE, nombre, a_paterno, a_materno, direccion, tel, ext, cub, correo, passw)" +
                        "VALUES(@NUE, @nombre, @apaterno, @amaterno, @dir, @tel, @ext, @cub, @correo, @passw )", connection);
                    commandProf.Parameters.Add(NUEParameter);
                    commandProf.Parameters.Add(nombreParameter);
                    commandProf.Parameters.Add(a_paternoParameter);
                    commandProf.Parameters.Add(a_maternoParameter);
                    commandProf.Parameters.Add(dirParameter);
                    commandProf.Parameters.Add(telParameter);
                    commandProf.Parameters.Add(extParameter);
                    commandProf.Parameters.Add(cubParameter);
                    commandProf.Parameters.Add(emailParameter);
                    commandProf.Parameters.Add(passParameter);
                    commandProf.ExecuteNonQuery();
                    
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void AddMateria(Materia materia)
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

                    SqlCommand command = new SqlCommand("INSERT INTO MATERIA (id_materia, nombre, descrip, creditos)" +
                        "VALUES (@materia, @nombre, @descrip, @creditos)", connection);
                    command.Parameters.Add(idParameter);
                    command.Parameters.Add(nombreParameter);
                    command.Parameters.Add(desParameter);
                    command.Parameters.Add(credParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void AddAlumno(Alumno alumno)
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
                    SqlParameter passParameter = new SqlParameter("@passw", alumno.passw);

                    SqlCommand command = new SqlCommand("INSERT INTO ALUMNOS " +
                        "VALUES( @NUA, @nombre, @apaterno, @amaterno, @dir, @tel, @semestre, @div, @carrera, @tutor,@correo , @passw )", connection);

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
                    command.Parameters.Add(passParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+ "HERE");
                }
            }
        }

        public static void AddGrupo(Grupo grupo)
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
                    SqlParameter semestreParameter = new SqlParameter("@semestre", "2019-02");
                    SqlCommand commandProf = new SqlCommand("INSERT INTO GRUPO " +
                        "VALUES( @grupo, @profesor, @horario, @salon, @dias_clase, @materia, @semestre )", connection);
                    commandProf.Parameters.Add(grupoParameter);
                    commandProf.Parameters.Add(profParameter);
                    commandProf.Parameters.Add(horarioParameter);
                    commandProf.Parameters.Add(salonParameter);
                    commandProf.Parameters.Add(dcParameter);
                    commandProf.Parameters.Add(matParameter);
                    commandProf.Parameters.Add(semestreParameter);
                    commandProf.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Insertado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
