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
            BtnStatus();
            UIControls.AbrirFormulario<Profile_alumno>(panel_forms);
        }
        private void BtnStatus()
        {
            DateTime today = DateTime.Today;
            DateTime fecha_inscrip = DateTime.Parse("30/05/2019");
            
            if (fecha_inscrip == today)
            {
                btn_inscrip.Visible = true;
            }
            else
            {
                btn_inscrip.Visible = false;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            UIControls.AbrirFormulario<Profile_alumno>(panel_forms);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void btn_horario_Click(object sender, EventArgs e)
        {
            UIControls.AbrirFormulario<Horario_alumno>(panel_forms);
        }

        private void btn_kardex_Click(object sender, EventArgs e)
        {
            UIControls.AbrirFormulario<Kardex>(panel_forms);
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            new Inscripcion().Show();
        }
    }
}
