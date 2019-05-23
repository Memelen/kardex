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
    public partial class SendMail : MetroFramework.Forms.MetroForm
    {
        public SendMail(string to_mail)
        {
            InitializeComponent();
            txt_to.Text = to_mail;
        }

        private void SendMail_Load(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            insertData.SendingMail(txt_to.Text, txt_msg.Text, txt_affair.Text);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
