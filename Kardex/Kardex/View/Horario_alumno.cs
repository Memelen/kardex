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
    public partial class Horario_alumno : Form
    {
        public Horario_alumno()
        {
            InitializeComponent();
        }

        private void cB_days_SelectedIndexChanged(object sender, EventArgs e)
        {            
            getData.GetInfoClasesA(cB_days.SelectedItem.ToString(), listV_days);
        }

        private void Horario_alumno_Load(object sender, EventArgs e)
        {
            string[] days = new string[] { "LUN", "MAR", "MIE", "JUE", "VIE" };
            for (int i = 0; i < days.Length; i++)
            {
                cB_days.Items.Add(days[i]);
            }
            cB_days.SelectedIndex = 0;
            getData.GetInfoClasesA(cB_days.SelectedItem.ToString(), listV_days);
        }
    }
}
