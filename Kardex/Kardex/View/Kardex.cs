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
    public partial class Kardex : Form
    {
        public Kardex()
        {
            InitializeComponent();
        }
        private List<kardex> kardices = new List<kardex>(getData.GetKadex());

        private void Kardex_Load(object sender, EventArgs e)
        {
            UIControls.putPeriodos(cB_semestres);
            UIControls.putKardex(kardices, list_kardex, cB_semestres.SelectedItem.ToString());
            UIControls.LabelKardex(label1, cB_semestres.SelectedItem.ToString(), list_kardex, cB_semestres.SelectedIndex);
        }

        private void cB_semestres_SelectedIndexChanged(object sender, EventArgs e)
        {            
            UIControls.putKardex(kardices, list_kardex, cB_semestres.SelectedItem.ToString());
            UIControls.LabelKardex(label1, cB_semestres.SelectedItem.ToString(), list_kardex, cB_semestres.SelectedIndex);
        }

        private void list_kardex_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIControls.Detail_Kardex(kardices, list_kardex.FocusedItem.Index);
            new Console_alumnos().WindowState = FormWindowState.Minimized;
        }
    }
}
