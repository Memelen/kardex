namespace Kardex.View
{
    partial class Profile_alumno
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_carrera = new System.Windows.Forms.Label();
            this.lbl_semestre = new System.Windows.Forms.Label();
            this.lbl_nua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(12, 19);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(76, 24);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // lbl_carrera
            // 
            this.lbl_carrera.AutoSize = true;
            this.lbl_carrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carrera.Location = new System.Drawing.Point(12, 106);
            this.lbl_carrera.Name = "lbl_carrera";
            this.lbl_carrera.Size = new System.Drawing.Size(72, 24);
            this.lbl_carrera.TabIndex = 2;
            this.lbl_carrera.Text = "Carrera";
            // 
            // lbl_semestre
            // 
            this.lbl_semestre.AutoSize = true;
            this.lbl_semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_semestre.Location = new System.Drawing.Point(12, 144);
            this.lbl_semestre.Name = "lbl_semestre";
            this.lbl_semestre.Size = new System.Drawing.Size(90, 24);
            this.lbl_semestre.TabIndex = 3;
            this.lbl_semestre.Text = "Semestre";
            // 
            // lbl_nua
            // 
            this.lbl_nua.AutoSize = true;
            this.lbl_nua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nua.Location = new System.Drawing.Point(12, 56);
            this.lbl_nua.Name = "lbl_nua";
            this.lbl_nua.Size = new System.Drawing.Size(42, 24);
            this.lbl_nua.TabIndex = 4;
            this.lbl_nua.Text = "nua";
            // 
            // Profile_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 308);
            this.Controls.Add(this.lbl_nua);
            this.Controls.Add(this.lbl_semestre);
            this.Controls.Add(this.lbl_carrera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile_alumno";
            this.Text = "Profile_alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_carrera;
        private System.Windows.Forms.Label lbl_semestre;
        private System.Windows.Forms.Label lbl_nua;
    }
}