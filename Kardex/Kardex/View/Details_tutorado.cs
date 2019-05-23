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
    public partial class Details_tutorado : MetroFramework.Forms.MetroForm
    {
        public Details_tutorado()
        {
            InitializeComponent();
            
        }

        private void Details_tutorado_Load(object sender, EventArgs e)
        {

        }

        private void lbl_correo_Click(object sender, EventArgs e)
        {
            SendMail mail = new SendMail(lbl_correo.Text);
            mail.Show();
        }
    }
}
