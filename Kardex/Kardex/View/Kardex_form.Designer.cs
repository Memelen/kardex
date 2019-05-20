namespace Kardex.View
{
    partial class Kardex_form
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
            this.lbl_materia = new System.Windows.Forms.Label();
            this.lbl_calif = new System.Windows.Forms.Label();
            this.lbl_op = new System.Windows.Forms.Label();
            this.lbl_estatus = new System.Windows.Forms.Label();
            this.lbl_grupo = new System.Windows.Forms.Label();
            this.lbl_semestre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_materia.Location = new System.Drawing.Point(12, 9);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(71, 24);
            this.lbl_materia.TabIndex = 1;
            this.lbl_materia.Text = "Materia";
            // 
            // lbl_calif
            // 
            this.lbl_calif.AutoSize = true;
            this.lbl_calif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calif.Location = new System.Drawing.Point(561, 9);
            this.lbl_calif.Name = "lbl_calif";
            this.lbl_calif.Size = new System.Drawing.Size(45, 24);
            this.lbl_calif.TabIndex = 3;
            this.lbl_calif.Text = "Calif";
            // 
            // lbl_op
            // 
            this.lbl_op.AutoSize = true;
            this.lbl_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_op.Location = new System.Drawing.Point(341, 9);
            this.lbl_op.Name = "lbl_op";
            this.lbl_op.Size = new System.Drawing.Size(115, 24);
            this.lbl_op.TabIndex = 4;
            this.lbl_op.Text = "Oportunidad";
            // 
            // lbl_estatus
            // 
            this.lbl_estatus.AutoSize = true;
            this.lbl_estatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatus.Location = new System.Drawing.Point(636, 9);
            this.lbl_estatus.Name = "lbl_estatus";
            this.lbl_estatus.Size = new System.Drawing.Size(70, 24);
            this.lbl_estatus.TabIndex = 2;
            this.lbl_estatus.Text = "Estatus";
            // 
            // lbl_grupo
            // 
            this.lbl_grupo.AutoSize = true;
            this.lbl_grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupo.Location = new System.Drawing.Point(477, 9);
            this.lbl_grupo.Name = "lbl_grupo";
            this.lbl_grupo.Size = new System.Drawing.Size(63, 24);
            this.lbl_grupo.TabIndex = 5;
            this.lbl_grupo.Text = "Grupo";
            // 
            // lbl_semestre
            // 
            this.lbl_semestre.AutoSize = true;
            this.lbl_semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_semestre.Location = new System.Drawing.Point(740, 9);
            this.lbl_semestre.Name = "lbl_semestre";
            this.lbl_semestre.Size = new System.Drawing.Size(90, 24);
            this.lbl_semestre.TabIndex = 6;
            this.lbl_semestre.Text = "Semestre";
            // 
            // Kardex_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.lbl_semestre);
            this.Controls.Add(this.lbl_grupo);
            this.Controls.Add(this.lbl_op);
            this.Controls.Add(this.lbl_calif);
            this.Controls.Add(this.lbl_estatus);
            this.Controls.Add(this.lbl_materia);
            this.Name = "Kardex_form";
            this.Text = "Kardex_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl_materia;
        public System.Windows.Forms.Label lbl_calif;
        public System.Windows.Forms.Label lbl_op;
        public System.Windows.Forms.Label lbl_estatus;
        public System.Windows.Forms.Label lbl_grupo;
        public System.Windows.Forms.Label lbl_semestre;
    }
}