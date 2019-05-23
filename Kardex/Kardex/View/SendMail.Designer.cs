namespace Kardex.View
{
    partial class SendMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_affair = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.txt_msg = new System.Windows.Forms.RichTextBox();
            this.btn_send = new MetroFramework.Controls.MetroButton();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Para";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Asunto";
            // 
            // txt_affair
            // 
            this.txt_affair.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_affair.Location = new System.Drawing.Point(99, 129);
            this.txt_affair.Name = "txt_affair";
            this.txt_affair.Size = new System.Drawing.Size(310, 26);
            this.txt_affair.TabIndex = 2;
            // 
            // txt_to
            // 
            this.txt_to.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_to.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_to.HideSelection = false;
            this.txt_to.Location = new System.Drawing.Point(80, 93);
            this.txt_to.Name = "txt_to";
            this.txt_to.ReadOnly = true;
            this.txt_to.Size = new System.Drawing.Size(329, 26);
            this.txt_to.TabIndex = 3;
            // 
            // txt_msg
            // 
            this.txt_msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_msg.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msg.Location = new System.Drawing.Point(23, 167);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(386, 199);
            this.txt_msg.TabIndex = 4;
            this.txt_msg.Text = "";
            // 
            // btn_send
            // 
            this.btn_send.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_send.Location = new System.Drawing.Point(324, 398);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(85, 34);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Enviar";
            this.btn_send.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_send.UseCustomBackColor = true;
            this.btn_send.UseSelectable = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_back
            // 
            this.btn_back.DisplayFocus = true;
            this.btn_back.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_back.Location = new System.Drawing.Point(23, 398);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(76, 34);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Cancelar";
            this.btn_back.UseCustomBackColor = true;
            this.btn_back.UseCustomForeColor = true;
            this.btn_back.UseSelectable = true;
            this.btn_back.UseStyleColors = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 443);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_affair);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "SendMail";
            this.Text = "Nuevo mensaje";
            this.Load += new System.EventHandler(this.SendMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txt_affair;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.RichTextBox txt_msg;
        private MetroFramework.Controls.MetroButton btn_send;
        private MetroFramework.Controls.MetroButton btn_back;
    }
}