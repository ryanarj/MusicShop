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
            this.panelPurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(13, 13);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(176, 19);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Welcome to M-Shop";
            // 
            // musicRecordListBox
            // 
            this.musicRecordListBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.musicRecordListBox.FormattingEnabled = true;
            this.musicRecordListBox.ItemHeight = 20;
            this.musicRecordListBox.Location = new System.Drawing.Point(27, 66);
            this.musicRecordListBox.Name = "musicRecordListBox";
            this.musicRecordListBox.Size = new System.Drawing.Size(299, 164);
            this.musicRecordListBox.TabIndex = 1;
            // 
            // musicRecordLabel
            // 
            this.musicRecordLabel.AutoSize = true;
            this.musicRecordLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicRecordLabel.Location = new System.Drawing.Point(90, 30);
            this.musicRecordLabel.Name = "musicRecordLabel";
            this.musicRecordLabel.Size = new System.Drawing.Size(131, 19);
            this.musicRecordLabel.TabIndex = 2;
            this.musicRecordLabel.Text = "Music Records";
            // 
            // purchaseButton
            // 
            this.purchaseButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.purchaseButton.Location = new System.Drawing.Point(113, 236);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(125, 29);
            this.purchaseButton.TabIndex = 6;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = false;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // panelPurchase
            // 
            this.panelPurchase.Controls.Add(this.musicRecordLabel);
            this.panelPurchase.Controls.Add(this.purchaseButton);
            this.panelPurchase.Controls.Add(this.musicRecordListBox);
            this.panelPurchase.Location = new System.Drawing.Point(17, 48);
            this.panelPurchase.Name = "panelPurchase";
            this.panelPurchase.Size = new System.Drawing.Size(363, 307);
            this.panelPurchase.TabIndex = 7;
            // 
            // MusicShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(395, 401);
            this.Controls.Add(this.panelPurchase);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MusicShop";
            this.Text = "Music Shop";
            this.panelPurchase.ResumeLayout(false);
            this.panelPurchase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox musicRecordListBox;
        private System.Windows.Forms.Label musicRecordLabel;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Panel panelPurchase;
    }
}

