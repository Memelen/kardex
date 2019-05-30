namespace Kardex.View
{
    partial class Home_alumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_alumno));
            this.btn_inscrip = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btn_inscrip
            // 
            this.btn_inscrip.Active = false;
            this.btn_inscrip.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_inscrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_inscrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inscrip.BorderRadius = 0;
            this.btn_inscrip.ButtonText = "bunifuFlatButton1";
            this.btn_inscrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inscrip.DisabledColor = System.Drawing.Color.Gray;
            this.btn_inscrip.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_inscrip.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_inscrip.Iconimage")));
            this.btn_inscrip.Iconimage_right = null;
            this.btn_inscrip.Iconimage_right_Selected = null;
            this.btn_inscrip.Iconimage_Selected = null;
            this.btn_inscrip.IconMarginLeft = 0;
            this.btn_inscrip.IconMarginRight = 0;
            this.btn_inscrip.IconRightVisible = true;
            this.btn_inscrip.IconRightZoom = 0D;
            this.btn_inscrip.IconVisible = true;
            this.btn_inscrip.IconZoom = 90D;
            this.btn_inscrip.IsTab = false;
            this.btn_inscrip.Location = new System.Drawing.Point(82, 175);
            this.btn_inscrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_inscrip.Name = "btn_inscrip";
            this.btn_inscrip.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_inscrip.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_inscrip.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_inscrip.selected = false;
            this.btn_inscrip.Size = new System.Drawing.Size(321, 59);
            this.btn_inscrip.TabIndex = 0;
            this.btn_inscrip.Text = "bunifuFlatButton1";
            this.btn_inscrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inscrip.Textcolor = System.Drawing.Color.White;
            this.btn_inscrip.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inscrip.Click += new System.EventHandler(this.btn_inscrip_Click);
            // 
            // Home_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 425);
            this.Controls.Add(this.btn_inscrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_alumno";
            this.Text = "Home_alumno";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_inscrip;
    }
}