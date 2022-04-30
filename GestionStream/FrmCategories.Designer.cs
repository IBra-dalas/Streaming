namespace GestionEmail
{
    partial class FrmCategories
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategories));
            this.tbcCategorie = new System.Windows.Forms.TabControl();
            this.tbcRecherche = new System.Windows.Forms.TabPage();
            this.pnlBoutton = new System.Windows.Forms.Panel();
            this.BtrAjouter = new System.Windows.Forms.Button();
            this.BtrSupprimer = new System.Windows.Forms.Button();
            this.BtrNouveau = new System.Windows.Forms.Button();
            this.BtrModifier = new System.Windows.Forms.Button();
            this.pnlAffichage = new System.Windows.Forms.Panel();
            this.dgvCategorie = new System.Windows.Forms.DataGridView();
            this.pnlRecherche = new System.Windows.Forms.Panel();
            this.BtrActualiser = new System.Windows.Forms.Button();
            this.lbrnomcat = new System.Windows.Forms.Label();
            this.lbrnumcat = new System.Windows.Forms.Label();
            this.txrnumcat = new System.Windows.Forms.TextBox();
            this.txrnomcat = new System.Windows.Forms.TextBox();
            this.tbcMiseAjour = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.BtnSpprimer = new System.Windows.Forms.Button();
            this.BnNouveau = new System.Windows.Forms.Button();
            this.pnlMiseAjour = new System.Windows.Forms.Panel();
            this.BtnAjoterProc = new System.Windows.Forms.Button();
            this.BtnVider = new System.Windows.Forms.Button();
            this.lbnomcat = new System.Windows.Forms.Label();
            this.lbnumcat = new System.Windows.Forms.Label();
            this.txtnumcat = new System.Windows.Forms.TextBox();
            this.txtnomcat = new System.Windows.Forms.TextBox();
            this.BtrQuitter = new System.Windows.Forms.Button();
            this.BtnContact = new System.Windows.Forms.Button();
            this.LbStatus = new System.Windows.Forms.Label();
            this.tbcCategorie.SuspendLayout();
            this.tbcRecherche.SuspendLayout();
            this.pnlBoutton.SuspendLayout();
            this.pnlAffichage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorie)).BeginInit();
            this.pnlRecherche.SuspendLayout();
            this.tbcMiseAjour.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMiseAjour.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCategorie
            // 
            this.tbcCategorie.Controls.Add(this.tbcRecherche);
            this.tbcCategorie.Controls.Add(this.tbcMiseAjour);
            this.tbcCategorie.Location = new System.Drawing.Point(2, 6);
            this.tbcCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.tbcCategorie.Name = "tbcCategorie";
            this.tbcCategorie.SelectedIndex = 0;
            this.tbcCategorie.Size = new System.Drawing.Size(518, 424);
            this.tbcCategorie.TabIndex = 0;
            // 
            // tbcRecherche
            // 
            this.tbcRecherche.Controls.Add(this.pnlBoutton);
            this.tbcRecherche.Controls.Add(this.BtrModifier);
            this.tbcRecherche.Controls.Add(this.pnlAffichage);
            this.tbcRecherche.Controls.Add(this.pnlRecherche);
            this.tbcRecherche.Location = new System.Drawing.Point(4, 22);
            this.tbcRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.tbcRecherche.Name = "tbcRecherche";
            this.tbcRecherche.Padding = new System.Windows.Forms.Padding(2);
            this.tbcRecherche.Size = new System.Drawing.Size(510, 398);
            this.tbcRecherche.TabIndex = 0;
            this.tbcRecherche.Text = "Recherche";
            this.tbcRecherche.UseVisualStyleBackColor = true;
            // 
            // pnlBoutton
            // 
            this.pnlBoutton.Controls.Add(this.BtrAjouter);
            this.pnlBoutton.Controls.Add(this.BtrSupprimer);
            this.pnlBoutton.Controls.Add(this.BtrNouveau);
            this.pnlBoutton.Location = new System.Drawing.Point(435, 85);
            this.pnlBoutton.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBoutton.Name = "pnlBoutton";
            this.pnlBoutton.Size = new System.Drawing.Size(79, 87);
            this.pnlBoutton.TabIndex = 5;
            // 
            // BtrAjouter
            // 
            this.BtrAjouter.Location = new System.Drawing.Point(2, 2);
            this.BtrAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.BtrAjouter.Name = "BtrAjouter";
            this.BtrAjouter.Size = new System.Drawing.Size(70, 39);
            this.BtrAjouter.TabIndex = 4;
            this.BtrAjouter.Text = "Ajouter";
            this.BtrAjouter.UseVisualStyleBackColor = true;
            this.BtrAjouter.Click += new System.EventHandler(this.BtrAjouter_Click);
            // 
            // BtrSupprimer
            // 
            this.BtrSupprimer.Location = new System.Drawing.Point(2, 60);
            this.BtrSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.BtrSupprimer.Name = "BtrSupprimer";
            this.BtrSupprimer.Size = new System.Drawing.Size(70, 39);
            this.BtrSupprimer.TabIndex = 1;
            this.BtrSupprimer.Text = "Supprimer";
            this.BtrSupprimer.UseVisualStyleBackColor = true;
            this.BtrSupprimer.Click += new System.EventHandler(this.BtrSupprimer_Click);
            // 
            // BtrNouveau
            // 
            this.BtrNouveau.Location = new System.Drawing.Point(2, 31);
            this.BtrNouveau.Margin = new System.Windows.Forms.Padding(2);
            this.BtrNouveau.Name = "BtrNouveau";
            this.BtrNouveau.Size = new System.Drawing.Size(70, 39);
            this.BtrNouveau.TabIndex = 0;
            this.BtrNouveau.Text = "Nouveau";
            this.BtrNouveau.UseVisualStyleBackColor = true;
            this.BtrNouveau.Click += new System.EventHandler(this.BtrNouveau_Click);
            // 
            // BtrModifier
            // 
            this.BtrModifier.Location = new System.Drawing.Point(0, 324);
            this.BtrModifier.Margin = new System.Windows.Forms.Padding(2);
            this.BtrModifier.Name = "BtrModifier";
            this.BtrModifier.Size = new System.Drawing.Size(110, 25);
            this.BtrModifier.TabIndex = 3;
            this.BtrModifier.Text = "Aller Modifier";
            this.BtrModifier.UseVisualStyleBackColor = true;
            this.BtrModifier.Click += new System.EventHandler(this.BtrModifier_Click);
            // 
            // pnlAffichage
            // 
            this.pnlAffichage.Controls.Add(this.dgvCategorie);
            this.pnlAffichage.Location = new System.Drawing.Point(2, 83);
            this.pnlAffichage.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAffichage.Name = "pnlAffichage";
            this.pnlAffichage.Size = new System.Drawing.Size(319, 237);
            this.pnlAffichage.TabIndex = 4;
            // 
            // dgvCategorie
            // 
            this.dgvCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorie.Location = new System.Drawing.Point(2, 2);
            this.dgvCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategorie.Name = "dgvCategorie";
            this.dgvCategorie.RowTemplate.Height = 24;
            this.dgvCategorie.Size = new System.Drawing.Size(427, 246);
            this.dgvCategorie.TabIndex = 0;
            this.dgvCategorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorie_CellContentClick);
            // 
            // pnlRecherche
            // 
            this.pnlRecherche.Controls.Add(this.BtrActualiser);
            this.pnlRecherche.Controls.Add(this.lbrnomcat);
            this.pnlRecherche.Controls.Add(this.lbrnumcat);
            this.pnlRecherche.Controls.Add(this.txrnumcat);
            this.pnlRecherche.Controls.Add(this.txrnomcat);
            this.pnlRecherche.Location = new System.Drawing.Point(4, 5);
            this.pnlRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRecherche.Name = "pnlRecherche";
            this.pnlRecherche.Size = new System.Drawing.Size(510, 76);
            this.pnlRecherche.TabIndex = 3;
            // 
            // BtrActualiser
            // 
            this.BtrActualiser.Location = new System.Drawing.Point(432, 42);
            this.BtrActualiser.Margin = new System.Windows.Forms.Padding(2);
            this.BtrActualiser.Name = "BtrActualiser";
            this.BtrActualiser.Size = new System.Drawing.Size(72, 26);
            this.BtrActualiser.TabIndex = 4;
            this.BtrActualiser.Text = "Actualiser";
            this.BtrActualiser.UseVisualStyleBackColor = true;
            this.BtrActualiser.Click += new System.EventHandler(this.BtrActualiser_Click);
            // 
            // lbrnomcat
            // 
            this.lbrnomcat.AutoSize = true;
            this.lbrnomcat.Location = new System.Drawing.Point(8, 55);
            this.lbrnomcat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbrnomcat.Name = "lbrnomcat";
            this.lbrnomcat.Size = new System.Drawing.Size(83, 13);
            this.lbrnomcat.TabIndex = 3;
            this.lbrnomcat.Text = "Nom Catégorie :";
            // 
            // lbrnumcat
            // 
            this.lbrnumcat.AutoSize = true;
            this.lbrnumcat.Location = new System.Drawing.Point(8, 20);
            this.lbrnumcat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbrnumcat.Name = "lbrnumcat";
            this.lbrnumcat.Size = new System.Drawing.Size(50, 13);
            this.lbrnumcat.TabIndex = 2;
            this.lbrnumcat.Text = "Numero :";
            // 
            // txrnumcat
            // 
            this.txrnumcat.Location = new System.Drawing.Point(95, 2);
            this.txrnumcat.Margin = new System.Windows.Forms.Padding(2);
            this.txrnumcat.Multiline = true;
            this.txrnumcat.Name = "txrnumcat";
            this.txrnumcat.Size = new System.Drawing.Size(314, 31);
            this.txrnumcat.TabIndex = 1;
            // 
            // txrnomcat
            // 
            this.txrnomcat.Location = new System.Drawing.Point(95, 37);
            this.txrnomcat.Margin = new System.Windows.Forms.Padding(2);
            this.txrnomcat.Multiline = true;
            this.txrnomcat.Name = "txrnomcat";
            this.txrnomcat.Size = new System.Drawing.Size(314, 31);
            this.txrnomcat.TabIndex = 0;
            // 
            // tbcMiseAjour
            // 
            this.tbcMiseAjour.Controls.Add(this.panel2);
            this.tbcMiseAjour.Controls.Add(this.pnlMiseAjour);
            this.tbcMiseAjour.Location = new System.Drawing.Point(4, 22);
            this.tbcMiseAjour.Margin = new System.Windows.Forms.Padding(2);
            this.tbcMiseAjour.Name = "tbcMiseAjour";
            this.tbcMiseAjour.Padding = new System.Windows.Forms.Padding(2);
            this.tbcMiseAjour.Size = new System.Drawing.Size(510, 398);
            this.tbcMiseAjour.TabIndex = 1;
            this.tbcMiseAjour.Text = "Mise à Jour";
            this.tbcMiseAjour.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnAjouter);
            this.panel2.Controls.Add(this.BtnModifier);
            this.panel2.Controls.Add(this.BtnQuitter);
            this.panel2.Controls.Add(this.BtnSpprimer);
            this.panel2.Controls.Add(this.BnNouveau);
            this.panel2.Location = new System.Drawing.Point(88, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 38);
            this.panel2.TabIndex = 6;
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(111, 2);
            this.BtnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(58, 28);
            this.BtnAjouter.TabIndex = 5;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(183, 2);
            this.BtnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(60, 28);
            this.BtnModifier.TabIndex = 3;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnQuitter.Location = new System.Drawing.Point(351, 2);
            this.BtnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(57, 28);
            this.BtnQuitter.TabIndex = 2;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // BtnSpprimer
            // 
            this.BtnSpprimer.Location = new System.Drawing.Point(257, 2);
            this.BtnSpprimer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSpprimer.Name = "BtnSpprimer";
            this.BtnSpprimer.Size = new System.Drawing.Size(80, 28);
            this.BtnSpprimer.TabIndex = 1;
            this.BtnSpprimer.Text = "Supprimer";
            this.BtnSpprimer.UseVisualStyleBackColor = true;
            this.BtnSpprimer.Click += new System.EventHandler(this.BtnSpprimer_Click);
            // 
            // BnNouveau
            // 
            this.BnNouveau.Location = new System.Drawing.Point(25, 2);
            this.BnNouveau.Margin = new System.Windows.Forms.Padding(2);
            this.BnNouveau.Name = "BnNouveau";
            this.BnNouveau.Size = new System.Drawing.Size(68, 28);
            this.BnNouveau.TabIndex = 0;
            this.BnNouveau.Text = "Nouveau";
            this.BnNouveau.UseVisualStyleBackColor = true;
            this.BnNouveau.Click += new System.EventHandler(this.BnNouveau_Click);
            // 
            // pnlMiseAjour
            // 
            this.pnlMiseAjour.Controls.Add(this.BtnAjoterProc);
            this.pnlMiseAjour.Controls.Add(this.BtnVider);
            this.pnlMiseAjour.Controls.Add(this.lbnomcat);
            this.pnlMiseAjour.Controls.Add(this.lbnumcat);
            this.pnlMiseAjour.Controls.Add(this.txtnumcat);
            this.pnlMiseAjour.Controls.Add(this.txtnomcat);
            this.pnlMiseAjour.Location = new System.Drawing.Point(7, 5);
            this.pnlMiseAjour.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMiseAjour.Name = "pnlMiseAjour";
            this.pnlMiseAjour.Size = new System.Drawing.Size(495, 89);
            this.pnlMiseAjour.TabIndex = 4;
            // 
            // BtnAjoterProc
            // 
            this.BtnAjoterProc.Location = new System.Drawing.Point(392, 49);
            this.BtnAjoterProc.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAjoterProc.Name = "BtnAjoterProc";
            this.BtnAjoterProc.Size = new System.Drawing.Size(97, 31);
            this.BtnAjoterProc.TabIndex = 6;
            this.BtnAjoterProc.Text = "Ajouter Proc";
            this.BtnAjoterProc.UseVisualStyleBackColor = true;
            this.BtnAjoterProc.Click += new System.EventHandler(this.BtnAjoterProc_Click);
            // 
            // BtnVider
            // 
            this.BtnVider.Location = new System.Drawing.Point(392, 7);
            this.BtnVider.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVider.Name = "BtnVider";
            this.BtnVider.Size = new System.Drawing.Size(97, 31);
            this.BtnVider.TabIndex = 5;
            this.BtnVider.Text = "Vider";
            this.BtnVider.UseVisualStyleBackColor = true;
            this.BtnVider.Click += new System.EventHandler(this.BtnVider_Click);
            // 
            // lbnomcat
            // 
            this.lbnomcat.AutoSize = true;
            this.lbnomcat.Location = new System.Drawing.Point(7, 66);
            this.lbnomcat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnomcat.Name = "lbnomcat";
            this.lbnomcat.Size = new System.Drawing.Size(83, 13);
            this.lbnomcat.TabIndex = 3;
            this.lbnomcat.Text = "Nom Catégorie :";
            // 
            // lbnumcat
            // 
            this.lbnumcat.AutoSize = true;
            this.lbnumcat.Location = new System.Drawing.Point(7, 31);
            this.lbnumcat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnumcat.Name = "lbnumcat";
            this.lbnumcat.Size = new System.Drawing.Size(50, 13);
            this.lbnumcat.TabIndex = 2;
            this.lbnumcat.Text = "Numero :";
            // 
            // txtnumcat
            // 
            this.txtnumcat.Location = new System.Drawing.Point(106, 13);
            this.txtnumcat.Margin = new System.Windows.Forms.Padding(2);
            this.txtnumcat.Multiline = true;
            this.txtnumcat.Name = "txtnumcat";
            this.txtnumcat.Size = new System.Drawing.Size(228, 31);
            this.txtnumcat.TabIndex = 1;
            // 
            // txtnomcat
            // 
            this.txtnomcat.Location = new System.Drawing.Point(106, 48);
            this.txtnomcat.Margin = new System.Windows.Forms.Padding(2);
            this.txtnomcat.Multiline = true;
            this.txtnomcat.Name = "txtnomcat";
            this.txtnomcat.Size = new System.Drawing.Size(228, 31);
            this.txtnomcat.TabIndex = 0;
            // 
            // BtrQuitter
            // 
            this.BtrQuitter.Location = new System.Drawing.Point(2, 430);
            this.BtrQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.BtrQuitter.Name = "BtrQuitter";
            this.BtrQuitter.Size = new System.Drawing.Size(47, 23);
            this.BtrQuitter.TabIndex = 2;
            this.BtrQuitter.Text = "Quitter";
            this.BtrQuitter.UseVisualStyleBackColor = true;
            this.BtrQuitter.Click += new System.EventHandler(this.BtrQuitter_Click);
            // 
            // BtnContact
            // 
            this.BtnContact.Location = new System.Drawing.Point(426, 430);
            this.BtnContact.Margin = new System.Windows.Forms.Padding(2);
            this.BtnContact.Name = "BtnContact";
            this.BtnContact.Size = new System.Drawing.Size(90, 23);
            this.BtnContact.TabIndex = 6;
            this.BtnContact.Text = "Mode Client";
            this.BtnContact.UseVisualStyleBackColor = true;
            this.BtnContact.Click += new System.EventHandler(this.BtnContact_Click);
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbStatus.ForeColor = System.Drawing.Color.Transparent;
            this.LbStatus.Location = new System.Drawing.Point(470, 6);
            this.LbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(50, 13);
            this.LbStatus.TabIndex = 7;
            this.LbStatus.Text = "STATUS";
            this.LbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbStatus.Click += new System.EventHandler(this.LbStatus_Click);
            // 
            // FrmCategories
            // 
            this.AcceptButton = this.BnNouveau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::GestionEmail.Properties.Resources.background;
            this.CancelButton = this.BtnQuitter;
            this.ClientSize = new System.Drawing.Size(519, 452);
            this.Controls.Add(this.LbStatus);
            this.Controls.Add(this.BtnContact);
            this.Controls.Add(this.BtrQuitter);
            this.Controls.Add(this.tbcCategorie);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORIES";
            this.Load += new System.EventHandler(this.FrmCategories_Load);
            this.Leave += new System.EventHandler(this.BtrQuitter_Click);
            this.tbcCategorie.ResumeLayout(false);
            this.tbcRecherche.ResumeLayout(false);
            this.pnlBoutton.ResumeLayout(false);
            this.pnlAffichage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorie)).EndInit();
            this.pnlRecherche.ResumeLayout(false);
            this.pnlRecherche.PerformLayout();
            this.tbcMiseAjour.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlMiseAjour.ResumeLayout(false);
            this.pnlMiseAjour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCategorie;
        private System.Windows.Forms.TabPage tbcRecherche;
        private System.Windows.Forms.TabPage tbcMiseAjour;
        private System.Windows.Forms.Panel pnlBoutton;
        private System.Windows.Forms.Button BtrModifier;
        private System.Windows.Forms.Button BtrQuitter;
        private System.Windows.Forms.Button BtrSupprimer;
        private System.Windows.Forms.Button BtrNouveau;
        private System.Windows.Forms.Panel pnlAffichage;
        private System.Windows.Forms.DataGridView dgvCategorie;
        private System.Windows.Forms.Panel pnlRecherche;
        private System.Windows.Forms.Label lbrnomcat;
        private System.Windows.Forms.Label lbrnumcat;
        private System.Windows.Forms.TextBox txrnumcat;
        private System.Windows.Forms.TextBox txrnomcat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Button BtnSpprimer;
        private System.Windows.Forms.Button BnNouveau;
        private System.Windows.Forms.Panel pnlMiseAjour;
        private System.Windows.Forms.Label lbnomcat;
        private System.Windows.Forms.Label lbnumcat;
        private System.Windows.Forms.TextBox txtnumcat;
        private System.Windows.Forms.TextBox txtnomcat;
        private System.Windows.Forms.Button BtrAjouter;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtrActualiser;
        private System.Windows.Forms.Button BtnVider;
        private System.Windows.Forms.Button BtnAjoterProc;
        private System.Windows.Forms.Button BtnContact;
        private System.Windows.Forms.Label LbStatus;
    }
}

