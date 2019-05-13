namespace Kardex
{
    partial class Console_maestro
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
            this.lbl_NUE = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_dpto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_NUE
            // 
            this.lbl_NUE.AutoSize = true;
            this.lbl_NUE.Location = new System.Drawing.Point(0, 0);
            this.lbl_NUE.Name = "lbl_NUE";
            this.lbl_NUE.Size = new System.Drawing.Size(46, 17);
            this.lbl_NUE.TabIndex = 0;
            this.lbl_NUE.Text = "label1";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(0, 27);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(103, 38);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "label1";
            // 
            // lbl_dpto
            // 
            this.lbl_dpto.AutoSize = true;
            this.lbl_dpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dpto.Location = new System.Drawing.Point(4, 77);
            this.lbl_dpto.Name = "lbl_dpto";
            this.lbl_dpto.Size = new System.Drawing.Size(60, 24);
            this.lbl_dpto.TabIndex = 2;
            this.lbl_dpto.Text = "label1";
            // 
            // Console_maestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 214);
            this.Controls.Add(this.lbl_dpto);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_NUE);
            this.Name = "Console_maestro";
            this.Text = "Console_maestro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NUE;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_dpto;
    }
}