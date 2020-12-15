namespace PhanMemDatVeXeBus
{
    partial class DashboardForm
    {
        //public class GlobalConfig











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
            this.buttonFIND = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginButton = new System.Windows.Forms.ToolStripMenuItem();
            this.registerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.guestRegisterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ownerRegisterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG ĐẶT VÉ XE BUS";
            // 
            // buttonFIND
            // 
            this.buttonFIND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFIND.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFIND.Location = new System.Drawing.Point(63, 149);
            this.buttonFIND.Name = "buttonFIND";
            this.buttonFIND.Size = new System.Drawing.Size(323, 55);
            this.buttonFIND.TabIndex = 0;
            this.buttonFIND.Text = "TÌM CHUYẾN XE";
            this.buttonFIND.UseVisualStyleBackColor = true;
            this.buttonFIND.Click += new System.EventHandler(this.buttonBooking_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonFIND);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.MenuStrip1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 403);
            this.panel3.TabIndex = 2;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginButton,
            this.registerMenu});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(461, 28);
            this.MenuStrip1.TabIndex = 4;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // loginButton
            // 
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 24);
            this.loginButton.Text = "Đăng nhập ";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerMenu
            // 
            this.registerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestRegisterButton,
            this.ownerRegisterButton});
            this.registerMenu.Name = "registerMenu";
            this.registerMenu.Size = new System.Drawing.Size(74, 24);
            this.registerMenu.Text = "Đăng kí";
            // 
            // guestRegisterButton
            // 
            this.guestRegisterButton.Name = "guestRegisterButton";
            this.guestRegisterButton.Size = new System.Drawing.Size(286, 26);
            this.guestRegisterButton.Text = "Đăng kí tài khoản hành khách";
            this.guestRegisterButton.Click += new System.EventHandler(this.guestRegisterButton_Click);
            // 
            // ownerRegisterButton
            // 
            this.ownerRegisterButton.Name = "ownerRegisterButton";
            this.ownerRegisterButton.Size = new System.Drawing.Size(286, 26);
            this.ownerRegisterButton.Text = "Đăng kí tài khoản nhà xe";
            this.ownerRegisterButton.Click += new System.EventHandler(this.ownerRegisterButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 424);
            this.Controls.Add(this.panel3);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "DashboardForm";
            this.Text = "Trang chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFIND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginButton;
        private System.Windows.Forms.ToolStripMenuItem registerMenu;
        private System.Windows.Forms.ToolStripMenuItem guestRegisterButton;
        private System.Windows.Forms.ToolStripMenuItem ownerRegisterButton;
    }
}

