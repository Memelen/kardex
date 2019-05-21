using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kardex.Model
{
    class User
    {       
        public static string nombre { get; set; }
        public static string direccion { get; set; }
        public static string tel { get; set; }
        public static string correo { get; set; }
        public static string passw { get; set; }

        //Profesor
        public static int NUE { get; set; }
        public static int ext { get; set; }
        public static int cub { get; set; }
        public static string departamento { get; set; }

        //Estudiante
        public static int NUA { get; set; }
        public static int semestre { get; set; }
        public static string division { get; set; }
        public static string carrera { get; set; }
        public static int tutor { get; set; }
        public static string nombre_tutor { get; set; }
    }
}
