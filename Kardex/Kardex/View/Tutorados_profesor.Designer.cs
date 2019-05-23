namespace Kardex.View
{
    partial class Tutorados_profesor
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
            this.list_tutorados = new MetroFramework.Controls.MetroListView();
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.correo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // list_tutorados
            // 
            this.list_tutorados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre,
            this.correo});
            this.list_tutorados.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.list_tutorados.FullRowSelect = true;
            this.list_tutorados.Location = new System.Drawing.Point(38, 81);
            this.list_tutorados.Name = "list_tutorados";
            this.list_tutorados.OwnerDraw = true;
            this.list_tutorados.Size = new System.Drawing.Size(612, 249);
            this.list_tutorados.TabIndex = 0;
            this.list_tutorados.UseCompatibleStateImageBehavior = false;
            this.list_tutorados.UseSelectable = true;
            this.list_tutorados.View = System.Windows.Forms.View.Details;
            this.list_tutorados.SelectedIndexChanged += new System.EventHandler(this.list_tutorados_SelectedIndexChanged);
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 220;
            // 
            // correo
            // 
            this.correo.Text = "correo";
            this.correo.Width = 291;
            // 
            // Tutorados_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 367);
            this.Controls.Add(this.list_tutorados);
            this.Name = "Tutorados_profesor";
            this.Text = "Tutorados_profesor";
            this.Load += new System.EventHandler(this.Tutorados_profesor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView list_tutorados;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader correo;
    }
}