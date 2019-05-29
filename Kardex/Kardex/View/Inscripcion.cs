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
    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
            InitializeComponent();            
            getData.GetMateriasInscrip(list_materias);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_materias.SelectedItems)
            {
                ListViewItem items = new ListViewItem(item.SubItems[0].Text);
                items.SubItems.Add(item.SubItems[1].Text);
                items.SubItems.Add(item.SubItems[2].Text);
                items.SubItems.Add(item.SubItems[7].Text);
                items.SubItems.Add(item.SubItems[3].Text);
                list_sel_mat.Items.Add(items);
            }           
        }


        private void btn_quitar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_materias.SelectedItems)
            {
                list_sel_mat.Items[list_sel_mat.FocusedItem.Index].Remove();
            }
        }

        private void btn_inscrip_Click(object sender, EventArgs e)
        {
            insertData.AddKardex(list_sel_mat);
        }
    }
}
