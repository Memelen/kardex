using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kardex
{
    class Alumno
    {
        public int NUA { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string tel { get; set; }
        public int semestre { get; set; }
        public string division { get; set; }
        public string carrera { get; set; }
        public int tutor { get; set; }
        public string nombre_tutor { get; set; }
        public string correo { get; set; }
    }
}
