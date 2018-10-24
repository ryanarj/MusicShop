namespace MusicShop
{
    partial class AdminForm
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
            this.panelAdminMenu = new System.Windows.Forms.Panel();
            this.viewRecordBtn = new System.Windows.Forms.Button();
            this.addRecordBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.deleteRecordBtn = new System.Windows.Forms.Button();
            this.panelAdminDeleteRecord = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.recordIdTB = new System.Windows.Forms.TextBox();
            this.deleteRecordPanelBtn = new System.Windows.Forms.Button();
            this.panelAddRecord = new System.Windows.Forms.Panel();
            this.artistRecordPriceTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.artistNameTB = new System.Windows.Forms.TextBox();
            this.addRecordPanelBtn = new System.Windows.Forms.Button();
            this.artistRecordNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelAdminMenu.SuspendLayout();
            this.panelAdminDeleteRecord.SuspendLayout();
            this.panelAddRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdminMenu
            // 
            this.panelAdminMenu.Controls.Add(this.viewRecordBtn);
            this.panelAdminMenu.Controls.Add(this.addRecordBtn);
            this.panelAdminMenu.Controls.Add(this.label16);
            this.panelAdminMenu.Controls.Add(this.deleteRecordBtn);
            this.panelAdminMenu.Location = new System.Drawing.Point(6, 12);
            this.panelAdminMenu.Name = "panelAdminMenu";
            this.panelAdminMenu.Size = new System.Drawing.Size(330, 355);
            this.panelAdminMenu.TabIndex = 12;
            // 
            // viewRecordBtn
            // 
            this.viewRecordBtn.Location = new System.Drawing.Point(228, 126);
            this.viewRecordBtn.Name = "viewRecordBtn";
            this.viewRecordBtn.Size = new System.Drawing.Size(75, 23);
            this.viewRecordBtn.TabIndex = 6;
            this.viewRecordBtn.Text = "View Records";
            this.viewRecordBtn.UseVisualStyleBackColor = true;
            // 
            // addRecordBtn
            // 
            this.addRecordBtn.Location = new System.Drawing.Point(23, 126);
            this.addRecordBtn.Name = "addRecordBtn";
            this.addRecordBtn.Size = new System.Drawing.Size(75, 23);
            this.addRecordBtn.TabIndex = 5;
            this.addRecordBtn.Text = "Add Record";
            this.addRecordBtn.UseVisualStyleBackColor = true;
            this.addRecordBtn.Click += new System.EventHandler(this.addRecordBtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Admin Control Panel";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deleteRecordBtn
            // 
            this.deleteRecordBtn.Location = new System.Drawing.Point(122, 126);
            this.deleteRecordBtn.Name = "deleteRecordBtn";
            this.deleteRecordBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteRecordBtn.TabIndex = 4;
            this.deleteRecordBtn.Text = "Delete Records";
            this.deleteRecordBtn.UseVisualStyleBackColor = true;
            // 
            // panelAdminDeleteRecord
            // 
            this.panelAdminDeleteRecord.Controls.Add(this.label11);
            this.panelAdminDeleteRecord.Controls.Add(this.label12);
            this.panelAdminDeleteRecord.Controls.Add(this.recordIdTB);
            this.panelAdminDeleteRecord.Controls.Add(this.deleteRecordPanelBtn);
            this.panelAdminDeleteRecord.Location = new System.Drawing.Point(9, 12);
            this.panelAdminDeleteRecord.Name = "panelAdminDeleteRecord";
            this.panelAdminDeleteRecord.Size = new System.Drawing.Size(330, 355);
            this.panelAdminDeleteRecord.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Enter Record ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Admin Delete Record";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recordIdTB
            // 
            this.recordIdTB.Location = new System.Drawing.Point(52, 144);
            this.recordIdTB.Name = "recordIdTB";
            this.recordIdTB.Size = new System.Drawing.Size(176, 20);
            this.recordIdTB.TabIndex = 0;
            // 
            // deleteRecordPanelBtn
            // 
            this.deleteRecordPanelBtn.Location = new System.Drawing.Point(101, 183);
            this.deleteRecordPanelBtn.Name = "deleteRecordPanelBtn";
            this.deleteRecordPanelBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteRecordPanelBtn.TabIndex = 4;
            this.deleteRecordPanelBtn.Text = "Delete";
            this.deleteRecordPanelBtn.UseVisualStyleBackColor = true;
            // 
            // panelAddRecord
            // 
            this.panelAddRecord.Controls.Add(this.artistRecordPriceTB);
            this.panelAddRecord.Controls.Add(this.label9);
            this.panelAddRecord.Controls.Add(this.label8);
            this.panelAddRecord.Controls.Add(this.label5);
            this.panelAddRecord.Controls.Add(this.artistNameTB);
            this.panelAddRecord.Controls.Add(this.addRecordPanelBtn);
            this.panelAddRecord.Controls.Add(this.artistRecordNameTB);
            this.panelAddRecord.Controls.Add(this.label6);
            this.panelAddRecord.Location = new System.Drawing.Point(9, 12);
            this.panelAddRecord.Name = "panelAddRecord";
            this.panelAddRecord.Size = new System.Drawing.Size(330, 355);
            this.panelAddRecord.TabIndex = 10;
            // 
            // artistRecordPriceTB
            // 
            this.artistRecordPriceTB.Location = new System.Drawing.Point(52, 204);
            this.artistRecordPriceTB.Name = "artistRecordPriceTB";
            this.artistRecordPriceTB.Size = new System.Drawing.Size(176, 20);
            this.artistRecordPriceTB.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Artist record price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Artist name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Admin Add Record";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // artistNameTB
            // 
            this.artistNameTB.Location = new System.Drawing.Point(52, 106);
            this.artistNameTB.Name = "artistNameTB";
            this.artistNameTB.Size = new System.Drawing.Size(176, 20);
            this.artistNameTB.TabIndex = 0;
            // 
            // addRecordPanelBtn
            // 
            this.addRecordPanelBtn.Location = new System.Drawing.Point(107, 249);
            this.addRecordPanelBtn.Name = "addRecordPanelBtn";
            this.addRecordPanelBtn.Size = new System.Drawing.Size(75, 23);
            this.addRecordPanelBtn.TabIndex = 4;
            this.addRecordPanelBtn.Text = "Add Record";
            this.addRecordPanelBtn.UseVisualStyleBackColor = true;
            this.addRecordPanelBtn.Click += new System.EventHandler(this.addRecordPanelBtn_Click);
            // 
            // artistRecordNameTB
            // 
            this.artistRecordNameTB.Location = new System.Drawing.Point(52, 153);
            this.artistRecordNameTB.Name = "artistRecordNameTB";
            this.artistRecordNameTB.Size = new System.Drawing.Size(176, 20);
            this.artistRecordNameTB.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Artist record name";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 365);
            this.Controls.Add(this.panelAdminMenu);
            this.Controls.Add(this.panelAdminDeleteRecord);
            this.Controls.Add(this.panelAddRecord);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panelAdminMenu.ResumeLayout(false);
            this.panelAdminMenu.PerformLayout();
            this.panelAdminDeleteRecord.ResumeLayout(false);
            this.panelAdminDeleteRecord.PerformLayout();
            this.panelAddRecord.ResumeLayout(false);
            this.panelAddRecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdminMenu;
        private System.Windows.Forms.Button viewRecordBtn;
        private System.Windows.Forms.Button addRecordBtn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button deleteRecordBtn;
        private System.Windows.Forms.Panel panelAdminDeleteRecord;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox recordIdTB;
        private System.Windows.Forms.Button deleteRecordPanelBtn;
        private System.Windows.Forms.Panel panelAddRecord;
        private System.Windows.Forms.TextBox artistRecordPriceTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox artistNameTB;
        private System.Windows.Forms.Button addRecordPanelBtn;
        private System.Windows.Forms.TextBox artistRecordNameTB;
        private System.Windows.Forms.Label label6;
    }
}