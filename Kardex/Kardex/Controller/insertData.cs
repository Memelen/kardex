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
    }
}
