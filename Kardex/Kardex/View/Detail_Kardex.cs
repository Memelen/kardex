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
    public partial class Detail_Kardex : Form
    {
        public Detail_Kardex()
        {
            InitializeComponent();
            getData.getKardex(list_Kardex);
        }
    }
}
