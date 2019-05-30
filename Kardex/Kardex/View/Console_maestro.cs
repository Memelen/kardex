using Kardex.Controller;
using Kardex.Model;
using Kardex.View;
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
            UIControls.AbrirFormulario<Profile_profesor>(panel_forms);            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }      

        private void btn_profile_Click(object sender, EventArgs e)
        {
            lbl_panelinfo.Text = "Perfil";
            UIControls.AbrirFormulario<Profile_profesor>(panel_forms);
        }

        private void btn_tutorados_Click(object sender, EventArgs e)
        {
            lbl_panelinfo.Text = "Tutorados";
            UIControls.AbrirFormulario<Tutorados_profesor>(panel_forms);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            lbl_panelinfo.Text = "Materias";
            UIControls.AbrirFormulario<Materias_profesor>(panel_forms);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            lbl_panelinfo.Text = "Horario";
            UIControls.AbrirFormulario<Horario_profesor>(panel_forms);

        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
