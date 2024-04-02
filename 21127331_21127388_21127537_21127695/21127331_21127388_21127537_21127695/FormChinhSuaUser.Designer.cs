namespace _21127331_21127388_21127537_21127695
{
    partial class FormChinhSuaUser
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
            this.lb_chinhsuauser_username = new System.Windows.Forms.Label();
            this.lb_chinhsuauser_password = new System.Windows.Forms.Label();
            this.tb_chinhsuauser_username = new System.Windows.Forms.TextBox();
            this.tb_chinhsuauser_password = new System.Windows.Forms.TextBox();
            this.btn_chinhsuauser_huy = new System.Windows.Forms.Button();
            this.btn_chinhsuauser_xacnhan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_chinhsuauser_username
            // 
            this.lb_chinhsuauser_username.AutoSize = true;
            this.lb_chinhsuauser_username.Location = new System.Drawing.Point(12, 29);
            this.lb_chinhsuauser_username.Name = "lb_chinhsuauser_username";
            this.lb_chinhsuauser_username.Size = new System.Drawing.Size(51, 13);
            this.lb_chinhsuauser_username.TabIndex = 0;
            this.lb_chinhsuauser_username.Text = "Tên User";
            // 
            // lb_chinhsuauser_password
            // 
            this.lb_chinhsuauser_password.AutoSize = true;
            this.lb_chinhsuauser_password.Location = new System.Drawing.Point(12, 70);
            this.lb_chinhsuauser_password.Name = "lb_chinhsuauser_password";
            this.lb_chinhsuauser_password.Size = new System.Drawing.Size(71, 13);
            this.lb_chinhsuauser_password.TabIndex = 1;
            this.lb_chinhsuauser_password.Text = "Mật khẩu mới";
            // 
            // tb_chinhsuauser_username
            // 
            this.tb_chinhsuauser_username.Location = new System.Drawing.Point(99, 29);
            this.tb_chinhsuauser_username.Name = "tb_chinhsuauser_username";
            this.tb_chinhsuauser_username.Size = new System.Drawing.Size(246, 20);
            this.tb_chinhsuauser_username.TabIndex = 2;
            // 
            // tb_chinhsuauser_password
            // 
            this.tb_chinhsuauser_password.Location = new System.Drawing.Point(99, 70);
            this.tb_chinhsuauser_password.Name = "tb_chinhsuauser_password";
            this.tb_chinhsuauser_password.Size = new System.Drawing.Size(246, 20);
            this.tb_chinhsuauser_password.TabIndex = 3;
            this.tb_chinhsuauser_password.UseSystemPasswordChar = true;
            // 
            // btn_chinhsuauser_huy
            // 
            this.btn_chinhsuauser_huy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_chinhsuauser_huy.Location = new System.Drawing.Point(99, 109);
            this.btn_chinhsuauser_huy.Name = "btn_chinhsuauser_huy";
            this.btn_chinhsuauser_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_chinhsuauser_huy.TabIndex = 4;
            this.btn_chinhsuauser_huy.Text = "Hủy";
            this.btn_chinhsuauser_huy.UseVisualStyleBackColor = false;
            this.btn_chinhsuauser_huy.Click += new System.EventHandler(this.btn_chinhsuauser_huy_Click);
            // 
            // btn_chinhsuauser_xacnhan
            // 
            this.btn_chinhsuauser_xacnhan.Location = new System.Drawing.Point(184, 109);
            this.btn_chinhsuauser_xacnhan.Name = "btn_chinhsuauser_xacnhan";
            this.btn_chinhsuauser_xacnhan.Size = new System.Drawing.Size(78, 23);
            this.btn_chinhsuauser_xacnhan.TabIndex = 5;
            this.btn_chinhsuauser_xacnhan.Text = "Đổi mật khẩu";
            this.btn_chinhsuauser_xacnhan.UseVisualStyleBackColor = true;
            this.btn_chinhsuauser_xacnhan.Click += new System.EventHandler(this.btn_chinhsuauser_xacnhan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_chinhsuauser_username);
            this.panel1.Controls.Add(this.lb_chinhsuauser_password);
            this.panel1.Controls.Add(this.btn_chinhsuauser_xacnhan);
            this.panel1.Controls.Add(this.lb_chinhsuauser_username);
            this.panel1.Controls.Add(this.tb_chinhsuauser_password);
            this.panel1.Controls.Add(this.btn_chinhsuauser_huy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 158);
            this.panel1.TabIndex = 6;
            // 
            // FormChinhSuaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 158);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FormChinhSuaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChinhSuaUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_chinhsuauser_username;
        private System.Windows.Forms.Label lb_chinhsuauser_password;
        private System.Windows.Forms.TextBox tb_chinhsuauser_username;
        private System.Windows.Forms.TextBox tb_chinhsuauser_password;
        private System.Windows.Forms.Button btn_chinhsuauser_huy;
        private System.Windows.Forms.Button btn_chinhsuauser_xacnhan;
        private System.Windows.Forms.Panel panel1;
    }
}