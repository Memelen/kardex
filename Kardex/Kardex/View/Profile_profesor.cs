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
    public partial class Profile_profesor : Form
    {
        public Profile_profesor()
        {
            InitializeComponent();
            lbl_nombre.Text = User.nombre;
            lbl_dtpo.Text = User.departamento;
            lbl_tel.Text = User.tel;
            lbl_ext.Text = Convert.ToString(User.ext);
            lbl_cub.Text = Convert.ToString(User.cub);
            lbl_dir.Text = User.direccion;
            btn_correo.Text = User.correo;
        }       

        private void btn_correo_Click(object sender, EventArgs e)
        {
            new SendMail(string.Empty).Show();
        }
    }
}
