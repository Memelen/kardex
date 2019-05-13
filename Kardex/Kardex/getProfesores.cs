using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kardex
{
    class getProfesores
    {
        public Boolean login(string user, string password)
        {
            int nue = int.Parse(user);
         
            SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB);
            connection.Open();
  
            SqlParameter nueParameter = new SqlParameter("@nue", nue);
            SqlParameter userParameter = new SqlParameter("@user", user);
            SqlParameter passParameter = new SqlParameter("@password", password);

            SqlCommand command = new SqlCommand("SELECT P.NUE, nombre, a_paterno, a_materno, D.departamento FROM PROFESORES P, DEPARTAMENTO D WHERE (correo=@user OR P.NUE=@nue) AND passw=@password;", connection);
            command.Parameters.Add(nueParameter);
            command.Parameters.Add(userParameter);
            command.Parameters.Add(passParameter);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Profesor.NUE = reader.GetInt32(0);
                Profesor.nombre = reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3);
                Profesor.departamento = reader.GetString(4);
            }
            reader.Close();
            connection.Close();

            if (String.IsNullOrEmpty(Profesor.nombre))
            {
                return false;
            }

            return true;
        }
    }
}
