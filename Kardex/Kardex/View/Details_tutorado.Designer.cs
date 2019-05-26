namespace Kardex.View
{
    partial class Details_tutorado
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
            this.lbl_nombre = new MetroFramework.Controls.MetroLabel();
            this.lbl_correo = new MetroFramework.Controls.MetroLabel();
            this.lbl_NUA = new MetroFramework.Controls.MetroLabel();
            this.lbl_carrera = new MetroFramework.Controls.MetroLabel();
            this.lbl_semestre = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_nombre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_nombre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_nombre.Location = new System.Drawing.Point(15, 60);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(91, 25);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "NOMBRE";
            // 
            // lbl_correo
            // 
            this.lbl_correo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_correo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_correo.Location = new System.Drawing.Point(34, 141);
            this.lbl_correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(40, 15);
            this.lbl_correo.TabIndex = 1;
            this.lbl_correo.Text = "correo";
            this.lbl_correo.Click += new System.EventHandler(this.lbl_correo_Click);
            // 
            // lbl_NUA
            // 
            this.lbl_NUA.AutoSize = true;
            this.lbl_NUA.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_NUA.Location = new System.Drawing.Point(34, 166);
            this.lbl_NUA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NUA.Name = "lbl_NUA";
            this.lbl_NUA.Size = new System.Drawing.Size(32, 15);
            this.lbl_NUA.TabIndex = 2;
            this.lbl_NUA.Text = "NUA";
            // 
            // lbl_carrera
            // 
            this.lbl_carrera.AutoSize = true;
            this.lbl_carrera.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_carrera.Location = new System.Drawing.Point(17, 78);
            this.lbl_carrera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_carrera.Name = "lbl_carrera";
            this.lbl_carrera.Size = new System.Drawing.Size(51, 19);
            this.lbl_carrera.TabIndex = 3;
            this.lbl_carrera.Text = "carrera";
            // 
            // lbl_semestre
            // 
            this.lbl_semestre.AutoSize = true;
            this.lbl_semestre.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_semestre.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_semestre.Location = new System.Drawing.Point(17, 103);
            this.lbl_semestre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_semestre.Name = "lbl_semestre";
            this.lbl_semestre.Size = new System.Drawing.Size(54, 15);
            this.lbl_semestre.TabIndex = 4;
            this.lbl_semestre.Text = "semestre";
            // 
            // Details_tutorado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 203);
            this.Controls.Add(this.lbl_semestre);
            this.Controls.Add(this.lbl_carrera);
            this.Controls.Add(this.lbl_NUA);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_nombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Details_tutorado";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Load += new System.EventHandler(this.Details_tutorado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroLabel lbl_nombre;
        public MetroFramework.Controls.MetroLabel lbl_correo;
        public MetroFramework.Controls.MetroLabel lbl_NUA;
        public MetroFramework.Controls.MetroLabel lbl_carrera;
        public MetroFramework.Controls.MetroLabel lbl_semestre;
    }
}