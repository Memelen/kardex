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
    public partial class Details_Kardex : Form
    {
        public Details_Kardex()
        {
            InitializeComponent();            
        }

        public string[] cadena;

        private void lbl_profesor_Click(object sender, EventArgs e)
        {
            new SendMail(cadena[3]).Show();
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
