using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kardex.Model
{
    class Materia
    {
        public int id_materia { get; set; }
        public string nombre { get; set; }
        public string descrip { get; set; }
        public int creditos { get; set; }
        public string grupo { get; set; }
    }
}
