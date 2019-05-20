namespace Kardex.View
{
    partial class Control_Alumno
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kardexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_nombreAl = new System.Windows.Forms.Label();
            this.lbl_semestre = new System.Windows.Forms.Label();
            this.lbl_carrera = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kardexToolStripMenuItem1,
            this.cuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kardexToolStripMenuItem1
            // 
            this.kardexToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kardexToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.horariosToolStripMenuItem});
            this.kardexToolStripMenuItem1.Name = "kardexToolStripMenuItem1";
            this.kardexToolStripMenuItem1.Size = new System.Drawing.Size(105, 20);
            this.kardexToolStripMenuItem1.Text = "Control Alumno";
            this.kardexToolStripMenuItem1.Click += new System.EventHandler(this.kardexToolStripMenuItem1_Click);
            // 
            // kardexToolStripMenuItem
            // 
            this.kardexToolStripMenuItem.Name = "kardexToolStripMenuItem";
            this.kardexToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.kardexToolStripMenuItem.Text = "Kardex";
            this.kardexToolStripMenuItem.Click += new System.EventHandler(this.kardexToolStripMenuItem_Click_1);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.materiasToolStripMenuItem.Text = "Materias";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // horariosToolStripMenuItem
            // 
            this.horariosToolStripMenuItem.Name = "horariosToolStripMenuItem";
            this.horariosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.horariosToolStripMenuItem.Text = "Horarios";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // lbl_nombreAl
            // 
            this.lbl_nombreAl.AutoSize = true;
            this.lbl_nombreAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreAl.Location = new System.Drawing.Point(22, 55);
            this.lbl_nombreAl.Name = "lbl_nombreAl";
            this.lbl_nombreAl.Size = new System.Drawing.Size(251, 31);
            this.lbl_nombreAl.TabIndex = 2;
            this.lbl_nombreAl.Text = "Nombre del Alumno";
            this.lbl_nombreAl.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_semestre
            // 
            this.lbl_semestre.AutoSize = true;
            this.lbl_semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_semestre.Location = new System.Drawing.Point(24, 105);
            this.lbl_semestre.Name = "lbl_semestre";
            this.lbl_semestre.Size = new System.Drawing.Size(100, 24);
            this.lbl_semestre.TabIndex = 3;
            this.lbl_semestre.Text = "Semestre: ";
            // 
            // lbl_carrera
            // 
            this.lbl_carrera.AutoSize = true;
            this.lbl_carrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carrera.Location = new System.Drawing.Point(24, 142);
            this.lbl_carrera.Name = "lbl_carrera";
            this.lbl_carrera.Size = new System.Drawing.Size(82, 24);
            this.lbl_carrera.TabIndex = 4;
            this.lbl_carrera.Text = "Carrera: ";
            // 
            // Control_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 385);
            this.Controls.Add(this.lbl_carrera);
            this.Controls.Add(this.lbl_semestre);
            this.Controls.Add(this.lbl_nombreAl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Control_Alumno";
            this.Text = "Alumno";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kardexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kardexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lbl_nombreAl;
        private System.Windows.Forms.Label lbl_semestre;
        private System.Windows.Forms.Label lbl_carrera;
    }
}