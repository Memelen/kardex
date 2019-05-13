using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kardex
{
    public partial class Console_maestro : Form
    {
        public Console_maestro()
        {
            InitializeComponent();

            lbl_NUE.Text = Profesor.NUE.ToString();
            lbl_nombre.Text = Profesor.nombre;
            lbl_dpto.Text = Profesor.departamento;
        }
    }
}
