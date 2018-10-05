namespace MusicShop
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registerSubmitBtn = new System.Windows.Forms.Button();
            this.registerUsernameTB = new System.Windows.Forms.TextBox();
            this.registerPasswordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter a password";
            // 
            // registerSubmitBtn
            // 
            this.registerSubmitBtn.Location = new System.Drawing.Point(92, 133);
            this.registerSubmitBtn.Name = "registerSubmitBtn";
            this.registerSubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.registerSubmitBtn.TabIndex = 2;
            this.registerSubmitBtn.Text = "Submit";
            this.registerSubmitBtn.UseVisualStyleBackColor = true;
            this.registerSubmitBtn.Click += new System.EventHandler(this.registerSubmitBtn_Click);
            // 
            // registerUsernameTB
            // 
            this.registerUsernameTB.Location = new System.Drawing.Point(25, 41);
            this.registerUsernameTB.Name = "registerUsernameTB";
            this.registerUsernameTB.Size = new System.Drawing.Size(209, 20);
            this.registerUsernameTB.TabIndex = 3;
            // 
            // registerPasswordTB
            // 
            this.registerPasswordTB.Location = new System.Drawing.Point(25, 90);
            this.registerPasswordTB.Name = "registerPasswordTB";
            this.registerPasswordTB.Size = new System.Drawing.Size(209, 20);
            this.registerPasswordTB.TabIndex = 4;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 186);
            this.Controls.Add(this.registerPasswordTB);
            this.Controls.Add(this.registerUsernameTB);
            this.Controls.Add(this.registerSubmitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerSubmitBtn;
        private System.Windows.Forms.TextBox registerUsernameTB;
        private System.Windows.Forms.TextBox registerPasswordTB;
    }
}