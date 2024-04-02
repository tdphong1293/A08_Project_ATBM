namespace _21127331_21127388_21127537_21127695
{
    partial class FormXoaUser
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
            this.lb_xoauser_username = new System.Windows.Forms.Label();
            this.tb_xoauser_username = new System.Windows.Forms.TextBox();
            this.btn_xoauser_huy = new System.Windows.Forms.Button();
            this.btn_xoauser_xacnhan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_xoauser_username
            // 
            this.lb_xoauser_username.AutoSize = true;
            this.lb_xoauser_username.Location = new System.Drawing.Point(12, 44);
            this.lb_xoauser_username.Name = "lb_xoauser_username";
            this.lb_xoauser_username.Size = new System.Drawing.Size(51, 13);
            this.lb_xoauser_username.TabIndex = 0;
            this.lb_xoauser_username.Text = "Tên User";
            // 
            // tb_xoauser_username
            // 
            this.tb_xoauser_username.Location = new System.Drawing.Point(99, 41);
            this.tb_xoauser_username.Name = "tb_xoauser_username";
            this.tb_xoauser_username.Size = new System.Drawing.Size(246, 20);
            this.tb_xoauser_username.TabIndex = 2;
            // 
            // btn_xoauser_huy
            // 
            this.btn_xoauser_huy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_xoauser_huy.Location = new System.Drawing.Point(99, 91);
            this.btn_xoauser_huy.Name = "btn_xoauser_huy";
            this.btn_xoauser_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_xoauser_huy.TabIndex = 4;
            this.btn_xoauser_huy.Text = "Hủy";
            this.btn_xoauser_huy.UseVisualStyleBackColor = false;
            this.btn_xoauser_huy.Click += new System.EventHandler(this.btn_xoauser_huy_Click);
            // 
            // btn_xoauser_xacnhan
            // 
            this.btn_xoauser_xacnhan.Location = new System.Drawing.Point(184, 91);
            this.btn_xoauser_xacnhan.Name = "btn_xoauser_xacnhan";
            this.btn_xoauser_xacnhan.Size = new System.Drawing.Size(75, 23);
            this.btn_xoauser_xacnhan.TabIndex = 5;
            this.btn_xoauser_xacnhan.Text = "Xóa";
            this.btn_xoauser_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xoauser_xacnhan.Click += new System.EventHandler(this.btn_xoauser_xacnhan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_xoauser_username);
            this.panel1.Controls.Add(this.btn_xoauser_xacnhan);
            this.panel1.Controls.Add(this.lb_xoauser_username);
            this.panel1.Controls.Add(this.btn_xoauser_huy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 158);
            this.panel1.TabIndex = 6;
            // 
            // FormXoaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 158);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FormXoaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXoaUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_xoauser_username;
        private System.Windows.Forms.TextBox tb_xoauser_username;
        private System.Windows.Forms.Button btn_xoauser_huy;
        private System.Windows.Forms.Button btn_xoauser_xacnhan;
        private System.Windows.Forms.Panel panel1;
    }
}