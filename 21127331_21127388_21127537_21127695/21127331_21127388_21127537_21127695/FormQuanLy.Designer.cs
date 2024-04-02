namespace _21127331_21127388_21127537_21127695
{
    partial class FormQuanLy
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
            UserTimer?.Dispose();
            RoleTimer?.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLy));
            this.tp_phan = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_RevokeUserRole = new System.Windows.Forms.Button();
            this.btn_CapQuyenUserRole = new System.Windows.Forms.Button();
            this.tb_grantee = new System.Windows.Forms.TextBox();
            this.lb_TimKiemGrantee = new System.Windows.Forms.Label();
            this.lb_column_privs = new System.Windows.Forms.Label();
            this.lb_table_privs = new System.Windows.Forms.Label();
            this.dtgv_column_privs = new System.Windows.Forms.DataGridView();
            this.dtgv_table_privs = new System.Windows.Forms.DataGridView();
            this.tp_userrole = new System.Windows.Forms.TabPage();
            this.lb_table_role = new System.Windows.Forms.Label();
            this.lb_table_user = new System.Windows.Forms.Label();
            this.btn_taorole = new System.Windows.Forms.Button();
            this.btn_chinhsuarole = new System.Windows.Forms.Button();
            this.btn_taouser = new System.Windows.Forms.Button();
            this.btn_xoarole = new System.Windows.Forms.Button();
            this.btn_chinhsuauser = new System.Windows.Forms.Button();
            this.btn_xoauser = new System.Windows.Forms.Button();
            this.tb_role = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.lb_role = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.dgv_role = new System.Windows.Forms.DataGridView();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.tc_quanly = new System.Windows.Forms.TabControl();
            this.tp_phan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_column_privs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_table_privs)).BeginInit();
            this.tp_userrole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.tc_quanly.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp_phan
            // 
            this.tp_phan.Controls.Add(this.button1);
            this.tp_phan.Controls.Add(this.btn_RevokeUserRole);
            this.tp_phan.Controls.Add(this.btn_CapQuyenUserRole);
            this.tp_phan.Controls.Add(this.tb_grantee);
            this.tp_phan.Controls.Add(this.lb_TimKiemGrantee);
            this.tp_phan.Controls.Add(this.lb_column_privs);
            this.tp_phan.Controls.Add(this.lb_table_privs);
            this.tp_phan.Controls.Add(this.dtgv_column_privs);
            this.tp_phan.Controls.Add(this.dtgv_table_privs);
            this.tp_phan.Location = new System.Drawing.Point(4, 22);
            this.tp_phan.Name = "tp_phan";
            this.tp_phan.Padding = new System.Windows.Forms.Padding(3);
            this.tp_phan.Size = new System.Drawing.Size(1256, 655);
            this.tp_phan.TabIndex = 1;
            this.tp_phan.Text = "Quản lý quyền";
            this.tp_phan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1069, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cấp / Thu hồi ROLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_RevokeUserRole
            // 
            this.btn_RevokeUserRole.Enabled = false;
            this.btn_RevokeUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RevokeUserRole.Location = new System.Drawing.Point(893, 24);
            this.btn_RevokeUserRole.Name = "btn_RevokeUserRole";
            this.btn_RevokeUserRole.Size = new System.Drawing.Size(150, 50);
            this.btn_RevokeUserRole.TabIndex = 8;
            this.btn_RevokeUserRole.Text = "Thu hồi quyền của USER / ROLE";
            this.btn_RevokeUserRole.UseVisualStyleBackColor = true;
            this.btn_RevokeUserRole.Click += new System.EventHandler(this.btn_RevokeUserRole_Click);
            // 
            // btn_CapQuyenUserRole
            // 
            this.btn_CapQuyenUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapQuyenUserRole.Location = new System.Drawing.Point(718, 24);
            this.btn_CapQuyenUserRole.Name = "btn_CapQuyenUserRole";
            this.btn_CapQuyenUserRole.Size = new System.Drawing.Size(150, 50);
            this.btn_CapQuyenUserRole.TabIndex = 7;
            this.btn_CapQuyenUserRole.Text = "Cấp quyền cho USER / ROLE";
            this.btn_CapQuyenUserRole.UseVisualStyleBackColor = true;
            this.btn_CapQuyenUserRole.Click += new System.EventHandler(this.btn_CapQuyenUserRole_Click);
            // 
            // tb_grantee
            // 
            this.tb_grantee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_grantee.Location = new System.Drawing.Point(46, 43);
            this.tb_grantee.Name = "tb_grantee";
            this.tb_grantee.Size = new System.Drawing.Size(145, 22);
            this.tb_grantee.TabIndex = 5;
            this.tb_grantee.TextChanged += new System.EventHandler(this.tb_grantee_TextChanged);
            // 
            // lb_TimKiemGrantee
            // 
            this.lb_TimKiemGrantee.AutoSize = true;
            this.lb_TimKiemGrantee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimKiemGrantee.Location = new System.Drawing.Point(43, 24);
            this.lb_TimKiemGrantee.Name = "lb_TimKiemGrantee";
            this.lb_TimKiemGrantee.Size = new System.Drawing.Size(148, 16);
            this.lb_TimKiemGrantee.TabIndex = 4;
            this.lb_TimKiemGrantee.Text = "Tìm kiếm tên User/Role";
            // 
            // lb_column_privs
            // 
            this.lb_column_privs.AutoSize = true;
            this.lb_column_privs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_column_privs.Location = new System.Drawing.Point(39, 380);
            this.lb_column_privs.Name = "lb_column_privs";
            this.lb_column_privs.Size = new System.Drawing.Size(347, 20);
            this.lb_column_privs.TabIndex = 3;
            this.lb_column_privs.Text = "Danh sách quyền trên cột (Update/Select)";
            // 
            // lb_table_privs
            // 
            this.lb_table_privs.AutoSize = true;
            this.lb_table_privs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_table_privs.Location = new System.Drawing.Point(39, 110);
            this.lb_table_privs.Name = "lb_table_privs";
            this.lb_table_privs.Size = new System.Drawing.Size(349, 20);
            this.lb_table_privs.TabIndex = 2;
            this.lb_table_privs.Text = "Danh sách quyền trên bảng của Role/User";
            // 
            // dtgv_column_privs
            // 
            this.dtgv_column_privs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_column_privs.Location = new System.Drawing.Point(43, 403);
            this.dtgv_column_privs.MultiSelect = false;
            this.dtgv_column_privs.Name = "dtgv_column_privs";
            this.dtgv_column_privs.ReadOnly = true;
            this.dtgv_column_privs.RowHeadersWidth = 62;
            this.dtgv_column_privs.Size = new System.Drawing.Size(1176, 208);
            this.dtgv_column_privs.TabIndex = 1;
            // 
            // dtgv_table_privs
            // 
            this.dtgv_table_privs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_table_privs.Location = new System.Drawing.Point(43, 134);
            this.dtgv_table_privs.MultiSelect = false;
            this.dtgv_table_privs.Name = "dtgv_table_privs";
            this.dtgv_table_privs.ReadOnly = true;
            this.dtgv_table_privs.RowHeadersWidth = 62;
            this.dtgv_table_privs.Size = new System.Drawing.Size(1176, 208);
            this.dtgv_table_privs.TabIndex = 0;
            // 
            // tp_userrole
            // 
            this.tp_userrole.Controls.Add(this.lb_table_role);
            this.tp_userrole.Controls.Add(this.lb_table_user);
            this.tp_userrole.Controls.Add(this.btn_taorole);
            this.tp_userrole.Controls.Add(this.btn_chinhsuarole);
            this.tp_userrole.Controls.Add(this.btn_taouser);
            this.tp_userrole.Controls.Add(this.btn_xoarole);
            this.tp_userrole.Controls.Add(this.btn_chinhsuauser);
            this.tp_userrole.Controls.Add(this.btn_xoauser);
            this.tp_userrole.Controls.Add(this.tb_role);
            this.tp_userrole.Controls.Add(this.tb_user);
            this.tp_userrole.Controls.Add(this.lb_role);
            this.tp_userrole.Controls.Add(this.lb_user);
            this.tp_userrole.Controls.Add(this.dgv_role);
            this.tp_userrole.Controls.Add(this.dgv_user);
            this.tp_userrole.Location = new System.Drawing.Point(4, 22);
            this.tp_userrole.Name = "tp_userrole";
            this.tp_userrole.Padding = new System.Windows.Forms.Padding(3);
            this.tp_userrole.Size = new System.Drawing.Size(1256, 655);
            this.tp_userrole.TabIndex = 0;
            this.tp_userrole.Text = "Quản lý user/role";
            this.tp_userrole.UseVisualStyleBackColor = true;
            // 
            // lb_table_role
            // 
            this.lb_table_role.AutoSize = true;
            this.lb_table_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_table_role.Location = new System.Drawing.Point(858, 352);
            this.lb_table_role.Name = "lb_table_role";
            this.lb_table_role.Size = new System.Drawing.Size(93, 20);
            this.lb_table_role.TabIndex = 6;
            this.lb_table_role.Text = "Bảng Role";
            // 
            // lb_table_user
            // 
            this.lb_table_user.AutoSize = true;
            this.lb_table_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_table_user.Location = new System.Drawing.Point(856, 41);
            this.lb_table_user.Name = "lb_table_user";
            this.lb_table_user.Size = new System.Drawing.Size(94, 20);
            this.lb_table_user.TabIndex = 6;
            this.lb_table_user.Text = "Bảng User";
            // 
            // btn_taorole
            // 
            this.btn_taorole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_taorole.Location = new System.Drawing.Point(998, 377);
            this.btn_taorole.Name = "btn_taorole";
            this.btn_taorole.Size = new System.Drawing.Size(231, 64);
            this.btn_taorole.TabIndex = 5;
            this.btn_taorole.Text = "Tạo Role";
            this.btn_taorole.UseVisualStyleBackColor = true;
            this.btn_taorole.Click += new System.EventHandler(this.btn_taorole_Click);
            // 
            // btn_chinhsuarole
            // 
            this.btn_chinhsuarole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_chinhsuarole.Location = new System.Drawing.Point(998, 583);
            this.btn_chinhsuarole.Name = "btn_chinhsuarole";
            this.btn_chinhsuarole.Size = new System.Drawing.Size(231, 64);
            this.btn_chinhsuarole.TabIndex = 5;
            this.btn_chinhsuarole.Text = "Chỉnh sửa Role";
            this.btn_chinhsuarole.UseVisualStyleBackColor = true;
            this.btn_chinhsuarole.Click += new System.EventHandler(this.btn_chinhsuarole_Click);
            // 
            // btn_taouser
            // 
            this.btn_taouser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_taouser.Location = new System.Drawing.Point(997, 69);
            this.btn_taouser.Name = "btn_taouser";
            this.btn_taouser.Size = new System.Drawing.Size(231, 64);
            this.btn_taouser.TabIndex = 5;
            this.btn_taouser.Text = "Tạo User";
            this.btn_taouser.UseVisualStyleBackColor = true;
            this.btn_taouser.Click += new System.EventHandler(this.btn_taouser_Click);
            // 
            // btn_xoarole
            // 
            this.btn_xoarole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoarole.Location = new System.Drawing.Point(998, 480);
            this.btn_xoarole.Name = "btn_xoarole";
            this.btn_xoarole.Size = new System.Drawing.Size(231, 64);
            this.btn_xoarole.TabIndex = 5;
            this.btn_xoarole.Text = "Xóa Role";
            this.btn_xoarole.UseVisualStyleBackColor = true;
            this.btn_xoarole.Click += new System.EventHandler(this.btn_xoarole_Click);
            // 
            // btn_chinhsuauser
            // 
            this.btn_chinhsuauser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_chinhsuauser.Location = new System.Drawing.Point(997, 275);
            this.btn_chinhsuauser.Name = "btn_chinhsuauser";
            this.btn_chinhsuauser.Size = new System.Drawing.Size(231, 64);
            this.btn_chinhsuauser.TabIndex = 5;
            this.btn_chinhsuauser.Text = "Chỉnh sửa User";
            this.btn_chinhsuauser.UseVisualStyleBackColor = true;
            this.btn_chinhsuauser.Click += new System.EventHandler(this.btn_chinhsuauser_Click);
            // 
            // btn_xoauser
            // 
            this.btn_xoauser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoauser.Location = new System.Drawing.Point(997, 172);
            this.btn_xoauser.Name = "btn_xoauser";
            this.btn_xoauser.Size = new System.Drawing.Size(231, 64);
            this.btn_xoauser.TabIndex = 5;
            this.btn_xoauser.Text = "Xóa User";
            this.btn_xoauser.UseVisualStyleBackColor = true;
            this.btn_xoauser.Click += new System.EventHandler(this.btn_xoauser_Click);
            // 
            // tb_role
            // 
            this.tb_role.Location = new System.Drawing.Point(86, 352);
            this.tb_role.Name = "tb_role";
            this.tb_role.Size = new System.Drawing.Size(198, 20);
            this.tb_role.TabIndex = 4;
            this.tb_role.TextChanged += new System.EventHandler(this.tb_role_TextChanged);
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(85, 43);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(198, 20);
            this.tb_user.TabIndex = 4;
            this.tb_user.TextChanged += new System.EventHandler(this.tb_user_TextChanged);
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Location = new System.Drawing.Point(8, 352);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(69, 13);
            this.lb_role.TabIndex = 3;
            this.lb_role.Text = "Tìm kiếm role";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(7, 43);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(72, 13);
            this.lb_user.TabIndex = 2;
            this.lb_user.Text = "Tìm kiếm user";
            // 
            // dgv_role
            // 
            this.dgv_role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_role.Location = new System.Drawing.Point(8, 377);
            this.dgv_role.Name = "dgv_role";
            this.dgv_role.ReadOnly = true;
            this.dgv_role.RowHeadersWidth = 62;
            this.dgv_role.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_role.Size = new System.Drawing.Size(942, 270);
            this.dgv_role.TabIndex = 1;
            // 
            // dgv_user
            // 
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(7, 69);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersWidth = 62;
            this.dgv_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_user.Size = new System.Drawing.Size(942, 270);
            this.dgv_user.TabIndex = 0;
            // 
            // tc_quanly
            // 
            this.tc_quanly.Controls.Add(this.tp_userrole);
            this.tc_quanly.Controls.Add(this.tp_phan);
            this.tc_quanly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_quanly.Location = new System.Drawing.Point(0, 0);
            this.tc_quanly.Name = "tc_quanly";
            this.tc_quanly.SelectedIndex = 0;
            this.tc_quanly.Size = new System.Drawing.Size(1264, 681);
            this.tc_quanly.TabIndex = 0;
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tc_quanly);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLy";
            this.tp_phan.ResumeLayout(false);
            this.tp_phan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_column_privs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_table_privs)).EndInit();
            this.tp_userrole.ResumeLayout(false);
            this.tp_userrole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.tc_quanly.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tp_phan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_RevokeUserRole;
        private System.Windows.Forms.Button btn_CapQuyenUserRole;
        private System.Windows.Forms.TextBox tb_grantee;
        private System.Windows.Forms.Label lb_TimKiemGrantee;
        private System.Windows.Forms.Label lb_column_privs;
        private System.Windows.Forms.Label lb_table_privs;
        private System.Windows.Forms.DataGridView dtgv_column_privs;
        private System.Windows.Forms.DataGridView dtgv_table_privs;
        private System.Windows.Forms.TabPage tp_userrole;
        private System.Windows.Forms.Label lb_table_role;
        private System.Windows.Forms.Label lb_table_user;
        private System.Windows.Forms.Button btn_taorole;
        private System.Windows.Forms.Button btn_chinhsuarole;
        private System.Windows.Forms.Button btn_taouser;
        private System.Windows.Forms.Button btn_xoarole;
        private System.Windows.Forms.Button btn_chinhsuauser;
        private System.Windows.Forms.Button btn_xoauser;
        private System.Windows.Forms.TextBox tb_role;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.DataGridView dgv_role;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.TabControl tc_quanly;
    }
}