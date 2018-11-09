namespace MusicShop
{
    partial class MusicShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.musicRecordListBox = new System.Windows.Forms.ListBox();
            this.musicRecordLabel = new System.Windows.Forms.Label();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.panelPurchase = new System.Windows.Forms.Panel();
            this.viewOrdersBtn = new System.Windows.Forms.Button();
            this.panelViewPurchase = new System.Windows.Forms.Panel();
            this.buyMoreBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelOrderBtn = new System.Windows.Forms.Button();
            this.viewListingBox = new System.Windows.Forms.ListBox();
            this.panelTopRecords = new System.Windows.Forms.Panel();
            this.showRecordBtn = new System.Windows.Forms.Button();
            this.topRecordsBackBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.recordsSoldLB = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.logoutLbl = new System.Windows.Forms.LinkLabel();
            this.viewRecordLbl = new System.Windows.Forms.LinkLabel();
            this.panelPurchase.SuspendLayout();
            this.panelViewPurchase.SuspendLayout();
            this.panelTopRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.headerText.Location = new System.Drawing.Point(25, 7);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(0, 19);
            this.headerText.TabIndex = 0;
            // 
            // musicRecordListBox
            // 
            this.musicRecordListBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.musicRecordListBox.FormattingEnabled = true;
            this.musicRecordListBox.ItemHeight = 20;
            this.musicRecordListBox.Location = new System.Drawing.Point(28, 54);
            this.musicRecordListBox.Name = "musicRecordListBox";
            this.musicRecordListBox.Size = new System.Drawing.Size(353, 164);
            this.musicRecordListBox.TabIndex = 1;
            // 
            // musicRecordLabel
            // 
            this.musicRecordLabel.AutoSize = true;
            this.musicRecordLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicRecordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.musicRecordLabel.Location = new System.Drawing.Point(125, 32);
            this.musicRecordLabel.Name = "musicRecordLabel";
            this.musicRecordLabel.Size = new System.Drawing.Size(131, 19);
            this.musicRecordLabel.TabIndex = 2;
            this.musicRecordLabel.Text = "Music Records";
            // 
            // purchaseButton
            // 
            this.purchaseButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.purchaseButton.Location = new System.Drawing.Point(142, 224);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(125, 29);
            this.purchaseButton.TabIndex = 6;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = false;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // panelPurchase
            // 
            this.panelPurchase.Controls.Add(this.viewOrdersBtn);
            this.panelPurchase.Controls.Add(this.musicRecordLabel);
            this.panelPurchase.Controls.Add(this.purchaseButton);
            this.panelPurchase.Controls.Add(this.musicRecordListBox);
            this.panelPurchase.Location = new System.Drawing.Point(22, 57);
            this.panelPurchase.Name = "panelPurchase";
            this.panelPurchase.Size = new System.Drawing.Size(466, 308);
            this.panelPurchase.TabIndex = 7;
            // 
            // viewOrdersBtn
            // 
            this.viewOrdersBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.viewOrdersBtn.Location = new System.Drawing.Point(142, 259);
            this.viewOrdersBtn.Name = "viewOrdersBtn";
            this.viewOrdersBtn.Size = new System.Drawing.Size(125, 29);
            this.viewOrdersBtn.TabIndex = 8;
            this.viewOrdersBtn.Text = "View Orders";
            this.viewOrdersBtn.UseVisualStyleBackColor = false;
            this.viewOrdersBtn.Click += new System.EventHandler(this.viewOrdersBtn_Click);
            // 
            // panelViewPurchase
            // 
            this.panelViewPurchase.Controls.Add(this.buyMoreBtn);
            this.panelViewPurchase.Controls.Add(this.label1);
            this.panelViewPurchase.Controls.Add(this.cancelOrderBtn);
            this.panelViewPurchase.Controls.Add(this.viewListingBox);
            this.panelViewPurchase.Location = new System.Drawing.Point(22, 57);
            this.panelViewPurchase.Name = "panelViewPurchase";
            this.panelViewPurchase.Size = new System.Drawing.Size(466, 308);
            this.panelViewPurchase.TabIndex = 9;
            // 
            // buyMoreBtn
            // 
            this.buyMoreBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buyMoreBtn.Location = new System.Drawing.Point(164, 271);
            this.buyMoreBtn.Name = "buyMoreBtn";
            this.buyMoreBtn.Size = new System.Drawing.Size(125, 29);
            this.buyMoreBtn.TabIndex = 8;
            this.buyMoreBtn.Text = "Buy More";
            this.buyMoreBtn.UseVisualStyleBackColor = false;
            this.buyMoreBtn.Click += new System.EventHandler(this.buyMoreBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(109, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Music Records You Purchased";
            // 
            // cancelOrderBtn
            // 
            this.cancelOrderBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cancelOrderBtn.Location = new System.Drawing.Point(164, 236);
            this.cancelOrderBtn.Name = "cancelOrderBtn";
            this.cancelOrderBtn.Size = new System.Drawing.Size(125, 29);
            this.cancelOrderBtn.TabIndex = 6;
            this.cancelOrderBtn.Text = "Cancel";
            this.cancelOrderBtn.UseVisualStyleBackColor = false;
            this.cancelOrderBtn.Click += new System.EventHandler(this.cancelOrderBtn_Click);
            // 
            // viewListingBox
            // 
            this.viewListingBox.BackColor = System.Drawing.SystemColors.Info;
            this.viewListingBox.FormattingEnabled = true;
            this.viewListingBox.ItemHeight = 20;
            this.viewListingBox.Location = new System.Drawing.Point(27, 66);
            this.viewListingBox.Name = "viewListingBox";
            this.viewListingBox.Size = new System.Drawing.Size(390, 164);
            this.viewListingBox.TabIndex = 1;
            // 
            // panelTopRecords
            // 
            this.panelTopRecords.Controls.Add(this.showRecordBtn);
            this.panelTopRecords.Controls.Add(this.topRecordsBackBtn);
            this.panelTopRecords.Controls.Add(this.label2);
            this.panelTopRecords.Controls.Add(this.recordsSoldLB);
            this.panelTopRecords.Location = new System.Drawing.Point(22, 57);
            this.panelTopRecords.Name = "panelTopRecords";
            this.panelTopRecords.Size = new System.Drawing.Size(466, 308);
            this.panelTopRecords.TabIndex = 10;
            // 
            // showRecordBtn
            // 
            this.showRecordBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.showRecordBtn.Location = new System.Drawing.Point(241, 224);
            this.showRecordBtn.Name = "showRecordBtn";
            this.showRecordBtn.Size = new System.Drawing.Size(125, 64);
            this.showRecordBtn.TabIndex = 9;
            this.showRecordBtn.Text = "Show Records";
            this.showRecordBtn.UseVisualStyleBackColor = false;
            this.showRecordBtn.Click += new System.EventHandler(this.showRecordBtn_Click);
            // 
            // topRecordsBackBtn
            // 
            this.topRecordsBackBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.topRecordsBackBtn.Location = new System.Drawing.Point(54, 224);
            this.topRecordsBackBtn.Name = "topRecordsBackBtn";
            this.topRecordsBackBtn.Size = new System.Drawing.Size(125, 64);
            this.topRecordsBackBtn.TabIndex = 8;
            this.topRecordsBackBtn.Text = "Back to Purchase";
            this.topRecordsBackBtn.UseVisualStyleBackColor = false;
            this.topRecordsBackBtn.Click += new System.EventHandler(this.topRecordsBackBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(79, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Music Records  Sold";
            // 
            // recordsSoldLB
            // 
            this.recordsSoldLB.BackColor = System.Drawing.SystemColors.Info;
            this.recordsSoldLB.FormattingEnabled = true;
            this.recordsSoldLB.ItemHeight = 20;
            this.recordsSoldLB.Location = new System.Drawing.Point(29, 54);
            this.recordsSoldLB.Name = "recordsSoldLB";
            this.recordsSoldLB.Size = new System.Drawing.Size(366, 164);
            this.recordsSoldLB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(69, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Welcome to Vinyls for Hip Hop Music";
            // 
            // logoutLbl
            // 
            this.logoutLbl.AutoSize = true;
            this.logoutLbl.Location = new System.Drawing.Point(45, 389);
            this.logoutLbl.Name = "logoutLbl";
            this.logoutLbl.Size = new System.Drawing.Size(66, 20);
            this.logoutLbl.TabIndex = 14;
            this.logoutLbl.TabStop = true;
            this.logoutLbl.Text = "Logout...";
            this.logoutLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLbl_LinkClicked);
            // 
            // viewRecordLbl
            // 
            this.viewRecordLbl.AutoSize = true;
            this.viewRecordLbl.Location = new System.Drawing.Point(345, 389);
            this.viewRecordLbl.Name = "viewRecordLbl";
            this.viewRecordLbl.Size = new System.Drawing.Size(130, 20);
            this.viewRecordLbl.TabIndex = 15;
            this.viewRecordLbl.TabStop = true;
            this.viewRecordLbl.Text = "View Records Sold";
            this.viewRecordLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewRecordLbl_LinkClicked);
            // 
            // MusicShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(499, 428);
            this.Controls.Add(this.viewRecordLbl);
            this.Controls.Add(this.logoutLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelTopRecords);
            this.Controls.Add(this.panelViewPurchase);
            this.Controls.Add(this.panelPurchase);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MusicShop";
            this.Text = "VHHM";
            this.Load += new System.EventHandler(this.MusicShop_Load);
            this.panelPurchase.ResumeLayout(false);
            this.panelPurchase.PerformLayout();
            this.panelViewPurchase.ResumeLayout(false);
            this.panelViewPurchase.PerformLayout();
            this.panelTopRecords.ResumeLayout(false);
            this.panelTopRecords.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox musicRecordListBox;
        private System.Windows.Forms.Label musicRecordLabel;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Panel panelPurchase;
        private System.Windows.Forms.Button viewOrdersBtn;
        private System.Windows.Forms.Panel panelViewPurchase;
        private System.Windows.Forms.Button buyMoreBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelOrderBtn;
        private System.Windows.Forms.ListBox viewListingBox;
        private System.Windows.Forms.Panel panelTopRecords;
        private System.Windows.Forms.Button topRecordsBackBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox recordsSoldLB;
        private System.Windows.Forms.Button showRecordBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel logoutLbl;
        private System.Windows.Forms.LinkLabel viewRecordLbl;
    }
}

