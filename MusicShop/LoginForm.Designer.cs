namespace MusicShop
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
            this.usernameLoginTB = new System.Windows.Forms.TextBox();
            this.passwordLoginTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.registerUsernameTB = new System.Windows.Forms.TextBox();
            this.passwordRegister1TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordRegister2TB = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLoginTB
            // 
            this.usernameLoginTB.Location = new System.Drawing.Point(70, 129);
            this.usernameLoginTB.Name = "usernameLoginTB";
            this.usernameLoginTB.Size = new System.Drawing.Size(176, 20);
            this.usernameLoginTB.TabIndex = 0;
            // 
            // passwordLoginTB
            // 
            this.passwordLoginTB.Location = new System.Drawing.Point(70, 177);
            this.passwordLoginTB.Name = "passwordLoginTB";
            this.passwordLoginTB.Size = new System.Drawing.Size(176, 20);
            this.passwordLoginTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(70, 218);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(171, 218);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.registerBtn);
            this.panelLogin.Controls.Add(this.usernameLoginTB);
            this.panelLogin.Controls.Add(this.loginBtn);
            this.panelLogin.Controls.Add(this.passwordLoginTB);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Location = new System.Drawing.Point(13, 13);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(330, 355);
            this.panelLogin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(112, 249);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // registerUsernameTB
            // 
            this.registerUsernameTB.Location = new System.Drawing.Point(70, 113);
            this.registerUsernameTB.Name = "registerUsernameTB";
            this.registerUsernameTB.Size = new System.Drawing.Size(176, 20);
            this.registerUsernameTB.TabIndex = 0;
            // 
            // passwordRegister1TB
            // 
            this.passwordRegister1TB.Location = new System.Drawing.Point(70, 168);
            this.passwordRegister1TB.Name = "passwordRegister1TB";
            this.passwordRegister1TB.Size = new System.Drawing.Size(176, 20);
            this.passwordRegister1TB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.label7);
            this.panelRegister.Controls.Add(this.passwordRegister2TB);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.submitBtn);
            this.panelRegister.Controls.Add(this.registerUsernameTB);
            this.panelRegister.Controls.Add(this.passwordRegister1TB);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Location = new System.Drawing.Point(10, 13);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(330, 355);
            this.panelRegister.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password";
            // 
            // passwordRegister2TB
            // 
            this.passwordRegister2TB.Location = new System.Drawing.Point(70, 218);
            this.passwordRegister2TB.Name = "passwordRegister2TB";
            this.passwordRegister2TB.Size = new System.Drawing.Size(176, 20);
            this.passwordRegister2TB.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 374);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panelLogin);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usernameLoginTB;
        private System.Windows.Forms.TextBox passwordLoginTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox registerUsernameTB;
        private System.Windows.Forms.TextBox passwordRegister1TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox passwordRegister2TB;
    }
}