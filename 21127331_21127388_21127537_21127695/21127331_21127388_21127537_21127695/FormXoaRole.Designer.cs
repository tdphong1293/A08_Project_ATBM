namespace _21127331_21127388_21127537_21127695
{
    partial class FormXoaRole
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
            this.lb_xoauser_rolename = new System.Windows.Forms.Label();
            this.tb_xoarole_rolename = new System.Windows.Forms.TextBox();
            this.btn_xoarole_huy = new System.Windows.Forms.Button();
            this.btn_xoarole_xacnhan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_xoauser_rolename
            // 
            this.lb_xoauser_rolename.AutoSize = true;
            this.lb_xoauser_rolename.Location = new System.Drawing.Point(12, 44);
            this.lb_xoauser_rolename.Name = "lb_xoauser_rolename";
            this.lb_xoauser_rolename.Size = new System.Drawing.Size(51, 13);
            this.lb_xoauser_rolename.TabIndex = 0;
            this.lb_xoauser_rolename.Text = "Tên Role";
            // 
            // tb_xoarole_rolename
            // 
            this.tb_xoarole_rolename.Location = new System.Drawing.Point(99, 41);
            this.tb_xoarole_rolename.Name = "tb_xoarole_rolename";
            this.tb_xoarole_rolename.Size = new System.Drawing.Size(246, 20);
            this.tb_xoarole_rolename.TabIndex = 2;
            // 
            // btn_xoarole_huy
            // 
            this.btn_xoarole_huy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_xoarole_huy.Location = new System.Drawing.Point(99, 109);
            this.btn_xoarole_huy.Name = "btn_xoarole_huy";
            this.btn_xoarole_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_xoarole_huy.TabIndex = 4;
            this.btn_xoarole_huy.Text = "Hủy";
            this.btn_xoarole_huy.UseVisualStyleBackColor = false;
            this.btn_xoarole_huy.Click += new System.EventHandler(this.btn_xoarole_huy_Click);
            // 
            // btn_xoarole_xacnhan
            // 
            this.btn_xoarole_xacnhan.Location = new System.Drawing.Point(184, 109);
            this.btn_xoarole_xacnhan.Name = "btn_xoarole_xacnhan";
            this.btn_xoarole_xacnhan.Size = new System.Drawing.Size(75, 23);
            this.btn_xoarole_xacnhan.TabIndex = 5;
            this.btn_xoarole_xacnhan.Text = "Xóa";
            this.btn_xoarole_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xoarole_xacnhan.Click += new System.EventHandler(this.btn_xoarole_xacnhan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_xoarole_rolename);
            this.panel1.Controls.Add(this.btn_xoarole_xacnhan);
            this.panel1.Controls.Add(this.lb_xoauser_rolename);
            this.panel1.Controls.Add(this.btn_xoarole_huy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 158);
            this.panel1.TabIndex = 6;
            // 
            // FormXoaRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 158);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FormXoaRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXoaRole";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_xoauser_rolename;
        private System.Windows.Forms.TextBox tb_xoarole_rolename;
        private System.Windows.Forms.Button btn_xoarole_huy;
        private System.Windows.Forms.Button btn_xoarole_xacnhan;
        private System.Windows.Forms.Panel panel1;
    }
}