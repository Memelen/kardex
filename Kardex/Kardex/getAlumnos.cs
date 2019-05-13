using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kardex
{
    class getAlumnos
    {
        public Boolean login(string user, string password)
        {
            int nua = int.Parse(user);

            SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB);
            connection.Open();

            SqlParameter nuaParameter = new SqlParameter("@nua", nua);
            SqlParameter userParameter = new SqlParameter("@user", user);
            SqlParameter passParameter = new SqlParameter("@password", password);

            SqlCommand command = new SqlCommand("", connection);
            command.Parameters.Add(nuaParameter);
            command.Parameters.Add(userParameter);
            command.Parameters.Add(passParameter);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

            }
            reader.Close();
            connection.Close();

            if (String.IsNullOrEmpty(Alumno.nombre))
            {
                return false;
            }

            return true;
        }
    }
}
