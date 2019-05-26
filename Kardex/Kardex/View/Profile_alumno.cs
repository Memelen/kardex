using System;
using Kardex.Model;
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
    public partial class Profile_alumno : Form
    {
        public Profile_alumno()
        {
            InitializeComponent();
            lbl_nombre.Text = User.nombre;
            lbl_nua.Text = User.NUA.ToString();
            lbl_semestre.Text = User.semestre.ToString();
            lbl_carrera.Text = User.carrera;
        }
    }
}
