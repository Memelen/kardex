using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kardex.Model
{
    class Log
    {
        public bool LoginStudent(string user, string password)
        { 
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionDB);
            connection.Open();

            SqlParameter nuaParameter = new SqlParameter("@nua", Convert.ToInt32(user));
            SqlParameter userParameter = new SqlParameter("@user", user);
            SqlParameter passParameter = new SqlParameter("@password", password);

            SqlCommand command = new SqlCommand("SELECT NUA, A.nombre, A.a_paterno, A.a_materno, A.direccion, A.tel, semestre, division, carrera, A.correo, tutor, P.nombre, P.a_paterno, P.a_materno FROM ALUMNOS A, PROFESORES P WHERE (A.correo=@user OR A.NUA=@nua) AND A.passw=@password;", connection);
            command.Parameters.Add(nuaParameter);
            command.Parameters.Add(userParameter);
            command.Parameters.Add(passParameter);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                User.NUA = reader.GetInt32(0);
                User.nombre = reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3);
                User.direccion = reader.GetString(4);
                User.tel = reader.GetString(5);
                User.semestre = reader.GetInt32(6);
                User.division = reader.GetString(7);
                User.carrera = reader.GetString(8);
                User.correo = reader.GetString(9);
                User.tutor = reader.GetInt32(10);
                User.nombre_tutor = reader.GetString(11) + " " + reader.GetString(12) + " " + reader.GetString(13);
            }
            reader.Close();
            connection.Close();
            if (User.NUA <= 0)
            {
                return false;
            }
            return true;
        }

        public bool LoginTeacher(string user, string password)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionDB);
            connection.Open();

            SqlParameter nueParameter = new SqlParameter("@nue", Convert.ToInt32(user));
            SqlParameter userParameter = new SqlParameter("@user", user);
            SqlParameter passParameter = new SqlParameter("@password", password);

            SqlCommand command = new SqlCommand("SELECT * FROM PROFESORES P,DEPARTAMENTO WHERE (correo=@user OR P.NUE=@nue) AND passw=@password;", connection);
            command.Parameters.Add(nueParameter);
            command.Parameters.Add(userParameter);
            command.Parameters.Add(passParameter);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User.NUE = reader.GetInt32(0);
                User.nombre = reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3);
                User.direccion = reader.GetString(4);
                User.tel = reader.GetString(5);
                User.ext = reader.GetInt32(6);
                User.cub = reader.GetInt32(7);
                User.correo = reader.GetString(8);
                User.departamento = reader.GetString(10);
            }
            reader.Close();
            connection.Close();

            if (User.NUE <= 0)
            {
                return false;
            }
            User.passw = password;
            return true;
        }
    }
}
