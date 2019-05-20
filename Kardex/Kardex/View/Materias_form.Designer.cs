namespace Kardex.View
{
    partial class Materias_form
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_cred = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(13, 13);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(25, 24);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "id";
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_materia.Location = new System.Drawing.Point(76, 13);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(71, 24);
            this.lbl_materia.TabIndex = 1;
            this.lbl_materia.Text = "Materia";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.Location = new System.Drawing.Point(415, 13);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(110, 24);
            this.lbl_desc.TabIndex = 2;
            this.lbl_desc.Text = "Descripcion";
            // 
            // lbl_cred
            // 
            this.lbl_cred.AutoSize = true;
            this.lbl_cred.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cred.Location = new System.Drawing.Point(633, 13);
            this.lbl_cred.Name = "lbl_cred";
            this.lbl_cred.Size = new System.Drawing.Size(79, 24);
            this.lbl_cred.TabIndex = 3;
            this.lbl_cred.Text = "Creditos";
            // 
            // Materias_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_cred);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_materia);
            this.Controls.Add(this.lbl_id);
            this.Name = "Materias_form";
            this.Text = "Materias_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.Label lbl_materia;
        public System.Windows.Forms.Label lbl_desc;
        public System.Windows.Forms.Label lbl_cred;
    }
}