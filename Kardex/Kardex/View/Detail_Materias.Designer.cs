namespace Kardex.View
{
    partial class Detail_Materias
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
            this.listMaterias = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Creditos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listMaterias
            // 
            this.listMaterias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Descripcion,
            this.Creditos});
            this.listMaterias.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMaterias.Location = new System.Drawing.Point(13, 12);
            this.listMaterias.Name = "listMaterias";
            this.listMaterias.Size = new System.Drawing.Size(481, 287);
            this.listMaterias.TabIndex = 0;
            this.listMaterias.UseCompatibleStateImageBehavior = false;
            this.listMaterias.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 170;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // Creditos
            // 
            this.Creditos.Text = "Cretidos";
            this.Creditos.Width = 90;
            // 
            // Detail_Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 308);
            this.Controls.Add(this.listMaterias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Detail_Materias";
            this.Text = "Detail_Materias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listMaterias;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ColumnHeader Creditos;
    }
}