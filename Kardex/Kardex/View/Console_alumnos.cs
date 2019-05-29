using Kardex.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kardex.View
{
    public partial class Console_alumnos : Form
    {
        public Console_alumnos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            UIControls.AbrirFormulario<Profile_alumno>(panel_forms);
        }
    }
}
