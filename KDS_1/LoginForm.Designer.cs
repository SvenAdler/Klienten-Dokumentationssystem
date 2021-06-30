
namespace KDS_1
{
    partial class LoginForm
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
            this.textBoxNutzerPasswort = new System.Windows.Forms.TextBox();
            this.textBoxEmailAsNutzername = new System.Windows.Forms.TextBox();
            this.labelNutzerPasswort = new System.Windows.Forms.Label();
            this.labelEmailAsNutzername = new System.Windows.Forms.Label();
            this.panelNutzerLogin = new System.Windows.Forms.Panel();
            this.labelNutzerLogin = new System.Windows.Forms.Label();
            this.panelBorderForLog = new System.Windows.Forms.Panel();
            this.linkLabelNutzerRegistrieren = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelNutzerLogin.SuspendLayout();
            this.panelBorderForLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNutzerPasswort
            // 
            this.textBoxNutzerPasswort.Location = new System.Drawing.Point(121, 54);
            this.textBoxNutzerPasswort.Name = "textBoxNutzerPasswort";
            this.textBoxNutzerPasswort.Size = new System.Drawing.Size(200, 20);
            this.textBoxNutzerPasswort.TabIndex = 8;
            // 
            // textBoxEmailAsNutzername
            // 
            this.textBoxEmailAsNutzername.Location = new System.Drawing.Point(121, 23);
            this.textBoxEmailAsNutzername.Name = "textBoxEmailAsNutzername";
            this.textBoxEmailAsNutzername.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmailAsNutzername.TabIndex = 7;
            // 
            // labelNutzerPasswort
            // 
            this.labelNutzerPasswort.AutoSize = true;
            this.labelNutzerPasswort.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelNutzerPasswort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNutzerPasswort.Location = new System.Drawing.Point(4, 52);
            this.labelNutzerPasswort.Name = "labelNutzerPasswort";
            this.labelNutzerPasswort.Size = new System.Drawing.Size(66, 20);
            this.labelNutzerPasswort.TabIndex = 6;
            this.labelNutzerPasswort.Text = "Passwort";
            // 
            // labelEmailAsNutzername
            // 
            this.labelEmailAsNutzername.AutoSize = true;
            this.labelEmailAsNutzername.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelEmailAsNutzername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmailAsNutzername.Location = new System.Drawing.Point(4, 21);
            this.labelEmailAsNutzername.Name = "labelEmailAsNutzername";
            this.labelEmailAsNutzername.Size = new System.Drawing.Size(52, 20);
            this.labelEmailAsNutzername.TabIndex = 5;
            this.labelEmailAsNutzername.Text = "E-Mail";
            // 
            // panelNutzerLogin
            // 
            this.panelNutzerLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.panelNutzerLogin.Controls.Add(this.labelNutzerLogin);
            this.panelNutzerLogin.Location = new System.Drawing.Point(12, 40);
            this.panelNutzerLogin.Name = "panelNutzerLogin";
            this.panelNutzerLogin.Size = new System.Drawing.Size(333, 33);
            this.panelNutzerLogin.TabIndex = 9;
            // 
            // labelNutzerLogin
            // 
            this.labelNutzerLogin.AutoSize = true;
            this.labelNutzerLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelNutzerLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNutzerLogin.Location = new System.Drawing.Point(3, 2);
            this.labelNutzerLogin.Name = "labelNutzerLogin";
            this.labelNutzerLogin.Size = new System.Drawing.Size(59, 25);
            this.labelNutzerLogin.TabIndex = 4;
            this.labelNutzerLogin.Text = "Login";
            // 
            // panelBorderForLog
            // 
            this.panelBorderForLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBorderForLog.Controls.Add(this.buttonLogin);
            this.panelBorderForLog.Controls.Add(this.linkLabelNutzerRegistrieren);
            this.panelBorderForLog.Controls.Add(this.textBoxEmailAsNutzername);
            this.panelBorderForLog.Controls.Add(this.labelNutzerPasswort);
            this.panelBorderForLog.Controls.Add(this.textBoxNutzerPasswort);
            this.panelBorderForLog.Controls.Add(this.labelEmailAsNutzername);
            this.panelBorderForLog.Location = new System.Drawing.Point(12, 70);
            this.panelBorderForLog.Name = "panelBorderForLog";
            this.panelBorderForLog.Size = new System.Drawing.Size(333, 190);
            this.panelBorderForLog.TabIndex = 10;
            // 
            // linkLabelNutzerRegistrieren
            // 
            this.linkLabelNutzerRegistrieren.AutoSize = true;
            this.linkLabelNutzerRegistrieren.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabelNutzerRegistrieren.Location = new System.Drawing.Point(118, 147);
            this.linkLabelNutzerRegistrieren.Name = "linkLabelNutzerRegistrieren";
            this.linkLabelNutzerRegistrieren.Size = new System.Drawing.Size(95, 13);
            this.linkLabelNutzerRegistrieren.TabIndex = 11;
            this.linkLabelNutzerRegistrieren.TabStop = true;
            this.linkLabelNutzerRegistrieren.Text = "Nutzer registrieren.";
            this.linkLabelNutzerRegistrieren.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNutzerRegistrieren_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonLogin.Location = new System.Drawing.Point(121, 98);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(85, 31);
            this.buttonLogin.TabIndex = 12;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(357, 309);
            this.Controls.Add(this.panelNutzerLogin);
            this.Controls.Add(this.panelBorderForLog);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelNutzerLogin.ResumeLayout(false);
            this.panelNutzerLogin.PerformLayout();
            this.panelBorderForLog.ResumeLayout(false);
            this.panelBorderForLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNutzerPasswort;
        private System.Windows.Forms.TextBox textBoxEmailAsNutzername;
        private System.Windows.Forms.Label labelNutzerPasswort;
        private System.Windows.Forms.Label labelEmailAsNutzername;
        private System.Windows.Forms.Panel panelNutzerLogin;
        private System.Windows.Forms.Label labelNutzerLogin;
        private System.Windows.Forms.Panel panelBorderForLog;
        private System.Windows.Forms.LinkLabel linkLabelNutzerRegistrieren;
        private System.Windows.Forms.Button buttonLogin;
    }
}