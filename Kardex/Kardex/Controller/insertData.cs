using Kardex.Model;
using System;
using System.Collections.Generic;
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
    }
}
