namespace _21127331_21127388_21127537_21127695
{
    partial class FormTaoRole
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
            this.lb_taorole_rolename = new System.Windows.Forms.Label();
            this.lb_taorole_password = new System.Windows.Forms.Label();
            this.tb_taorole_rolename = new System.Windows.Forms.TextBox();
            this.tb_taorole_password = new System.Windows.Forms.TextBox();
            this.btn_taorole_huy = new System.Windows.Forms.Button();
            this.btn_taorole_xacnhan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_taorole_luuy = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_taorole_rolename
            // 
            this.lb_taorole_rolename.AutoSize = true;
            this.lb_taorole_rolename.Location = new System.Drawing.Point(12, 29);
            this.lb_taorole_rolename.Name = "lb_taorole_rolename";
            this.lb_taorole_rolename.Size = new System.Drawing.Size(51, 13);
            this.lb_taorole_rolename.TabIndex = 0;
            this.lb_taorole_rolename.Text = "Tên Role";
            // 
            // lb_taorole_password
            // 
            this.lb_taorole_password.AutoSize = true;
            this.lb_taorole_password.Location = new System.Drawing.Point(12, 70);
            this.lb_taorole_password.Name = "lb_taorole_password";
            this.lb_taorole_password.Size = new System.Drawing.Size(52, 13);
            this.lb_taorole_password.TabIndex = 1;
            this.lb_taorole_password.Text = "Mật khẩu";
            // 
            // tb_taorole_rolename
            // 
            this.tb_taorole_rolename.Location = new System.Drawing.Point(99, 29);
            this.tb_taorole_rolename.Name = "tb_taorole_rolename";
            this.tb_taorole_rolename.Size = new System.Drawing.Size(246, 20);
            this.tb_taorole_rolename.TabIndex = 2;
            // 
            // tb_taorole_password
            // 
            this.tb_taorole_password.Location = new System.Drawing.Point(99, 70);
            this.tb_taorole_password.Name = "tb_taorole_password";
            this.tb_taorole_password.Size = new System.Drawing.Size(246, 20);
            this.tb_taorole_password.TabIndex = 3;
            this.tb_taorole_password.UseSystemPasswordChar = true;
            // 
            // btn_taorole_huy
            // 
            this.btn_taorole_huy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_taorole_huy.Location = new System.Drawing.Point(99, 123);
            this.btn_taorole_huy.Name = "btn_taorole_huy";
            this.btn_taorole_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_taorole_huy.TabIndex = 4;
            this.btn_taorole_huy.Text = "Hủy";
            this.btn_taorole_huy.UseVisualStyleBackColor = false;
            this.btn_taorole_huy.Click += new System.EventHandler(this.btn_taorole_huy_Click);
            // 
            // btn_taorole_xacnhan
            // 
            this.btn_taorole_xacnhan.Location = new System.Drawing.Point(184, 123);
            this.btn_taorole_xacnhan.Name = "btn_taorole_xacnhan";
            this.btn_taorole_xacnhan.Size = new System.Drawing.Size(75, 23);
            this.btn_taorole_xacnhan.TabIndex = 5;
            this.btn_taorole_xacnhan.Text = "Tạo";
            this.btn_taorole_xacnhan.UseVisualStyleBackColor = true;
            this.btn_taorole_xacnhan.Click += new System.EventHandler(this.btn_taorole_xacnhan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_taorole_luuy);
            this.panel1.Controls.Add(this.tb_taorole_rolename);
            this.panel1.Controls.Add(this.lb_taorole_password);
            this.panel1.Controls.Add(this.btn_taorole_xacnhan);
            this.panel1.Controls.Add(this.lb_taorole_rolename);
            this.panel1.Controls.Add(this.tb_taorole_password);
            this.panel1.Controls.Add(this.btn_taorole_huy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 158);
            this.panel1.TabIndex = 6;
            // 
            // lb_taorole_luuy
            // 
            this.lb_taorole_luuy.AutoSize = true;
            this.lb_taorole_luuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_taorole_luuy.ForeColor = System.Drawing.Color.Red;
            this.lb_taorole_luuy.Location = new System.Drawing.Point(9, 104);
            this.lb_taorole_luuy.Name = "lb_taorole_luuy";
            this.lb_taorole_luuy.Size = new System.Drawing.Size(339, 16);
            this.lb_taorole_luuy.TabIndex = 6;
            this.lb_taorole_luuy.Text = "Lưu ý: Nếu không muốn đặt mật khẩu thì để trống";
            // 
            // FormTaoRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 158);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FormTaoRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTaoRole";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_taorole_rolename;
        private System.Windows.Forms.Label lb_taorole_password;
        private System.Windows.Forms.TextBox tb_taorole_rolename;
        private System.Windows.Forms.TextBox tb_taorole_password;
        private System.Windows.Forms.Button btn_taorole_huy;
        private System.Windows.Forms.Button btn_taorole_xacnhan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_taorole_luuy;
    }
}