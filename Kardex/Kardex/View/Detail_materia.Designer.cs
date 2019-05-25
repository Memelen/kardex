namespace Kardex.View
{
    partial class Detail_materia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail_materia));
            this.lbl_materia = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_grupo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.list_alumnos = new System.Windows.Forms.ListView();
            this.NUA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.asistencias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cali = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_asistencias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_cali = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_values = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_panelinfo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_materia.Location = new System.Drawing.Point(36, 20);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(115, 38);
            this.lbl_materia.TabIndex = 0;
            this.lbl_materia.Text = "Materia";
            // 
            // lbl_grupo
            // 
            this.lbl_grupo.AutoSize = true;
            this.lbl_grupo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grupo.Location = new System.Drawing.Point(64, 68);
            this.lbl_grupo.Name = "lbl_grupo";
            this.lbl_grupo.Size = new System.Drawing.Size(58, 23);
            this.lbl_grupo.TabIndex = 1;
            this.lbl_grupo.Text = "Grupo";
            // 
            // list_alumnos
            // 
            this.list_alumnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NUA,
            this.nombre,
            this.asistencias,
            this.cali});
            this.list_alumnos.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_alumnos.Location = new System.Drawing.Point(12, 166);
            this.list_alumnos.Name = "list_alumnos";
            this.list_alumnos.Size = new System.Drawing.Size(1019, 221);
            this.list_alumnos.TabIndex = 2;
            this.list_alumnos.UseCompatibleStateImageBehavior = false;
            this.list_alumnos.View = System.Windows.Forms.View.Details;
            // 
            // NUA
            // 
            this.NUA.Text = "NUA";
            this.NUA.Width = 124;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 383;
            // 
            // asistencias
            // 
            this.asistencias.Text = "Asistencias";
            this.asistencias.Width = 128;
            // 
            // cali
            // 
            this.cali.Text = "Calificación";
            this.cali.Width = 237;
            // 
            // btn_asistencias
            // 
            this.btn_asistencias.Active = false;
            this.btn_asistencias.Activecolor = System.Drawing.Color.White;
            this.btn_asistencias.BackColor = System.Drawing.Color.White;
            this.btn_asistencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_asistencias.BorderRadius = 0;
            this.btn_asistencias.ButtonText = "Asistencia";
            this.btn_asistencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_asistencias.DisabledColor = System.Drawing.Color.Gray;
            this.btn_asistencias.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asistencias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_asistencias.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_asistencias.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_asistencias.Iconimage")));
            this.btn_asistencias.Iconimage_right = null;
            this.btn_asistencias.Iconimage_right_Selected = null;
            this.btn_asistencias.Iconimage_Selected = null;
            this.btn_asistencias.IconMarginLeft = 0;
            this.btn_asistencias.IconMarginRight = 0;
            this.btn_asistencias.IconRightVisible = true;
            this.btn_asistencias.IconRightZoom = 0D;
            this.btn_asistencias.IconVisible = true;
            this.btn_asistencias.IconZoom = 90D;
            this.btn_asistencias.IsTab = false;
            this.btn_asistencias.Location = new System.Drawing.Point(889, 125);
            this.btn_asistencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_asistencias.Name = "btn_asistencias";
            this.btn_asistencias.Normalcolor = System.Drawing.Color.White;
            this.btn_asistencias.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_asistencias.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_asistencias.selected = false;
            this.btn_asistencias.Size = new System.Drawing.Size(142, 34);
            this.btn_asistencias.TabIndex = 3;
            this.btn_asistencias.Text = "Asistencia";
            this.btn_asistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_asistencias.Textcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_asistencias.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asistencias.Click += new System.EventHandler(this.btn_asistencias_Click);
            // 
            // btn_cali
            // 
            this.btn_cali.Active = false;
            this.btn_cali.Activecolor = System.Drawing.Color.White;
            this.btn_cali.BackColor = System.Drawing.Color.White;
            this.btn_cali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cali.BorderRadius = 0;
            this.btn_cali.ButtonText = "Calificación";
            this.btn_cali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cali.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cali.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cali.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cali.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cali.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_cali.Iconimage")));
            this.btn_cali.Iconimage_right = null;
            this.btn_cali.Iconimage_right_Selected = null;
            this.btn_cali.Iconimage_Selected = null;
            this.btn_cali.IconMarginLeft = 0;
            this.btn_cali.IconMarginRight = 0;
            this.btn_cali.IconRightVisible = true;
            this.btn_cali.IconRightZoom = 0D;
            this.btn_cali.IconVisible = true;
            this.btn_cali.IconZoom = 90D;
            this.btn_cali.IsTab = false;
            this.btn_cali.Location = new System.Drawing.Point(695, 125);
            this.btn_cali.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cali.Name = "btn_cali";
            this.btn_cali.Normalcolor = System.Drawing.Color.White;
            this.btn_cali.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cali.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cali.selected = false;
            this.btn_cali.Size = new System.Drawing.Size(151, 34);
            this.btn_cali.TabIndex = 4;
            this.btn_cali.Text = "Calificación";
            this.btn_cali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cali.Textcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cali.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cali.Click += new System.EventHandler(this.btn_cali_Click);
            // 
            // txt_values
            // 
            this.txt_values.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_values.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_values.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_values.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_values.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_values.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_values.HintForeColor = System.Drawing.Color.Empty;
            this.txt_values.HintText = "";
            this.txt_values.isPassword = false;
            this.txt_values.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.txt_values.LineIdleColor = System.Drawing.Color.LightGray;
            this.txt_values.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txt_values.LineThickness = 3;
            this.txt_values.Location = new System.Drawing.Point(477, 123);
            this.txt_values.Margin = new System.Windows.Forms.Padding(4);
            this.txt_values.MaxLength = 32767;
            this.txt_values.Name = "txt_values";
            this.txt_values.Size = new System.Drawing.Size(193, 36);
            this.txt_values.TabIndex = 5;
            this.txt_values.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(371, 140);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(99, 19);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Inserte el valor:";
            // 
            // lbl_panelinfo
            // 
            this.lbl_panelinfo.AutoSize = true;
            this.lbl_panelinfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_panelinfo.ForeColor = System.Drawing.Color.Gray;
            this.lbl_panelinfo.Location = new System.Drawing.Point(12, 138);
            this.lbl_panelinfo.Name = "lbl_panelinfo";
            this.lbl_panelinfo.Size = new System.Drawing.Size(207, 21);
            this.lbl_panelinfo.TabIndex = 7;
            this.lbl_panelinfo.Text = "Seleccione los alumnos ";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(1021, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(19, 20);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "X";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // Detail_materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 420);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.lbl_panelinfo);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt_values);
            this.Controls.Add(this.btn_cali);
            this.Controls.Add(this.btn_asistencias);
            this.Controls.Add(this.list_alumnos);
            this.Controls.Add(this.lbl_grupo);
            this.Controls.Add(this.lbl_materia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Detail_materia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail_materia";
            this.Load += new System.EventHandler(this.Detail_materia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomLabel lbl_materia;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_grupo;
        private System.Windows.Forms.ListView list_alumnos;
        private System.Windows.Forms.ColumnHeader NUA;
        private System.Windows.Forms.ColumnHeader nombre;
        private Bunifu.Framework.UI.BunifuFlatButton btn_asistencias;
        private System.Windows.Forms.ColumnHeader asistencias;
        private System.Windows.Forms.ColumnHeader cali;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cali;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_values;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_panelinfo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}