using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kardex.Model
{
    class Grupo
    {
        public string id_grupo { get; set; }
        public int profesor { get; set; }
        public string nombre_profesor { get; set; }
        public string horario { get; set; }
        public string salon { get; set; }
        public string dias_clase { get; set; }
        public int materia { get; set; }
        public int NUA { get; set; }
        public string alumno { get; set; }
    }
}
