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


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = panel_forms.Controls.OfType<T>().FirstOrDefault();
            if (formulario != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                formulario.BringToFront();
                return;
            }
            //Se abre el form
            formulario = new T();
            formulario.TopLevel = false;
            panel_forms.Controls.Add(formulario);
            panel_forms.Tag = formulario;
            formulario.Show();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Profile_profesor>();
        }

        private void btn_tutorados_Click(object sender, EventArgs e)
        {

        }
    }
}
