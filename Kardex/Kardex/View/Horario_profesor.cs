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
    public partial class Horario_profesor : Form
    {
        public Horario_profesor()
        {
            InitializeComponent();
        }

        

        private void LoadData()
        {
            string[] days = new string[] { "LUN", "MAR", "MIE", "JUE", "VIE" };
            for (int i = 0; i < days.Length; i++)
            {
                cB_days.Items.Add(days[i]);
            }
            cB_days.SelectedIndex = 0;
            getData.GetInfoClases(cB_days.SelectedItem.ToString(), listV_days);
        }

        private void Materias_profesor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cB_days_SelectedIndexChanged(object sender, EventArgs e)
        {
            getData.GetInfoClases(cB_days.SelectedItem.ToString(), listV_days);
        }
    }
}
