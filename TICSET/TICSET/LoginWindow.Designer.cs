﻿namespace TICSET
{
    partial class LoginWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_new_user = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_forgot_password = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome! Please Login.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 42);
            this.panel1.TabIndex = 0;
            // 
            // tb_username
            // 
            this.tb_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(93, 6);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(141, 27);
            this.tb_username.TabIndex = 0;
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_password);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(12, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 42);
            this.panel2.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(93, 6);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(141, 27);
            this.tb_password.TabIndex = 1;
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // lbl_new_user
            // 
            this.lbl_new_user.AutoSize = true;
            this.lbl_new_user.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_user.Location = new System.Drawing.Point(12, 134);
            this.lbl_new_user.Name = "lbl_new_user";
            this.lbl_new_user.Size = new System.Drawing.Size(150, 15);
            this.lbl_new_user.TabIndex = 0;
            this.lbl_new_user.Text = "New User? Create Account.";
            this.lbl_new_user.Click += new System.EventHandler(this.lbl_new_user_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.btn_login.Location = new System.Drawing.Point(84, 177);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(115, 31);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_forgot_password
            // 
            this.lbl_forgot_password.AutoSize = true;
            this.lbl_forgot_password.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgot_password.Location = new System.Drawing.Point(90, 211);
            this.lbl_forgot_password.Name = "lbl_forgot_password";
            this.lbl_forgot_password.Size = new System.Drawing.Size(104, 15);
            this.lbl_forgot_password.TabIndex = 0;
            this.lbl_forgot_password.Text = "Forgot Password?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_forgot_password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_new_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginWindow";
            this.Text = "Tic-Tac-Toe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_new_user;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_forgot_password;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}