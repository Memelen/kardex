using Kardex.Model;
using Kardex.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kardex.Controller
{
    class getData
    {
        public static List<Alumno> GetTutorados()
        {
            List<Alumno> list = new List<Alumno>();

            using (SqlConnection connection = new SqlConnection(Kardex.Properties.Settings.Default.ConnectionDB))
            {
                connection.Open();
                SqlParameter tutorParameter = new SqlParameter("@tutor", User.NUE);
                SqlCommand command = new SqlCommand("SELECT NUA, nombre, a_paterno, a_materno, semestre, carrera, correo FROM ALUMNOS WHERE tutor=@tutor", connection);
                command.Parameters.Add(tutorParameter);
                
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Alumno alumno = new Alumno
                    {
                        NUA = reader.GetInt32(0),
                        nombre = reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3),
                        semestre = reader.GetInt32(4),
                        carrera = reader.GetString(5),
                        correo = reader.GetString(6)
                    };

                    list.Add(alumno);
                }
            }
            return list;
        }

    }

    
}
