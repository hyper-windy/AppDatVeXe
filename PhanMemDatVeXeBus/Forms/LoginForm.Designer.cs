namespace PhanMemDatVeXeBus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.username);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 239);
            this.panel1.TabIndex = 0;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(22, 176);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(112, 26);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Tài khoản mới";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(254, 173);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 29);
            this.exit.TabIndex = 5;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(148, 173);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 29);
            this.login.TabIndex = 4;
            this.login.Text = "Đăng nhập ";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(192, 111);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(173, 22);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập: ";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(192, 70);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(173, 22);
            this.username.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 272);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Đăng nhập ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerButton;
    }
}