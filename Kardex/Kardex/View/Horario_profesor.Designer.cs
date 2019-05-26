namespace Kardex.View
{
    partial class Horario_profesor
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
            this.cB_days = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.listV_days = new System.Windows.Forms.ListView();
            this.clave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.horario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cB_days
            // 
            this.cB_days.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cB_days.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cB_days.FormattingEnabled = true;
            this.cB_days.Location = new System.Drawing.Point(312, 19);
            this.cB_days.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cB_days.Name = "cB_days";
            this.cB_days.Size = new System.Drawing.Size(186, 27);
            this.cB_days.TabIndex = 13;
            this.cB_days.SelectedIndexChanged += new System.EventHandler(this.cB_days_SelectedIndexChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(6, 25);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(298, 30);
            this.bunifuCustomLabel2.TabIndex = 14;
            this.bunifuCustomLabel2.Text = "Seleccione el día de la semana para obtener su horario\r\n\r\n";
            // 
            // listV_days
            // 
            this.listV_days.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clave,
            this.materia,
            this.Salon,
            this.horario,
            this.grupo});
            this.listV_days.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listV_days.Location = new System.Drawing.Point(9, 82);
            this.listV_days.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listV_days.Name = "listV_days";
            this.listV_days.Size = new System.Drawing.Size(520, 207);
            this.listV_days.TabIndex = 1;
            this.listV_days.UseCompatibleStateImageBehavior = false;
            this.listV_days.View = System.Windows.Forms.View.Details;
            // 
            // clave
            // 
            this.clave.Text = "Clave";
            this.clave.Width = 69;
            // 
            // materia
            // 
            this.materia.Text = "Materia";
            this.materia.Width = 299;
            // 
            // Salon
            // 
            this.Salon.Text = "salón";
            this.Salon.Width = 85;
            // 
            // horario
            // 
            this.horario.Text = "Horario";
            this.horario.Width = 82;
            // 
            // grupo
            // 
            this.grupo.Text = "Grupo";
            this.grupo.Width = 104;
            // 
            // Horario_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(537, 298);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.listV_days);
            this.Controls.Add(this.cB_days);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Horario_profesor";
            this.Text = "Materias_profesor";
            this.Load += new System.EventHandler(this.Materias_profesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cB_days;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public System.Windows.Forms.ListView listV_days;
        private System.Windows.Forms.ColumnHeader clave;
        private System.Windows.Forms.ColumnHeader materia;
        private System.Windows.Forms.ColumnHeader Salon;
        private System.Windows.Forms.ColumnHeader horario;
        private System.Windows.Forms.ColumnHeader grupo;
    }
}