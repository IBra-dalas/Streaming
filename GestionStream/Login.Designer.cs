namespace GestionEmail
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.GroupeBoxArea = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnValider = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PnlLogin.SuspendLayout();
            this.GroupeBoxArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PnlLogin);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // PnlLogin
            // 
            this.PnlLogin.Controls.Add(this.GroupeBoxArea);
            resources.ApplyResources(this.PnlLogin, "PnlLogin");
            this.PnlLogin.Name = "PnlLogin";
            // 
            // GroupeBoxArea
            // 
            this.GroupeBoxArea.Controls.Add(this.label2);
            this.GroupeBoxArea.Controls.Add(this.TxtPassword);
            this.GroupeBoxArea.Controls.Add(this.label1);
            this.GroupeBoxArea.Controls.Add(this.TxtLogin);
            this.GroupeBoxArea.Controls.Add(this.BtnReset);
            this.GroupeBoxArea.Controls.Add(this.BtnValider);
            this.GroupeBoxArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.GroupeBoxArea, "GroupeBoxArea");
            this.GroupeBoxArea.Name = "GroupeBoxArea";
            this.GroupeBoxArea.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.TxtPassword, "TxtPassword");
            this.TxtPassword.Name = "TxtPassword";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TxtLogin
            // 
            resources.ApplyResources(this.TxtLogin, "TxtLogin");
            this.TxtLogin.Name = "TxtLogin";
            // 
            // BtnReset
            // 
            this.BtnReset.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.BtnReset, "BtnReset");
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnValider
            // 
            this.BtnValider.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.BtnValider, "BtnValider");
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.BackgroundImage = global::GestionEmail.Properties.Resources.téléchargement;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.PnlLogin.ResumeLayout(false);
            this.GroupeBoxArea.ResumeLayout(false);
            this.GroupeBoxArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.GroupBox GroupeBoxArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnValider;
    }
}