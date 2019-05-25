using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kardex.Controller
{
    class UIControls
    {
        public static void AbrirFormulario<T>(Panel panel_forms) where T : Form, new()
        {
            panel_forms.Controls.Clear();
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
    }
}
