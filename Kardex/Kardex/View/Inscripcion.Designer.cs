namespace Kardex.View
{
    partial class Inscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripcion));
            this.list_materias = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_sel_mat = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_quitar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_inscrip = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // list_materias
            // 
            this.list_materias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.list_materias.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_materias.Location = new System.Drawing.Point(12, 374);
            this.list_materias.Name = "list_materias";
            this.list_materias.Size = new System.Drawing.Size(1478, 364);
            this.list_materias.TabIndex = 0;
            this.list_materias.UseCompatibleStateImageBehavior = false;
            this.list_materias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Clave";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unidad de Aprendizaje";
            this.columnHeader2.Width = 235;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Créditos";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Grupo";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Horario";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Días de clase";
            this.columnHeader6.Width = 126;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Salón";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Profesor";
            this.columnHeader8.Width = 500;
            // 
            // list_sel_mat
            // 
            this.list_sel_mat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader16,
            this.columnHeader12});
            this.list_sel_mat.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_sel_mat.Location = new System.Drawing.Point(210, 111);
            this.list_sel_mat.Name = "list_sel_mat";
            this.list_sel_mat.Size = new System.Drawing.Size(1065, 191);
            this.list_sel_mat.TabIndex = 1;
            this.list_sel_mat.UseCompatibleStateImageBehavior = false;
            this.list_sel_mat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Clave";
            this.columnHeader9.Width = 93;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Materia";
            this.columnHeader10.Width = 201;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Créditos";
            this.columnHeader11.Width = 107;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Profesor";
            this.columnHeader16.Width = 375;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Grupo";
            // 
            // btn_add
            // 
            this.btn_add.Active = false;
            this.btn_add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.BorderRadius = 0;
            this.btn_add.ButtonText = "Agregar";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_add.Iconimage")));
            this.btn_add.Iconimage_right = null;
            this.btn_add.Iconimage_right_Selected = null;
            this.btn_add.Iconimage_Selected = null;
            this.btn_add.IconMarginLeft = 0;
            this.btn_add.IconMarginRight = 0;
            this.btn_add.IconRightVisible = true;
            this.btn_add.IconRightZoom = 0D;
            this.btn_add.IconVisible = true;
            this.btn_add.IconZoom = 90D;
            this.btn_add.IsTab = false;
            this.btn_add.Location = new System.Drawing.Point(1280, 308);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add.selected = false;
            this.btn_add.Size = new System.Drawing.Size(209, 59);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Agregar";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Textcolor = System.Drawing.Color.White;
            this.btn_add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Active = false;
            this.btn_quitar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_quitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quitar.BorderRadius = 0;
            this.btn_quitar.ButtonText = "Quitar";
            this.btn_quitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_quitar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_quitar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_quitar.Iconimage")));
            this.btn_quitar.Iconimage_right = null;
            this.btn_quitar.Iconimage_right_Selected = null;
            this.btn_quitar.Iconimage_Selected = null;
            this.btn_quitar.IconMarginLeft = 0;
            this.btn_quitar.IconMarginRight = 0;
            this.btn_quitar.IconRightVisible = true;
            this.btn_quitar.IconRightZoom = 0D;
            this.btn_quitar.IconVisible = true;
            this.btn_quitar.IconZoom = 90D;
            this.btn_quitar.IsTab = false;
            this.btn_quitar.Location = new System.Drawing.Point(1094, 34);
            this.btn_quitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_quitar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_quitar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_quitar.selected = false;
            this.btn_quitar.Size = new System.Drawing.Size(209, 59);
            this.btn_quitar.TabIndex = 4;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quitar.Textcolor = System.Drawing.Color.White;
            this.btn_quitar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_inscrip
            // 
            this.btn_inscrip.Active = false;
            this.btn_inscrip.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_inscrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_inscrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inscrip.BorderRadius = 0;
            this.btn_inscrip.ButtonText = "Inscribirse";
            this.btn_inscrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inscrip.DisabledColor = System.Drawing.Color.Gray;
            this.btn_inscrip.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_inscrip.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_inscrip.Iconimage")));
            this.btn_inscrip.Iconimage_right = null;
            this.btn_inscrip.Iconimage_right_Selected = null;
            this.btn_inscrip.Iconimage_Selected = null;
            this.btn_inscrip.IconMarginLeft = 0;
            this.btn_inscrip.IconMarginRight = 0;
            this.btn_inscrip.IconRightVisible = true;
            this.btn_inscrip.IconRightZoom = 0D;
            this.btn_inscrip.IconVisible = true;
            this.btn_inscrip.IconZoom = 90D;
            this.btn_inscrip.IsTab = false;
            this.btn_inscrip.Location = new System.Drawing.Point(13, 34);
            this.btn_inscrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_inscrip.Name = "btn_inscrip";
            this.btn_inscrip.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_inscrip.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_inscrip.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_inscrip.selected = false;
            this.btn_inscrip.Size = new System.Drawing.Size(209, 59);
            this.btn_inscrip.TabIndex = 5;
            this.btn_inscrip.Text = "Inscribirse";
            this.btn_inscrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inscrip.Textcolor = System.Drawing.Color.White;
            this.btn_inscrip.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inscrip.Click += new System.EventHandler(this.btn_inscrip_Click);
            // 
            // Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 750);
            this.Controls.Add(this.btn_inscrip);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.list_sel_mat);
            this.Controls.Add(this.list_materias);
            this.Name = "Inscripcion";
            this.Text = "Inscripcion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_materias;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView list_sel_mat;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add;
        private Bunifu.Framework.UI.BunifuFlatButton btn_quitar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_inscrip;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}