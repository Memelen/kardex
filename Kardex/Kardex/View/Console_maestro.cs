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

            lbl_NUE.Text = User.NUE.ToString();
            lbl_nombre.Text = User.nombre;
            lbl_dpto.Text = User.departamento;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tutorados_profesor tutorados = new Tutorados_profesor();
            tutorados.Show();
        }
    }
}
