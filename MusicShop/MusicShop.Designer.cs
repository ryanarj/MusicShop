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
            this.addToCartButton = new System.Windows.Forms.Button();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.purchaseButton = new System.Windows.Forms.Button();
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
            this.musicRecordListBox.Location = new System.Drawing.Point(17, 92);
            this.musicRecordListBox.Name = "musicRecordListBox";
            this.musicRecordListBox.Size = new System.Drawing.Size(299, 164);
            this.musicRecordListBox.TabIndex = 1;
            // 
            // musicRecordLabel
            // 
            this.musicRecordLabel.AutoSize = true;
            this.musicRecordLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicRecordLabel.Location = new System.Drawing.Point(13, 70);
            this.musicRecordLabel.Name = "musicRecordLabel";
            this.musicRecordLabel.Size = new System.Drawing.Size(131, 19);
            this.musicRecordLabel.TabIndex = 2;
            this.musicRecordLabel.Text = "Music Records";
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.addToCartButton.Location = new System.Drawing.Point(343, 133);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(125, 29);
            this.addToCartButton.TabIndex = 3;
            this.addToCartButton.Text = "Add to cart -->";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartLabel.Location = new System.Drawing.Point(498, 70);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(127, 19);
            this.shoppingCartLabel.TabIndex = 5;
            this.shoppingCartLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 20;
            this.shoppingCartListBox.Location = new System.Drawing.Point(502, 92);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(299, 164);
            this.shoppingCartListBox.TabIndex = 4;
            // 
            // purchaseButton
            // 
            this.purchaseButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.purchaseButton.Location = new System.Drawing.Point(343, 168);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(125, 29);
            this.purchaseButton.TabIndex = 6;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = false;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // MusicShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(813, 274);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.shoppingCartLabel);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.musicRecordLabel);
            this.Controls.Add(this.musicRecordListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MusicShop";
            this.Text = "Music Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox musicRecordListBox;
        private System.Windows.Forms.Label musicRecordLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Label shoppingCartLabel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button purchaseButton;
    }
}

