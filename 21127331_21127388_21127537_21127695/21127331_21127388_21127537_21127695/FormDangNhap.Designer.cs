namespace _21127331_21127388_21127537_21127695
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.pn_dangnhap = new System.Windows.Forms.Panel();
            this.pb_dangnhap = new System.Windows.Forms.PictureBox();
            this.cb_dangnhap_vaitro = new System.Windows.Forms.ComboBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.tb_dangnhap_matkhau = new System.Windows.Forms.TextBox();
            this.tb_dangnhap_taikhoan = new System.Windows.Forms.TextBox();
            this.lb_dangnhap_vaitro = new System.Windows.Forms.Label();
            this.lb_dangnhap_matkhau = new System.Windows.Forms.Label();
            this.lb_dangnhap_taikhoan = new System.Windows.Forms.Label();
            this.lb_dangnhap = new System.Windows.Forms.Label();
            this.pn_dangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dangnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_dangnhap
            // 
            this.pn_dangnhap.Controls.Add(this.pb_dangnhap);
            this.pn_dangnhap.Controls.Add(this.cb_dangnhap_vaitro);
            this.pn_dangnhap.Controls.Add(this.btn_dangnhap);
            this.pn_dangnhap.Controls.Add(this.tb_dangnhap_matkhau);
            this.pn_dangnhap.Controls.Add(this.tb_dangnhap_taikhoan);
            this.pn_dangnhap.Controls.Add(this.lb_dangnhap_vaitro);
            this.pn_dangnhap.Controls.Add(this.lb_dangnhap_matkhau);
            this.pn_dangnhap.Controls.Add(this.lb_dangnhap_taikhoan);
            this.pn_dangnhap.Controls.Add(this.lb_dangnhap);
            this.pn_dangnhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.pn_dangnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_dangnhap.Location = new System.Drawing.Point(0, 0);
            this.pn_dangnhap.Name = "pn_dangnhap";
            this.pn_dangnhap.Size = new System.Drawing.Size(736, 306);
            this.pn_dangnhap.TabIndex = 0;
            // 
            // pb_dangnhap
            // 
            this.pb_dangnhap.BackColor = System.Drawing.Color.Transparent;
            this.pb_dangnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_dangnhap.Image = global::_21127331_21127388_21127537_21127695.Properties.Resources.DBA_1;
            this.pb_dangnhap.Location = new System.Drawing.Point(21, 65);
            this.pb_dangnhap.Name = "pb_dangnhap";
            this.pb_dangnhap.Size = new System.Drawing.Size(208, 210);
            this.pb_dangnhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_dangnhap.TabIndex = 5;
            this.pb_dangnhap.TabStop = false;
            // 
            // cb_dangnhap_vaitro
            // 
            this.cb_dangnhap_vaitro.FormattingEnabled = true;
            this.cb_dangnhap_vaitro.Items.AddRange(new object[] {
            "SYSDBA",
            "ADMIN",
            "Sinh viên",
            "Nhân viên cơ bản",
            "Giảng viên",
            "Giáo vụ",
            "Trưởng đơn vị",
            "Trưởng khoa"});
            this.cb_dangnhap_vaitro.Location = new System.Drawing.Point(563, 195);
            this.cb_dangnhap_vaitro.Name = "cb_dangnhap_vaitro";
            this.cb_dangnhap_vaitro.Size = new System.Drawing.Size(152, 28);
            this.cb_dangnhap_vaitro.TabIndex = 3;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(486, 243);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(120, 36);
            this.btn_dangnhap.TabIndex = 4;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // tb_dangnhap_matkhau
            // 
            this.tb_dangnhap_matkhau.Location = new System.Drawing.Point(385, 146);
            this.tb_dangnhap_matkhau.Name = "tb_dangnhap_matkhau";
            this.tb_dangnhap_matkhau.Size = new System.Drawing.Size(330, 26);
            this.tb_dangnhap_matkhau.TabIndex = 2;
            this.tb_dangnhap_matkhau.UseSystemPasswordChar = true;
            // 
            // tb_dangnhap_taikhoan
            // 
            this.tb_dangnhap_taikhoan.Location = new System.Drawing.Point(385, 99);
            this.tb_dangnhap_taikhoan.Name = "tb_dangnhap_taikhoan";
            this.tb_dangnhap_taikhoan.Size = new System.Drawing.Size(330, 26);
            this.tb_dangnhap_taikhoan.TabIndex = 1;
            // 
            // lb_dangnhap_vaitro
            // 
            this.lb_dangnhap_vaitro.AutoSize = true;
            this.lb_dangnhap_vaitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dangnhap_vaitro.Location = new System.Drawing.Point(258, 195);
            this.lb_dangnhap_vaitro.Name = "lb_dangnhap_vaitro";
            this.lb_dangnhap_vaitro.Size = new System.Drawing.Size(59, 20);
            this.lb_dangnhap_vaitro.TabIndex = 1;
            this.lb_dangnhap_vaitro.Text = "Vai trò:";
            // 
            // lb_dangnhap_matkhau
            // 
            this.lb_dangnhap_matkhau.AutoSize = true;
            this.lb_dangnhap_matkhau.BackColor = System.Drawing.SystemColors.Control;
            this.lb_dangnhap_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dangnhap_matkhau.Location = new System.Drawing.Point(258, 146);
            this.lb_dangnhap_matkhau.Name = "lb_dangnhap_matkhau";
            this.lb_dangnhap_matkhau.Size = new System.Drawing.Size(79, 20);
            this.lb_dangnhap_matkhau.TabIndex = 1;
            this.lb_dangnhap_matkhau.Text = "Mật khẩu:";
            // 
            // lb_dangnhap_taikhoan
            // 
            this.lb_dangnhap_taikhoan.AutoSize = true;
            this.lb_dangnhap_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dangnhap_taikhoan.Location = new System.Drawing.Point(258, 99);
            this.lb_dangnhap_taikhoan.Name = "lb_dangnhap_taikhoan";
            this.lb_dangnhap_taikhoan.Size = new System.Drawing.Size(120, 20);
            this.lb_dangnhap_taikhoan.TabIndex = 1;
            this.lb_dangnhap_taikhoan.Text = "Tên đăng nhập:";
            // 
            // lb_dangnhap
            // 
            this.lb_dangnhap.AutoSize = true;
            this.lb_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_dangnhap.ForeColor = System.Drawing.Color.Red;
            this.lb_dangnhap.Location = new System.Drawing.Point(153, 13);
            this.lb_dangnhap.Name = "lb_dangnhap";
            this.lb_dangnhap.Size = new System.Drawing.Size(413, 31);
            this.lb_dangnhap.TabIndex = 0;
            this.lb_dangnhap.Text = "ĐĂNG NHẬP VÀO HỆ THỐNG";
            this.lb_dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 306);
            this.Controls.Add(this.pn_dangnhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.pn_dangnhap.ResumeLayout(false);
            this.pn_dangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dangnhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_dangnhap;
        private System.Windows.Forms.Label lb_dangnhap;
        private System.Windows.Forms.Label lb_dangnhap_vaitro;
        private System.Windows.Forms.Label lb_dangnhap_matkhau;
        private System.Windows.Forms.Label lb_dangnhap_taikhoan;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.TextBox tb_dangnhap_matkhau;
        private System.Windows.Forms.TextBox tb_dangnhap_taikhoan;
        private System.Windows.Forms.ComboBox cb_dangnhap_vaitro;
        private System.Windows.Forms.PictureBox pb_dangnhap;
    }
}