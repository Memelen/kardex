namespace Kardex.View
{
    partial class LoginSU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSU));
            this.txt_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // txt_pass
            // 
            this.txt_pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_pass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_pass.HintForeColor = System.Drawing.Color.Empty;
            this.txt_pass.HintText = "contraseña";
            this.txt_pass.isPassword = true;
            this.txt_pass.LineFocusedColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_pass.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_pass.LineMouseHoverColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_pass.LineThickness = 2;
            this.txt_pass.Location = new System.Drawing.Point(13, 144);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.MaxLength = 32767;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(323, 32);
            this.txt_pass.TabIndex = 8;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_user
            // 
            this.txt_user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_user.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user.HintForeColor = System.Drawing.Color.Empty;
            this.txt_user.HintText = "Usuario";
            this.txt_user.isPassword = false;
            this.txt_user.LineFocusedColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_user.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_user.LineMouseHoverColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_user.LineThickness = 2;
            this.txt_user.Location = new System.Drawing.Point(13, 73);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.MaxLength = 32767;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(323, 32);
            this.txt_user.TabIndex = 7;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_login
            // 
            this.btn_login.ActiveBorderThickness = 1;
            this.btn_login.ActiveCornerRadius = 20;
            this.btn_login.ActiveFillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_login.ActiveForecolor = System.Drawing.Color.White;
            this.btn_login.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ButtonText = "Iniciar sesión";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleCornerRadius = 20;
            this.btn_login.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_login.IdleForecolor = System.Drawing.Color.White;
            this.btn_login.IdleLineColor = System.Drawing.Color.LightSkyBlue;
            this.btn_login.Location = new System.Drawing.Point(169, 219);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(167, 54);
            this.btn_login.TabIndex = 6;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(99, 22);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(159, 29);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Administrador";
            // 
            // LoginSU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 287);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginSU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginSU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_user;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_login;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}