using Kardex.Controller;
using Kardex.Model;
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
    public partial class Console_alumno : Form
    {
        public Console_alumno()
        {
            InitializeComponent();
            label2.Text = "Perfil";
            UIControls.AbrirFormulario<Profile_alumno>(panelforms);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            label2.Text = "Kardex";
            UIControls.AbrirFormulario<Detail_Kardex>(panelforms);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            label2.Text = "Perfil";
            UIControls.AbrirFormulario<Profile_alumno>(panelforms);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            label2.Text = "Materias";
            UIControls.AbrirFormulario<Detail_Materias>(panelforms);
        }
    }
}
