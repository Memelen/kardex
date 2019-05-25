namespace Kardex.View
{
    partial class Materias_profesor
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
            this.cB_semestre = new System.Windows.Forms.ComboBox();
            this.list_materias = new System.Windows.Forms.ListView();
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // cB_semestre
            // 
            this.cB_semestre.Font = new System.Drawing.Font("Segoe UI Light", 10.2F);
            this.cB_semestre.FormattingEnabled = true;
            this.cB_semestre.Location = new System.Drawing.Point(375, 21);
            this.cB_semestre.Name = "cB_semestre";
            this.cB_semestre.Size = new System.Drawing.Size(329, 31);
            this.cB_semestre.TabIndex = 7;
            this.cB_semestre.SelectedIndexChanged += new System.EventHandler(this.cB_semestre_SelectedIndexChanged);
            // 
            // list_materias
            // 
            this.list_materias.BackColor = System.Drawing.Color.White;
            this.list_materias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre,
            this.grupo,
            this.descripcion});
            this.list_materias.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_materias.ForeColor = System.Drawing.Color.DimGray;
            this.list_materias.Location = new System.Drawing.Point(13, 109);
            this.list_materias.Margin = new System.Windows.Forms.Padding(4);
            this.list_materias.Name = "list_materias";
            this.list_materias.Size = new System.Drawing.Size(688, 230);
            this.list_materias.TabIndex = 8;
            this.list_materias.UseCompatibleStateImageBehavior = false;
            this.list_materias.View = System.Windows.Forms.View.Details;
            this.list_materias.SelectedIndexChanged += new System.EventHandler(this.list_materias_SelectedIndexChanged);
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 350;
            // 
            // grupo
            // 
            this.grupo.Text = "Grupo";
            this.grupo.Width = 75;
            // 
            // descripcion
            // 
            this.descripcion.Text = "Descripción";
            this.descripcion.Width = 310;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(66, 29);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(242, 17);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Seleccione el semestre a consultar";
            // 
            // Materias_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 367);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.list_materias);
            this.Controls.Add(this.cB_semestre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Materias_profesor";
            this.Text = "Details_materia";
            this.Load += new System.EventHandler(this.Details_materia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cB_semestre;
        private System.Windows.Forms.ListView list_materias;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader grupo;
        private System.Windows.Forms.ColumnHeader descripcion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}