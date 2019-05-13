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

            SqlCommand command = new SqlCommand("SELECT NUA, A.nombre, A.a_paterno, A.a_materno, A.direccion, A.tel, semestre, division, carrera, A.correo, tutor, P.nombre, P.a_paterno, P.a_materno FROM ALUMNOS A, PROFESORES P WHERE (A.correo=@user OR A.NUA=@nua) AND A.passw=@password;", connection);
            command.Parameters.Add(nuaParameter);
            command.Parameters.Add(userParameter);
            command.Parameters.Add(passParameter);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Alumno.NUA = reader.GetInt32(0);
                Alumno.nombre = reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3);
                Alumno.direccion = reader.GetString(4);
                Alumno.tel = reader.GetString(5);
                Alumno.semestre = reader.GetInt32(6);
                Alumno.division = reader.GetString(7);
                Alumno.carrera = reader.GetString(8);
                Alumno.correo = reader.GetString(9);
                Alumno.tutor = reader.GetInt32(10);
                Alumno.nombre_tutor = reader.GetString(11) + " " + reader.GetString(12) + " " + reader.GetString(13);
            }
            reader.Close();
            connection.Close();
            
            if (Alumno.NUA <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
