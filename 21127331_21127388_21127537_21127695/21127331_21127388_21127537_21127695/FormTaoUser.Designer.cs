namespace _21127331_21127388_21127537_21127695
{
    partial class FormTaoUser
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
            this.lb_taouser_username = new System.Windows.Forms.Label();
            this.lb_taouser_password = new System.Windows.Forms.Label();
            this.tb_taouser_username = new System.Windows.Forms.TextBox();
            this.tb_taouser_password = new System.Windows.Forms.TextBox();
            this.btn_taouser_huy = new System.Windows.Forms.Button();
            this.btn_taouser_xacnhan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_taouser_username
            // 
            this.lb_taouser_username.AutoSize = true;
            this.lb_taouser_username.Location = new System.Drawing.Point(12, 29);
            this.lb_taouser_username.Name = "lb_taouser_username";
            this.lb_taouser_username.Size = new System.Drawing.Size(51, 13);
            this.lb_taouser_username.TabIndex = 0;
            this.lb_taouser_username.Text = "Tên User";
            // 
            // lb_taouser_password
            // 
            this.lb_taouser_password.AutoSize = true;
            this.lb_taouser_password.Location = new System.Drawing.Point(12, 70);
            this.lb_taouser_password.Name = "lb_taouser_password";
            this.lb_taouser_password.Size = new System.Drawing.Size(52, 13);
            this.lb_taouser_password.TabIndex = 1;
            this.lb_taouser_password.Text = "Mật khẩu";
            // 
            // tb_taouser_username
            // 
            this.tb_taouser_username.Location = new System.Drawing.Point(99, 29);
            this.tb_taouser_username.Name = "tb_taouser_username";
            this.tb_taouser_username.Size = new System.Drawing.Size(246, 20);
            this.tb_taouser_username.TabIndex = 2;
            // 
            // tb_taouser_password
            // 
            this.tb_taouser_password.Location = new System.Drawing.Point(99, 70);
            this.tb_taouser_password.Name = "tb_taouser_password";
            this.tb_taouser_password.Size = new System.Drawing.Size(246, 20);
            this.tb_taouser_password.TabIndex = 3;
            this.tb_taouser_password.UseSystemPasswordChar = true;
            // 
            // btn_taouser_huy
            // 
            this.btn_taouser_huy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_taouser_huy.Location = new System.Drawing.Point(99, 109);
            this.btn_taouser_huy.Name = "btn_taouser_huy";
            this.btn_taouser_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_taouser_huy.TabIndex = 4;
            this.btn_taouser_huy.Text = "Hủy";
            this.btn_taouser_huy.UseVisualStyleBackColor = false;
            this.btn_taouser_huy.Click += new System.EventHandler(this.btn_taouser_huy_Click);
            // 
            // btn_taouser_xacnhan
            // 
            this.btn_taouser_xacnhan.Location = new System.Drawing.Point(184, 109);
            this.btn_taouser_xacnhan.Name = "btn_taouser_xacnhan";
            this.btn_taouser_xacnhan.Size = new System.Drawing.Size(75, 23);
            this.btn_taouser_xacnhan.TabIndex = 5;
            this.btn_taouser_xacnhan.Text = "Tạo";
            this.btn_taouser_xacnhan.UseVisualStyleBackColor = true;
            this.btn_taouser_xacnhan.Click += new System.EventHandler(this.btn_taouser_xacnhan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_taouser_username);
            this.panel1.Controls.Add(this.lb_taouser_password);
            this.panel1.Controls.Add(this.btn_taouser_xacnhan);
            this.panel1.Controls.Add(this.lb_taouser_username);
            this.panel1.Controls.Add(this.tb_taouser_password);
            this.panel1.Controls.Add(this.btn_taouser_huy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 158);
            this.panel1.TabIndex = 6;
            // 
            // FormTaoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 158);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FormTaoUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTaoUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_taouser_username;
        private System.Windows.Forms.Label lb_taouser_password;
        private System.Windows.Forms.TextBox tb_taouser_username;
        private System.Windows.Forms.TextBox tb_taouser_password;
        private System.Windows.Forms.Button btn_taouser_huy;
        private System.Windows.Forms.Button btn_taouser_xacnhan;
        private System.Windows.Forms.Panel panel1;
    }
}