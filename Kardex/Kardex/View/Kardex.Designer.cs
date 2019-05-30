namespace Kardex.View
{
    partial class Kardex
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
            this.list_kardex = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cB_semestres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_kardex
            // 
            this.list_kardex.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.list_kardex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_kardex.Location = new System.Drawing.Point(12, 176);
            this.list_kardex.Name = "list_kardex";
            this.list_kardex.Size = new System.Drawing.Size(672, 237);
            this.list_kardex.TabIndex = 0;
            this.list_kardex.UseCompatibleStateImageBehavior = false;
            this.list_kardex.View = System.Windows.Forms.View.Details;
            this.list_kardex.SelectedIndexChanged += new System.EventHandler(this.list_kardex_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Clave";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Materia";
            this.columnHeader2.Width = 289;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "calificación";
            this.columnHeader4.Width = 108;
            // 
            // cB_semestres
            // 
            this.cB_semestres.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_semestres.FormattingEnabled = true;
            this.cB_semestres.Location = new System.Drawing.Point(538, 146);
            this.cB_semestres.Name = "cB_semestres";
            this.cB_semestres.Size = new System.Drawing.Size(146, 24);
            this.cB_semestres.TabIndex = 1;
            this.cB_semestres.SelectedIndexChanged += new System.EventHandler(this.cB_semestres_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_semestres);
            this.Controls.Add(this.list_kardex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kardex";
            this.Text = "Kardex";
            this.Load += new System.EventHandler(this.Kardex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_kardex;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cB_semestres;
        private System.Windows.Forms.Label label1;
    }
}