namespace Kardex.View
{
    partial class SuperUser_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperUser_Panel));
            this.list_detail = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dropBox_options = new Bunifu.Framework.UI.BunifuDropdown();
            this.btn_Update = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_insert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_borrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_refresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // list_detail
            // 
            this.list_detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.detail});
            this.list_detail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_detail.Location = new System.Drawing.Point(12, 162);
            this.list_detail.Name = "list_detail";
            this.list_detail.Size = new System.Drawing.Size(776, 241);
            this.list_detail.TabIndex = 0;
            this.list_detail.UseCompatibleStateImageBehavior = false;
            this.list_detail.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 106;
            // 
            // name
            // 
            this.name.Text = "Nombre";
            this.name.Width = 343;
            // 
            // detail
            // 
            this.detail.Text = "Detalle";
            this.detail.Width = 290;
            // 
            // dropBox_options
            // 
            this.dropBox_options.BackColor = System.Drawing.Color.Transparent;
            this.dropBox_options.BorderRadius = 3;
            this.dropBox_options.DisabledColor = System.Drawing.Color.WhiteSmoke;
            this.dropBox_options.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropBox_options.ForeColor = System.Drawing.Color.Black;
            this.dropBox_options.items = new string[0];
            this.dropBox_options.Location = new System.Drawing.Point(13, 15);
            this.dropBox_options.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dropBox_options.Name = "dropBox_options";
            this.dropBox_options.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.dropBox_options.onHoverColor = System.Drawing.Color.LightGray;
            this.dropBox_options.selectedIndex = -1;
            this.dropBox_options.Size = new System.Drawing.Size(449, 46);
            this.dropBox_options.TabIndex = 1;
            this.dropBox_options.onItemSelected += new System.EventHandler(this.dropBox_options_onItemSelected);
            // 
            // btn_Update
            // 
            this.btn_Update.Active = false;
            this.btn_Update.Activecolor = System.Drawing.Color.DarkGray;
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Update.BorderRadius = 0;
            this.btn_Update.ButtonText = "Actualizar";
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Update.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Update.Iconimage")));
            this.btn_Update.Iconimage_right = null;
            this.btn_Update.Iconimage_right_Selected = null;
            this.btn_Update.Iconimage_Selected = null;
            this.btn_Update.IconMarginLeft = 0;
            this.btn_Update.IconMarginRight = 0;
            this.btn_Update.IconRightVisible = true;
            this.btn_Update.IconRightZoom = 0D;
            this.btn_Update.IconVisible = true;
            this.btn_Update.IconZoom = 90D;
            this.btn_Update.IsTab = false;
            this.btn_Update.Location = new System.Drawing.Point(632, 112);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Normalcolor = System.Drawing.Color.White;
            this.btn_Update.OnHovercolor = System.Drawing.Color.LightGray;
            this.btn_Update.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Update.selected = false;
            this.btn_Update.Size = new System.Drawing.Size(156, 43);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Actualizar";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Textcolor = System.Drawing.Color.Black;
            this.btn_Update.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Active = false;
            this.btn_insert.Activecolor = System.Drawing.Color.DarkGray;
            this.btn_insert.BackColor = System.Drawing.Color.White;
            this.btn_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_insert.BorderRadius = 0;
            this.btn_insert.ButtonText = "Insertar";
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.DisabledColor = System.Drawing.Color.Gray;
            this.btn_insert.ForeColor = System.Drawing.Color.Black;
            this.btn_insert.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_insert.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_insert.Iconimage")));
            this.btn_insert.Iconimage_right = null;
            this.btn_insert.Iconimage_right_Selected = null;
            this.btn_insert.Iconimage_Selected = null;
            this.btn_insert.IconMarginLeft = 0;
            this.btn_insert.IconMarginRight = 0;
            this.btn_insert.IconRightVisible = true;
            this.btn_insert.IconRightZoom = 0D;
            this.btn_insert.IconVisible = true;
            this.btn_insert.IconZoom = 90D;
            this.btn_insert.IsTab = false;
            this.btn_insert.Location = new System.Drawing.Point(468, 112);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Normalcolor = System.Drawing.Color.White;
            this.btn_insert.OnHovercolor = System.Drawing.Color.LightGray;
            this.btn_insert.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_insert.selected = false;
            this.btn_insert.Size = new System.Drawing.Size(156, 43);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Insertar";
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.Textcolor = System.Drawing.Color.Black;
            this.btn_insert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Active = false;
            this.btn_borrar.Activecolor = System.Drawing.Color.DarkGray;
            this.btn_borrar.BackColor = System.Drawing.Color.White;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.BorderRadius = 0;
            this.btn_borrar.ButtonText = "Borrar";
            this.btn_borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_borrar.ForeColor = System.Drawing.Color.Black;
            this.btn_borrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_borrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_borrar.Iconimage")));
            this.btn_borrar.Iconimage_right = null;
            this.btn_borrar.Iconimage_right_Selected = null;
            this.btn_borrar.Iconimage_Selected = null;
            this.btn_borrar.IconMarginLeft = 0;
            this.btn_borrar.IconMarginRight = 0;
            this.btn_borrar.IconRightVisible = true;
            this.btn_borrar.IconRightZoom = 0D;
            this.btn_borrar.IconVisible = true;
            this.btn_borrar.IconZoom = 90D;
            this.btn_borrar.IsTab = false;
            this.btn_borrar.Location = new System.Drawing.Point(304, 112);
            this.btn_borrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Normalcolor = System.Drawing.Color.White;
            this.btn_borrar.OnHovercolor = System.Drawing.Color.LightGray;
            this.btn_borrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_borrar.selected = false;
            this.btn_borrar.Size = new System.Drawing.Size(156, 43);
            this.btn_borrar.TabIndex = 4;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borrar.Textcolor = System.Drawing.Color.Black;
            this.btn_borrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(769, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(19, 20);
            this.bunifuCustomLabel3.TabIndex = 14;
            this.bunifuCustomLabel3.Text = "X";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Active = false;
            this.btn_refresh.Activecolor = System.Drawing.Color.DarkGray;
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.BorderRadius = 0;
            this.btn_refresh.ButtonText = "Refresh";
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.DisabledColor = System.Drawing.Color.Gray;
            this.btn_refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_refresh.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_refresh.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Iconimage")));
            this.btn_refresh.Iconimage_right = null;
            this.btn_refresh.Iconimage_right_Selected = null;
            this.btn_refresh.Iconimage_Selected = null;
            this.btn_refresh.IconMarginLeft = 0;
            this.btn_refresh.IconMarginRight = 0;
            this.btn_refresh.IconRightVisible = true;
            this.btn_refresh.IconRightZoom = 0D;
            this.btn_refresh.IconVisible = true;
            this.btn_refresh.IconZoom = 90D;
            this.btn_refresh.IsTab = false;
            this.btn_refresh.Location = new System.Drawing.Point(140, 112);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Normalcolor = System.Drawing.Color.White;
            this.btn_refresh.OnHovercolor = System.Drawing.Color.LightGray;
            this.btn_refresh.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_refresh.selected = false;
            this.btn_refresh.Size = new System.Drawing.Size(158, 43);
            this.btn_refresh.TabIndex = 15;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Textcolor = System.Drawing.Color.Black;
            this.btn_refresh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // SuperUser_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dropBox_options);
            this.Controls.Add(this.list_detail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuperUser_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperUser_Panel";
            this.Load += new System.EventHandler(this.SuperUser_Panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader detail;
        public System.Windows.Forms.ListView list_detail;
        private Bunifu.Framework.UI.BunifuDropdown dropBox_options;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Update;
        private Bunifu.Framework.UI.BunifuFlatButton btn_insert;
        private Bunifu.Framework.UI.BunifuFlatButton btn_borrar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_refresh;
    }
}