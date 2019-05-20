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
    public partial class Control_Alumno : Form
    {
        public Control_Alumno()
        {
            InitializeComponent();
            lbl_nombreAl.Text = Alumno.nombre;
            lbl_semestre.Text += Alumno.semestre.ToString();
            lbl_carrera.Text += Alumno.carrera;
        }

       

        private void Menú_Opening(object sender, CancelEventArgs e)
        {

        }

        private void kardexToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void kardexToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            imp_kardex print = new imp_kardex();
            print.imprimir(Alumno.NUA);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imp_materias print = new imp_materias();
            print.imprimir(Alumno.NUA);
        }
    }
}
