namespace GestionEmail
{
    partial class FrmContact
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContact));
            this.contactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestionDonneesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionDonneesDataSet = new GestionEmail.GestionDonneesDataSet();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactTableAdapter = new GestionEmail.GestionDonneesDataSetTableAdapters.ContactTableAdapter();
            this.TmVideo = new System.Windows.Forms.Timer(this.components);
            this.WinPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.headerText = new System.Windows.Forms.Label();
            this.itemListbox = new System.Windows.Forms.ListBox();
            this.itemListboxLabel = new System.Windows.Forms.Label();
            this.purchaseItem = new System.Windows.Forms.Button();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.shopingCartLabel = new System.Windows.Forms.Label();
            this.makePurchase = new System.Windows.Forms.Button();
            this.Streaming = new System.Windows.Forms.TabPage();
            this.ListViewBrowse = new System.Windows.Forms.ListView();
            this.BtnChoosefile = new System.Windows.Forms.Button();
            this.TxtBrowse = new System.Windows.Forms.TextBox();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.tabContact = new System.Windows.Forms.TabControl();
            this.LbStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDonneesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDonneesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinPlayer)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.Streaming.SuspendLayout();
            this.tabContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactBindingSource1
            // 
            this.contactBindingSource1.DataMember = "Contact";
            this.contactBindingSource1.DataSource = this.gestionDonneesDataSetBindingSource;
            // 
            // gestionDonneesDataSetBindingSource
            // 
            this.gestionDonneesDataSetBindingSource.DataSource = this.gestionDonneesDataSet;
            this.gestionDonneesDataSetBindingSource.Position = 0;
            // 
            // gestionDonneesDataSet
            // 
            this.gestionDonneesDataSet.DataSetName = "GestionDonneesDataSet";
            this.gestionDonneesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.gestionDonneesDataSet;
            // 
            // contactTableAdapter
            // 
            this.contactTableAdapter.ClearBeforeFill = true;
            // 
            // WinPlayer
            // 
            this.WinPlayer.Enabled = true;
            this.WinPlayer.Location = new System.Drawing.Point(175, 37);
            this.WinPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.WinPlayer.Name = "WinPlayer";
            this.WinPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WinPlayer.OcxState")));
            this.WinPlayer.Size = new System.Drawing.Size(668, 441);
            this.WinPlayer.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.makePurchase);
            this.tabPage3.Controls.Add(this.shopingCartLabel);
            this.tabPage3.Controls.Add(this.shoppingCartListbox);
            this.tabPage3.Controls.Add(this.purchaseItem);
            this.tabPage3.Controls.Add(this.itemListboxLabel);
            this.tabPage3.Controls.Add(this.itemListbox);
            this.tabPage3.Controls.Add(this.headerText);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(849, 483);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Espace de vente";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(6, 3);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(257, 33);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Marché Financier";
            // 
            // itemListbox
            // 
            this.itemListbox.FormattingEnabled = true;
            this.itemListbox.Location = new System.Drawing.Point(12, 55);
            this.itemListbox.Name = "itemListbox";
            this.itemListbox.Size = new System.Drawing.Size(311, 238);
            this.itemListbox.TabIndex = 1;
            // 
            // itemListboxLabel
            // 
            this.itemListboxLabel.AutoSize = true;
            this.itemListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemListboxLabel.Location = new System.Drawing.Point(9, 39);
            this.itemListboxLabel.Name = "itemListboxLabel";
            this.itemListboxLabel.Size = new System.Drawing.Size(71, 13);
            this.itemListboxLabel.TabIndex = 2;
            this.itemListboxLabel.Text = "Store Items";
            // 
            // purchaseItem
            // 
            this.purchaseItem.Location = new System.Drawing.Point(357, 147);
            this.purchaseItem.Name = "purchaseItem";
            this.purchaseItem.Size = new System.Drawing.Size(135, 35);
            this.purchaseItem.TabIndex = 3;
            this.purchaseItem.Text = "ADD TO CART ===>>>";
            this.purchaseItem.UseVisualStyleBackColor = true;
            this.purchaseItem.Click += new System.EventHandler(this.purchaseItem_Click);
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.Location = new System.Drawing.Point(526, 55);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(311, 238);
            this.shoppingCartListbox.TabIndex = 4;
            // 
            // shopingCartLabel
            // 
            this.shopingCartLabel.AutoSize = true;
            this.shopingCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopingCartLabel.Location = new System.Drawing.Point(523, 39);
            this.shopingCartLabel.Name = "shopingCartLabel";
            this.shopingCartLabel.Size = new System.Drawing.Size(87, 13);
            this.shopingCartLabel.TabIndex = 5;
            this.shopingCartLabel.Text = "Shopping Cart";
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(742, 299);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(95, 23);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "PURCHASE";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // Streaming
            // 
            this.Streaming.Controls.Add(this.LbStatus);
            this.Streaming.Controls.Add(this.BtnStart);
            this.Streaming.Controls.Add(this.BtnStop);
            this.Streaming.Controls.Add(this.TxtBrowse);
            this.Streaming.Controls.Add(this.WinPlayer);
            this.Streaming.Controls.Add(this.BtnChoosefile);
            this.Streaming.Controls.Add(this.ListViewBrowse);
            this.Streaming.Location = new System.Drawing.Point(4, 22);
            this.Streaming.Name = "Streaming";
            this.Streaming.Padding = new System.Windows.Forms.Padding(3);
            this.Streaming.Size = new System.Drawing.Size(849, 483);
            this.Streaming.TabIndex = 2;
            this.Streaming.Text = "Streaming";
            this.Streaming.UseVisualStyleBackColor = true;
            // 
            // ListViewBrowse
            // 
            this.ListViewBrowse.HideSelection = false;
            this.ListViewBrowse.Location = new System.Drawing.Point(6, 75);
            this.ListViewBrowse.Name = "ListViewBrowse";
            this.ListViewBrowse.Size = new System.Drawing.Size(164, 402);
            this.ListViewBrowse.TabIndex = 2;
            this.ListViewBrowse.UseCompatibleStateImageBehavior = false;
            // 
            // BtnChoosefile
            // 
            this.BtnChoosefile.Location = new System.Drawing.Point(6, 37);
            this.BtnChoosefile.Name = "BtnChoosefile";
            this.BtnChoosefile.Size = new System.Drawing.Size(55, 32);
            this.BtnChoosefile.TabIndex = 3;
            this.BtnChoosefile.Text = "Browse";
            this.BtnChoosefile.UseVisualStyleBackColor = true;
            this.BtnChoosefile.Click += new System.EventHandler(this.BtnChoosefile_Click);
            // 
            // TxtBrowse
            // 
            this.TxtBrowse.Location = new System.Drawing.Point(-52, 4);
            this.TxtBrowse.Multiline = true;
            this.TxtBrowse.Name = "TxtBrowse";
            this.TxtBrowse.Size = new System.Drawing.Size(836, 27);
            this.TxtBrowse.TabIndex = 4;
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(120, 37);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(50, 32);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(67, 37);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(50, 32);
            this.BtnStart.TabIndex = 6;
            this.BtnStart.Text = "Play";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.Streaming);
            this.tabContact.Controls.Add(this.tabPage3);
            this.tabContact.Location = new System.Drawing.Point(2, 1);
            this.tabContact.Margin = new System.Windows.Forms.Padding(2);
            this.tabContact.Name = "tabContact";
            this.tabContact.SelectedIndex = 0;
            this.tabContact.Size = new System.Drawing.Size(857, 509);
            this.tabContact.TabIndex = 0;
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbStatus.ForeColor = System.Drawing.Color.Transparent;
            this.LbStatus.Location = new System.Drawing.Point(789, 7);
            this.LbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(50, 13);
            this.LbStatus.TabIndex = 8;
            this.LbStatus.Text = "STATUS";
            this.LbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 510);
            this.Controls.Add(this.tabContact);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmContact";
            this.Text = "Bienvenue sur votre espace client";
            this.Load += new System.EventHandler(this.FrmContact_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContact_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDonneesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionDonneesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinPlayer)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.Streaming.ResumeLayout(false);
            this.Streaming.PerformLayout();
            this.tabContact.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GestionDonneesDataSet gestionDonneesDataSet;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private GestionDonneesDataSetTableAdapters.ContactTableAdapter contactTableAdapter;
        private System.Windows.Forms.BindingSource contactBindingSource1;
        private System.Windows.Forms.BindingSource gestionDonneesDataSetBindingSource;
        private System.Windows.Forms.Timer TmVideo;
        private AxWMPLib.AxWindowsMediaPlayer WinPlayer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label shopingCartLabel;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button purchaseItem;
        private System.Windows.Forms.Label itemListboxLabel;
        private System.Windows.Forms.ListBox itemListbox;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.TabPage Streaming;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.TextBox TxtBrowse;
        private System.Windows.Forms.Button BtnChoosefile;
        private System.Windows.Forms.ListView ListViewBrowse;
        private System.Windows.Forms.TabControl tabContact;
        private System.Windows.Forms.Label LbStatus;
        // private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}