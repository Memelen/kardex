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

            SqlCommand command = new SqlCommand("SELECT * FROM PROFESORES P,DEPARTAMENTO WHERE (correo=@user OR P.NUE=@nue) AND passw=@password;", connection);
            command.Parameters.Add(nueParameter);
            command.Parameters.Add(userParameter);
            command.Parameters.Add(passParameter);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Profesor.NUE = reader.GetInt32(0);
                Profesor.nombre = reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3);
                Profesor.direccion = reader.GetString(4);
                Profesor.tel = reader.GetString(5);
                Profesor.ext = reader.GetInt32(6);
                Profesor.cub = reader.GetInt32(7);
                Profesor.correo = reader.GetString(8);
                Profesor.departamento = reader.GetString(10);
            }
            reader.Close();
            connection.Close();

            if (Profesor.NUE <=0)
            {
                return false;
            }

            return true;
        }
    }
}
