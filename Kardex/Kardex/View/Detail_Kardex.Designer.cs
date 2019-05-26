namespace Kardex.View
{
    partial class Detail_Kardex
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
            this.list_Kardex = new System.Windows.Forms.ListView();
            this.Materia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Oportunidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Calif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semestre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // list_Kardex
            // 
            this.list_Kardex.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Materia,
            this.Oportunidad,
            this.Grupo,
            this.Calif,
            this.Estatus,
            this.Semestre});
            this.list_Kardex.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Kardex.Location = new System.Drawing.Point(4, 5);
            this.list_Kardex.Margin = new System.Windows.Forms.Padding(5);
            this.list_Kardex.Name = "list_Kardex";
            this.list_Kardex.Size = new System.Drawing.Size(502, 289);
            this.list_Kardex.TabIndex = 2;
            this.list_Kardex.UseCompatibleStateImageBehavior = false;
            this.list_Kardex.View = System.Windows.Forms.View.Details;
            // 
            // Materia
            // 
            this.Materia.Text = "Materia";
            this.Materia.Width = 140;
            // 
            // Oportunidad
            // 
            this.Oportunidad.Text = "Op";
            // 
            // Grupo
            // 
            this.Grupo.Text = "Grupo";
            // 
            // Calif
            // 
            this.Calif.Text = "Calif";
            // 
            // Estatus
            // 
            this.Estatus.Text = "Estatus";
            this.Estatus.Width = 70;
            // 
            // Semestre
            // 
            this.Semestre.Text = "Semestre";
            this.Semestre.Width = 90;
            // 
            // Detail_Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 308);
            this.Controls.Add(this.list_Kardex);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Detail_Kardex";
            this.Text = "Detail_Kardex";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_Kardex;
        private System.Windows.Forms.ColumnHeader Materia;
        private System.Windows.Forms.ColumnHeader Oportunidad;
        private System.Windows.Forms.ColumnHeader Grupo;
        private System.Windows.Forms.ColumnHeader Calif;
        private System.Windows.Forms.ColumnHeader Estatus;
        private System.Windows.Forms.ColumnHeader Semestre;
    }
}