namespace _21127331_21127388_21127537_21127695
{
    partial class FormAuditAdmin
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
                searchFGAAUD.Dispose();
                searchSTDAUD.Dispose();
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
            this.tc_audit = new System.Windows.Forms.TabControl();
            this.tp_stdaud = new System.Windows.Forms.TabPage();
            this.btn_audit = new System.Windows.Forms.Button();
            this.gb_stdaud = new System.Windows.Forms.GroupBox();
            this.txt_action_code_stdaud = new System.Windows.Forms.TextBox();
            this.txt_time_stdaud = new System.Windows.Forms.TextBox();
            this.txt_action_name_stdaud = new System.Windows.Forms.TextBox();
            this.txt_object_stdaud = new System.Windows.Forms.TextBox();
            this.txt_owner_stdaud = new System.Windows.Forms.TextBox();
            this.txt_username_stdaud = new System.Windows.Forms.TextBox();
            this.lb_action_code_stdaud = new System.Windows.Forms.Label();
            this.lb_time_stdaud = new System.Windows.Forms.Label();
            this.lb_action_name_stdaud = new System.Windows.Forms.Label();
            this.lb_object_stdaud = new System.Windows.Forms.Label();
            this.lb_owner_stdaud = new System.Windows.Forms.Label();
            this.lb_username_stdaud = new System.Windows.Forms.Label();
            this.status_stdaud = new System.Windows.Forms.StatusStrip();
            this.statuslabel_stdaud = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgv_stdaud = new System.Windows.Forms.DataGridView();
            this.txt_timkiem_stdaud = new System.Windows.Forms.TextBox();
            this.lb_timkiem_stdaud = new System.Windows.Forms.Label();
            this.lb_standardaudit = new System.Windows.Forms.Label();
            this.tp_fgaaud = new System.Windows.Forms.TabPage();
            this.btn_fgaaudit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_statementtype = new System.Windows.Forms.TextBox();
            this.lb_HanhDong = new System.Windows.Forms.Label();
            this.lb_dbuser_fgaaud = new System.Windows.Forms.Label();
            this.txt_policy_fgaaud = new System.Windows.Forms.TextBox();
            this.lb_sqlbind_fgaaud = new System.Windows.Forms.Label();
            this.txt_sqltext_fgaaud = new System.Windows.Forms.TextBox();
            this.txt_sqlbind_fgaaud = new System.Windows.Forms.TextBox();
            this.txt_timestamp_fgaaud = new System.Windows.Forms.TextBox();
            this.lb_objschema_fgaaud = new System.Windows.Forms.Label();
            this.txt_object_fgaaud = new System.Windows.Forms.TextBox();
            this.lb_object_fgaaud = new System.Windows.Forms.Label();
            this.txt_owner_fgaaud = new System.Windows.Forms.TextBox();
            this.lb_timestamp_fgaaud = new System.Windows.Forms.Label();
            this.txt_username_fgaaud = new System.Windows.Forms.TextBox();
            this.lb_sqltext_fgaaud = new System.Windows.Forms.Label();
            this.lb_policy_fgaaud = new System.Windows.Forms.Label();
            this.status_fgaaud = new System.Windows.Forms.StatusStrip();
            this.statuslabel_fgaaud = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgv_fgaaud = new System.Windows.Forms.DataGridView();
            this.txt_timkiem_fgaaud = new System.Windows.Forms.TextBox();
            this.lb_timkiem_fgaaud = new System.Windows.Forms.Label();
            this.lb_fgaaud = new System.Windows.Forms.Label();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.tc_audit.SuspendLayout();
            this.tp_stdaud.SuspendLayout();
            this.gb_stdaud.SuspendLayout();
            this.status_stdaud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_stdaud)).BeginInit();
            this.tp_fgaaud.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.status_fgaaud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_fgaaud)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_audit
            // 
            this.tc_audit.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tc_audit.Controls.Add(this.tp_stdaud);
            this.tc_audit.Controls.Add(this.tp_fgaaud);
            this.tc_audit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tc_audit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_audit.Location = new System.Drawing.Point(0, 24);
            this.tc_audit.Name = "tc_audit";
            this.tc_audit.SelectedIndex = 0;
            this.tc_audit.Size = new System.Drawing.Size(1264, 681);
            this.tc_audit.TabIndex = 13;
            // 
            // tp_stdaud
            // 
            this.tp_stdaud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_stdaud.Controls.Add(this.btn_audit);
            this.tp_stdaud.Controls.Add(this.gb_stdaud);
            this.tp_stdaud.Controls.Add(this.status_stdaud);
            this.tp_stdaud.Controls.Add(this.dtgv_stdaud);
            this.tp_stdaud.Controls.Add(this.txt_timkiem_stdaud);
            this.tp_stdaud.Controls.Add(this.lb_timkiem_stdaud);
            this.tp_stdaud.Controls.Add(this.lb_standardaudit);
            this.tp_stdaud.Location = new System.Drawing.Point(4, 29);
            this.tp_stdaud.Name = "tp_stdaud";
            this.tp_stdaud.Padding = new System.Windows.Forms.Padding(3);
            this.tp_stdaud.Size = new System.Drawing.Size(1256, 648);
            this.tp_stdaud.TabIndex = 0;
            this.tp_stdaud.Text = "Standard Audit";
            this.tp_stdaud.UseVisualStyleBackColor = true;
            // 
            // btn_audit
            // 
            this.btn_audit.BackColor = System.Drawing.Color.Red;
            this.btn_audit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_audit.ForeColor = System.Drawing.Color.White;
            this.btn_audit.Location = new System.Drawing.Point(561, 47);
            this.btn_audit.Name = "btn_audit";
            this.btn_audit.Size = new System.Drawing.Size(156, 31);
            this.btn_audit.TabIndex = 32;
            this.btn_audit.Text = "Đang tắt";
            this.btn_audit.UseVisualStyleBackColor = false;
            this.btn_audit.Click += new System.EventHandler(this.btn_audit_Click);
            // 
            // gb_stdaud
            // 
            this.gb_stdaud.BackColor = System.Drawing.Color.Azure;
            this.gb_stdaud.Controls.Add(this.txt_action_code_stdaud);
            this.gb_stdaud.Controls.Add(this.txt_time_stdaud);
            this.gb_stdaud.Controls.Add(this.txt_action_name_stdaud);
            this.gb_stdaud.Controls.Add(this.txt_object_stdaud);
            this.gb_stdaud.Controls.Add(this.txt_owner_stdaud);
            this.gb_stdaud.Controls.Add(this.txt_username_stdaud);
            this.gb_stdaud.Controls.Add(this.lb_action_code_stdaud);
            this.gb_stdaud.Controls.Add(this.lb_time_stdaud);
            this.gb_stdaud.Controls.Add(this.lb_action_name_stdaud);
            this.gb_stdaud.Controls.Add(this.lb_object_stdaud);
            this.gb_stdaud.Controls.Add(this.lb_owner_stdaud);
            this.gb_stdaud.Controls.Add(this.lb_username_stdaud);
            this.gb_stdaud.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_stdaud.Location = new System.Drawing.Point(723, 83);
            this.gb_stdaud.Name = "gb_stdaud";
            this.gb_stdaud.Size = new System.Drawing.Size(531, 533);
            this.gb_stdaud.TabIndex = 31;
            this.gb_stdaud.TabStop = false;
            this.gb_stdaud.Text = "Nhật ký hoạt động";
            // 
            // txt_action_code_stdaud
            // 
            this.txt_action_code_stdaud.BackColor = System.Drawing.Color.White;
            this.txt_action_code_stdaud.Enabled = false;
            this.txt_action_code_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_action_code_stdaud.Location = new System.Drawing.Point(234, 289);
            this.txt_action_code_stdaud.Name = "txt_action_code_stdaud";
            this.txt_action_code_stdaud.ReadOnly = true;
            this.txt_action_code_stdaud.Size = new System.Drawing.Size(266, 27);
            this.txt_action_code_stdaud.TabIndex = 40;
            this.txt_action_code_stdaud.TabStop = false;
            // 
            // txt_time_stdaud
            // 
            this.txt_time_stdaud.BackColor = System.Drawing.Color.White;
            this.txt_time_stdaud.Enabled = false;
            this.txt_time_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_time_stdaud.Location = new System.Drawing.Point(234, 439);
            this.txt_time_stdaud.Name = "txt_time_stdaud";
            this.txt_time_stdaud.ReadOnly = true;
            this.txt_time_stdaud.Size = new System.Drawing.Size(266, 27);
            this.txt_time_stdaud.TabIndex = 39;
            this.txt_time_stdaud.TabStop = false;
            // 
            // txt_action_name_stdaud
            // 
            this.txt_action_name_stdaud.BackColor = System.Drawing.Color.White;
            this.txt_action_name_stdaud.Enabled = false;
            this.txt_action_name_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_action_name_stdaud.Location = new System.Drawing.Point(234, 364);
            this.txt_action_name_stdaud.Name = "txt_action_name_stdaud";
            this.txt_action_name_stdaud.ReadOnly = true;
            this.txt_action_name_stdaud.Size = new System.Drawing.Size(266, 27);
            this.txt_action_name_stdaud.TabIndex = 38;
            this.txt_action_name_stdaud.TabStop = false;
            // 
            // txt_object_stdaud
            // 
            this.txt_object_stdaud.BackColor = System.Drawing.Color.White;
            this.txt_object_stdaud.Enabled = false;
            this.txt_object_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_object_stdaud.Location = new System.Drawing.Point(234, 214);
            this.txt_object_stdaud.Name = "txt_object_stdaud";
            this.txt_object_stdaud.ReadOnly = true;
            this.txt_object_stdaud.Size = new System.Drawing.Size(266, 27);
            this.txt_object_stdaud.TabIndex = 37;
            this.txt_object_stdaud.TabStop = false;
            // 
            // txt_owner_stdaud
            // 
            this.txt_owner_stdaud.BackColor = System.Drawing.Color.White;
            this.txt_owner_stdaud.Enabled = false;
            this.txt_owner_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_owner_stdaud.Location = new System.Drawing.Point(234, 139);
            this.txt_owner_stdaud.Name = "txt_owner_stdaud";
            this.txt_owner_stdaud.ReadOnly = true;
            this.txt_owner_stdaud.Size = new System.Drawing.Size(266, 27);
            this.txt_owner_stdaud.TabIndex = 36;
            this.txt_owner_stdaud.TabStop = false;
            // 
            // txt_username_stdaud
            // 
            this.txt_username_stdaud.BackColor = System.Drawing.Color.White;
            this.txt_username_stdaud.Enabled = false;
            this.txt_username_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_username_stdaud.Location = new System.Drawing.Point(234, 61);
            this.txt_username_stdaud.Name = "txt_username_stdaud";
            this.txt_username_stdaud.ReadOnly = true;
            this.txt_username_stdaud.Size = new System.Drawing.Size(266, 27);
            this.txt_username_stdaud.TabIndex = 35;
            this.txt_username_stdaud.TabStop = false;
            // 
            // lb_action_code_stdaud
            // 
            this.lb_action_code_stdaud.AutoSize = true;
            this.lb_action_code_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_action_code_stdaud.Location = new System.Drawing.Point(31, 292);
            this.lb_action_code_stdaud.Name = "lb_action_code_stdaud";
            this.lb_action_code_stdaud.Size = new System.Drawing.Size(106, 20);
            this.lb_action_code_stdaud.TabIndex = 34;
            this.lb_action_code_stdaud.Text = "Mã hoạt động:";
            // 
            // lb_time_stdaud
            // 
            this.lb_time_stdaud.AutoSize = true;
            this.lb_time_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_time_stdaud.Location = new System.Drawing.Point(31, 442);
            this.lb_time_stdaud.Name = "lb_time_stdaud";
            this.lb_time_stdaud.Size = new System.Drawing.Size(139, 20);
            this.lb_time_stdaud.TabIndex = 33;
            this.lb_time_stdaud.Text = "Thời gian thực hiện:";
            // 
            // lb_action_name_stdaud
            // 
            this.lb_action_name_stdaud.AutoSize = true;
            this.lb_action_name_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_action_name_stdaud.Location = new System.Drawing.Point(31, 367);
            this.lb_action_name_stdaud.Name = "lb_action_name_stdaud";
            this.lb_action_name_stdaud.Size = new System.Drawing.Size(84, 20);
            this.lb_action_name_stdaud.TabIndex = 32;
            this.lb_action_name_stdaud.Text = "Hoạt động:";
            // 
            // lb_object_stdaud
            // 
            this.lb_object_stdaud.AutoSize = true;
            this.lb_object_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_object_stdaud.Location = new System.Drawing.Point(31, 217);
            this.lb_object_stdaud.Name = "lb_object_stdaud";
            this.lb_object_stdaud.Size = new System.Drawing.Size(80, 20);
            this.lb_object_stdaud.TabIndex = 31;
            this.lb_object_stdaud.Text = "Đối tượng:";
            // 
            // lb_owner_stdaud
            // 
            this.lb_owner_stdaud.AutoSize = true;
            this.lb_owner_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_owner_stdaud.Location = new System.Drawing.Point(31, 142);
            this.lb_owner_stdaud.Name = "lb_owner_stdaud";
            this.lb_owner_stdaud.Size = new System.Drawing.Size(180, 20);
            this.lb_owner_stdaud.TabIndex = 30;
            this.lb_owner_stdaud.Text = "Chủ thể sở hữu đối tượng:";
            // 
            // lb_username_stdaud
            // 
            this.lb_username_stdaud.AutoSize = true;
            this.lb_username_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_username_stdaud.Location = new System.Drawing.Point(31, 64);
            this.lb_username_stdaud.Name = "lb_username_stdaud";
            this.lb_username_stdaud.Size = new System.Drawing.Size(119, 20);
            this.lb_username_stdaud.TabIndex = 29;
            this.lb_username_stdaud.Text = "Người thực hiện:";
            // 
            // status_stdaud
            // 
            this.status_stdaud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel_stdaud});
            this.status_stdaud.Location = new System.Drawing.Point(3, 619);
            this.status_stdaud.Name = "status_stdaud";
            this.status_stdaud.Size = new System.Drawing.Size(1246, 22);
            this.status_stdaud.TabIndex = 30;
            this.status_stdaud.Text = "status_stdaud";
            // 
            // statuslabel_stdaud
            // 
            this.statuslabel_stdaud.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel_stdaud.Name = "statuslabel_stdaud";
            this.statuslabel_stdaud.Size = new System.Drawing.Size(143, 17);
            this.statuslabel_stdaud.Text = "Chưa chọn truy vết nào";
            // 
            // dtgv_stdaud
            // 
            this.dtgv_stdaud.AllowUserToAddRows = false;
            this.dtgv_stdaud.AllowUserToDeleteRows = false;
            this.dtgv_stdaud.AllowUserToOrderColumns = true;
            this.dtgv_stdaud.AllowUserToResizeRows = false;
            this.dtgv_stdaud.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_stdaud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_stdaud.Location = new System.Drawing.Point(6, 83);
            this.dtgv_stdaud.MultiSelect = false;
            this.dtgv_stdaud.Name = "dtgv_stdaud";
            this.dtgv_stdaud.ReadOnly = true;
            this.dtgv_stdaud.RowHeadersVisible = false;
            this.dtgv_stdaud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv_stdaud.Size = new System.Drawing.Size(711, 533);
            this.dtgv_stdaud.TabIndex = 15;
            this.dtgv_stdaud.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_stdaud_CellClick);
            // 
            // txt_timkiem_stdaud
            // 
            this.txt_timkiem_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_timkiem_stdaud.Location = new System.Drawing.Point(188, 47);
            this.txt_timkiem_stdaud.Name = "txt_timkiem_stdaud";
            this.txt_timkiem_stdaud.Size = new System.Drawing.Size(262, 27);
            this.txt_timkiem_stdaud.TabIndex = 14;
            this.txt_timkiem_stdaud.TextChanged += new System.EventHandler(this.txt_timkiem_stdaud_TextChanged);
            // 
            // lb_timkiem_stdaud
            // 
            this.lb_timkiem_stdaud.AutoSize = true;
            this.lb_timkiem_stdaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_timkiem_stdaud.Location = new System.Drawing.Point(6, 50);
            this.lb_timkiem_stdaud.Name = "lb_timkiem_stdaud";
            this.lb_timkiem_stdaud.Size = new System.Drawing.Size(179, 20);
            this.lb_timkiem_stdaud.TabIndex = 13;
            this.lb_timkiem_stdaud.Text = "Tìm kiếm mã người dùng:";
            // 
            // lb_standardaudit
            // 
            this.lb_standardaudit.AutoSize = true;
            this.lb_standardaudit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_standardaudit.Location = new System.Drawing.Point(882, 22);
            this.lb_standardaudit.Name = "lb_standardaudit";
            this.lb_standardaudit.Size = new System.Drawing.Size(197, 30);
            this.lb_standardaudit.TabIndex = 12;
            this.lb_standardaudit.Text = "STANDARD AUDIT";
            // 
            // tp_fgaaud
            // 
            this.tp_fgaaud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_fgaaud.Controls.Add(this.btn_fgaaudit);
            this.tp_fgaaud.Controls.Add(this.groupBox1);
            this.tp_fgaaud.Controls.Add(this.status_fgaaud);
            this.tp_fgaaud.Controls.Add(this.dtgv_fgaaud);
            this.tp_fgaaud.Controls.Add(this.txt_timkiem_fgaaud);
            this.tp_fgaaud.Controls.Add(this.lb_timkiem_fgaaud);
            this.tp_fgaaud.Controls.Add(this.lb_fgaaud);
            this.tp_fgaaud.Location = new System.Drawing.Point(4, 29);
            this.tp_fgaaud.Name = "tp_fgaaud";
            this.tp_fgaaud.Padding = new System.Windows.Forms.Padding(3);
            this.tp_fgaaud.Size = new System.Drawing.Size(1256, 648);
            this.tp_fgaaud.TabIndex = 1;
            this.tp_fgaaud.Text = "Fine-grained Audit";
            this.tp_fgaaud.UseVisualStyleBackColor = true;
            // 
            // btn_fgaaudit
            // 
            this.btn_fgaaudit.BackColor = System.Drawing.Color.Red;
            this.btn_fgaaudit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fgaaudit.ForeColor = System.Drawing.Color.White;
            this.btn_fgaaudit.Location = new System.Drawing.Point(546, 47);
            this.btn_fgaaudit.Name = "btn_fgaaudit";
            this.btn_fgaaudit.Size = new System.Drawing.Size(156, 31);
            this.btn_fgaaudit.TabIndex = 63;
            this.btn_fgaaudit.Text = "Đang tắt";
            this.btn_fgaaudit.UseVisualStyleBackColor = false;
            this.btn_fgaaudit.Click += new System.EventHandler(this.btn_fgaaudit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.tb_statementtype);
            this.groupBox1.Controls.Add(this.lb_HanhDong);
            this.groupBox1.Controls.Add(this.lb_dbuser_fgaaud);
            this.groupBox1.Controls.Add(this.txt_policy_fgaaud);
            this.groupBox1.Controls.Add(this.lb_sqlbind_fgaaud);
            this.groupBox1.Controls.Add(this.txt_sqltext_fgaaud);
            this.groupBox1.Controls.Add(this.txt_sqlbind_fgaaud);
            this.groupBox1.Controls.Add(this.txt_timestamp_fgaaud);
            this.groupBox1.Controls.Add(this.lb_objschema_fgaaud);
            this.groupBox1.Controls.Add(this.txt_object_fgaaud);
            this.groupBox1.Controls.Add(this.lb_object_fgaaud);
            this.groupBox1.Controls.Add(this.txt_owner_fgaaud);
            this.groupBox1.Controls.Add(this.lb_timestamp_fgaaud);
            this.groupBox1.Controls.Add(this.txt_username_fgaaud);
            this.groupBox1.Controls.Add(this.lb_sqltext_fgaaud);
            this.groupBox1.Controls.Add(this.lb_policy_fgaaud);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(708, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 556);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhật ký hoạt động";
            // 
            // tb_statementtype
            // 
            this.tb_statementtype.BackColor = System.Drawing.Color.White;
            this.tb_statementtype.Enabled = false;
            this.tb_statementtype.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_statementtype.Location = new System.Drawing.Point(224, 263);
            this.tb_statementtype.Name = "tb_statementtype";
            this.tb_statementtype.Size = new System.Drawing.Size(291, 27);
            this.tb_statementtype.TabIndex = 63;
            this.tb_statementtype.TabStop = false;
            // 
            // lb_HanhDong
            // 
            this.lb_HanhDong.AutoSize = true;
            this.lb_HanhDong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_HanhDong.Location = new System.Drawing.Point(21, 266);
            this.lb_HanhDong.Name = "lb_HanhDong";
            this.lb_HanhDong.Size = new System.Drawing.Size(84, 20);
            this.lb_HanhDong.TabIndex = 62;
            this.lb_HanhDong.Text = "Hoạt động:";
            // 
            // lb_dbuser_fgaaud
            // 
            this.lb_dbuser_fgaaud.AutoSize = true;
            this.lb_dbuser_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_dbuser_fgaaud.Location = new System.Drawing.Point(21, 39);
            this.lb_dbuser_fgaaud.Name = "lb_dbuser_fgaaud";
            this.lb_dbuser_fgaaud.Size = new System.Drawing.Size(119, 20);
            this.lb_dbuser_fgaaud.TabIndex = 50;
            this.lb_dbuser_fgaaud.Text = "Người thực hiện:";
            // 
            // txt_policy_fgaaud
            // 
            this.txt_policy_fgaaud.BackColor = System.Drawing.Color.White;
            this.txt_policy_fgaaud.Enabled = false;
            this.txt_policy_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_policy_fgaaud.Location = new System.Drawing.Point(224, 206);
            this.txt_policy_fgaaud.Name = "txt_policy_fgaaud";
            this.txt_policy_fgaaud.Size = new System.Drawing.Size(291, 27);
            this.txt_policy_fgaaud.TabIndex = 61;
            this.txt_policy_fgaaud.TabStop = false;
            // 
            // lb_sqlbind_fgaaud
            // 
            this.lb_sqlbind_fgaaud.AutoSize = true;
            this.lb_sqlbind_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_sqlbind_fgaaud.Location = new System.Drawing.Point(21, 465);
            this.lb_sqlbind_fgaaud.Name = "lb_sqlbind_fgaaud";
            this.lb_sqlbind_fgaaud.Size = new System.Drawing.Size(129, 20);
            this.lb_sqlbind_fgaaud.TabIndex = 41;
            this.lb_sqlbind_fgaaud.Text = "Giá trị tham chiếu:";
            // 
            // txt_sqltext_fgaaud
            // 
            this.txt_sqltext_fgaaud.BackColor = System.Drawing.Color.White;
            this.txt_sqltext_fgaaud.Enabled = false;
            this.txt_sqltext_fgaaud.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_sqltext_fgaaud.Location = new System.Drawing.Point(179, 373);
            this.txt_sqltext_fgaaud.Multiline = true;
            this.txt_sqltext_fgaaud.Name = "txt_sqltext_fgaaud";
            this.txt_sqltext_fgaaud.Size = new System.Drawing.Size(336, 78);
            this.txt_sqltext_fgaaud.TabIndex = 60;
            this.txt_sqltext_fgaaud.TabStop = false;
            // 
            // txt_sqlbind_fgaaud
            // 
            this.txt_sqlbind_fgaaud.BackColor = System.Drawing.Color.White;
            this.txt_sqlbind_fgaaud.Enabled = false;
            this.txt_sqlbind_fgaaud.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_sqlbind_fgaaud.Location = new System.Drawing.Point(179, 465);
            this.txt_sqlbind_fgaaud.Multiline = true;
            this.txt_sqlbind_fgaaud.Name = "txt_sqlbind_fgaaud";
            this.txt_sqlbind_fgaaud.Size = new System.Drawing.Size(336, 78);
            this.txt_sqlbind_fgaaud.TabIndex = 48;
            this.txt_sqlbind_fgaaud.TabStop = false;
            // 
            // txt_timestamp_fgaaud
            // 
            this.txt_timestamp_fgaaud.BackColor = System.Drawing.Color.White;
            this.txt_timestamp_fgaaud.Enabled = false;
            this.txt_timestamp_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_timestamp_fgaaud.Location = new System.Drawing.Point(224, 321);
            this.txt_timestamp_fgaaud.Name = "txt_timestamp_fgaaud";
            this.txt_timestamp_fgaaud.Size = new System.Drawing.Size(291, 27);
            this.txt_timestamp_fgaaud.TabIndex = 59;
            this.txt_timestamp_fgaaud.TabStop = false;
            // 
            // lb_objschema_fgaaud
            // 
            this.lb_objschema_fgaaud.AutoSize = true;
            this.lb_objschema_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_objschema_fgaaud.Location = new System.Drawing.Point(21, 96);
            this.lb_objschema_fgaaud.Name = "lb_objschema_fgaaud";
            this.lb_objschema_fgaaud.Size = new System.Drawing.Size(180, 20);
            this.lb_objschema_fgaaud.TabIndex = 51;
            this.lb_objschema_fgaaud.Text = "Chủ thể sở hữu đối tượng:";
            // 
            // txt_object_fgaaud
            // 
            this.txt_object_fgaaud.BackColor = System.Drawing.Color.White;
            this.txt_object_fgaaud.Enabled = false;
            this.txt_object_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_object_fgaaud.Location = new System.Drawing.Point(224, 150);
            this.txt_object_fgaaud.Name = "txt_object_fgaaud";
            this.txt_object_fgaaud.Size = new System.Drawing.Size(291, 27);
            this.txt_object_fgaaud.TabIndex = 58;
            this.txt_object_fgaaud.TabStop = false;
            // 
            // lb_object_fgaaud
            // 
            this.lb_object_fgaaud.AutoSize = true;
            this.lb_object_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_object_fgaaud.Location = new System.Drawing.Point(21, 153);
            this.lb_object_fgaaud.Name = "lb_object_fgaaud";
            this.lb_object_fgaaud.Size = new System.Drawing.Size(80, 20);
            this.lb_object_fgaaud.TabIndex = 52;
            this.lb_object_fgaaud.Text = "Đối tượng:";
            // 
            // txt_owner_fgaaud
            // 
            this.txt_owner_fgaaud.BackColor = System.Drawing.Color.White;
            this.txt_owner_fgaaud.Enabled = false;
            this.txt_owner_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_owner_fgaaud.Location = new System.Drawing.Point(224, 93);
            this.txt_owner_fgaaud.Name = "txt_owner_fgaaud";
            this.txt_owner_fgaaud.Size = new System.Drawing.Size(291, 27);
            this.txt_owner_fgaaud.TabIndex = 57;
            this.txt_owner_fgaaud.TabStop = false;
            // 
            // lb_timestamp_fgaaud
            // 
            this.lb_timestamp_fgaaud.AutoSize = true;
            this.lb_timestamp_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_timestamp_fgaaud.Location = new System.Drawing.Point(21, 324);
            this.lb_timestamp_fgaaud.Name = "lb_timestamp_fgaaud";
            this.lb_timestamp_fgaaud.Size = new System.Drawing.Size(139, 20);
            this.lb_timestamp_fgaaud.TabIndex = 53;
            this.lb_timestamp_fgaaud.Text = "Thời gian thực hiện:";
            // 
            // txt_username_fgaaud
            // 
            this.txt_username_fgaaud.BackColor = System.Drawing.Color.White;
            this.txt_username_fgaaud.Enabled = false;
            this.txt_username_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_username_fgaaud.Location = new System.Drawing.Point(224, 36);
            this.txt_username_fgaaud.Name = "txt_username_fgaaud";
            this.txt_username_fgaaud.Size = new System.Drawing.Size(291, 27);
            this.txt_username_fgaaud.TabIndex = 56;
            this.txt_username_fgaaud.TabStop = false;
            // 
            // lb_sqltext_fgaaud
            // 
            this.lb_sqltext_fgaaud.AutoSize = true;
            this.lb_sqltext_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_sqltext_fgaaud.Location = new System.Drawing.Point(21, 376);
            this.lb_sqltext_fgaaud.Name = "lb_sqltext_fgaaud";
            this.lb_sqltext_fgaaud.Size = new System.Drawing.Size(73, 20);
            this.lb_sqltext_fgaaud.TabIndex = 54;
            this.lb_sqltext_fgaaud.Text = "Lệnh SQL:";
            // 
            // lb_policy_fgaaud
            // 
            this.lb_policy_fgaaud.AutoSize = true;
            this.lb_policy_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_policy_fgaaud.Location = new System.Drawing.Point(21, 209);
            this.lb_policy_fgaaud.Name = "lb_policy_fgaaud";
            this.lb_policy_fgaaud.Size = new System.Drawing.Size(107, 20);
            this.lb_policy_fgaaud.TabIndex = 55;
            this.lb_policy_fgaaud.Text = "Tên chính sách:";
            // 
            // status_fgaaud
            // 
            this.status_fgaaud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel_fgaaud});
            this.status_fgaaud.Location = new System.Drawing.Point(3, 619);
            this.status_fgaaud.Name = "status_fgaaud";
            this.status_fgaaud.Size = new System.Drawing.Size(1246, 22);
            this.status_fgaaud.TabIndex = 49;
            this.status_fgaaud.Text = "status_fgaaud";
            // 
            // statuslabel_fgaaud
            // 
            this.statuslabel_fgaaud.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel_fgaaud.Name = "statuslabel_fgaaud";
            this.statuslabel_fgaaud.Size = new System.Drawing.Size(143, 17);
            this.statuslabel_fgaaud.Text = "Chưa chọn truy vết nào";
            // 
            // dtgv_fgaaud
            // 
            this.dtgv_fgaaud.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_fgaaud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_fgaaud.Location = new System.Drawing.Point(6, 83);
            this.dtgv_fgaaud.Name = "dtgv_fgaaud";
            this.dtgv_fgaaud.Size = new System.Drawing.Size(696, 533);
            this.dtgv_fgaaud.TabIndex = 34;
            this.dtgv_fgaaud.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_fgaaud_CellClick);
            // 
            // txt_timkiem_fgaaud
            // 
            this.txt_timkiem_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_timkiem_fgaaud.Location = new System.Drawing.Point(191, 47);
            this.txt_timkiem_fgaaud.Name = "txt_timkiem_fgaaud";
            this.txt_timkiem_fgaaud.Size = new System.Drawing.Size(172, 27);
            this.txt_timkiem_fgaaud.TabIndex = 33;
            this.txt_timkiem_fgaaud.TextChanged += new System.EventHandler(this.txt_timkiem_fgaaud_TextChanged);
            // 
            // lb_timkiem_fgaaud
            // 
            this.lb_timkiem_fgaaud.AutoSize = true;
            this.lb_timkiem_fgaaud.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_timkiem_fgaaud.Location = new System.Drawing.Point(6, 50);
            this.lb_timkiem_fgaaud.Name = "lb_timkiem_fgaaud";
            this.lb_timkiem_fgaaud.Size = new System.Drawing.Size(179, 20);
            this.lb_timkiem_fgaaud.TabIndex = 32;
            this.lb_timkiem_fgaaud.Text = "Tìm kiếm mã người dùng:";
            // 
            // lb_fgaaud
            // 
            this.lb_fgaaud.AutoSize = true;
            this.lb_fgaaud.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fgaaud.Location = new System.Drawing.Point(866, 13);
            this.lb_fgaaud.Name = "lb_fgaaud";
            this.lb_fgaaud.Size = new System.Drawing.Size(231, 30);
            this.lb_fgaaud.TabIndex = 31;
            this.lb_fgaaud.Text = "FINE-GRAINED AUDIT";
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.Red;
            this.btn_DangXuat.Location = new System.Drawing.Point(1162, 10);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(98, 34);
            this.btn_DangXuat.TabIndex = 63;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // FormAuditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 705);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.tc_audit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAuditAdmin";
            this.Text = "FormAuditAdmin";
            this.tc_audit.ResumeLayout(false);
            this.tp_stdaud.ResumeLayout(false);
            this.tp_stdaud.PerformLayout();
            this.gb_stdaud.ResumeLayout(false);
            this.gb_stdaud.PerformLayout();
            this.status_stdaud.ResumeLayout(false);
            this.status_stdaud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_stdaud)).EndInit();
            this.tp_fgaaud.ResumeLayout(false);
            this.tp_fgaaud.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.status_fgaaud.ResumeLayout(false);
            this.status_fgaaud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_fgaaud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_audit;
        private System.Windows.Forms.TabPage tp_stdaud;
        private System.Windows.Forms.StatusStrip status_stdaud;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel_stdaud;
        private System.Windows.Forms.DataGridView dtgv_stdaud;
        private System.Windows.Forms.TextBox txt_timkiem_stdaud;
        private System.Windows.Forms.Label lb_timkiem_stdaud;
        private System.Windows.Forms.Label lb_standardaudit;
        private System.Windows.Forms.TabPage tp_fgaaud;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.StatusStrip status_fgaaud;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel_fgaaud;
        private System.Windows.Forms.DataGridView dtgv_fgaaud;
        private System.Windows.Forms.TextBox txt_timkiem_fgaaud;
        private System.Windows.Forms.Label lb_timkiem_fgaaud;
        private System.Windows.Forms.Label lb_fgaaud;
        private System.Windows.Forms.GroupBox gb_stdaud;
        private System.Windows.Forms.TextBox txt_action_code_stdaud;
        private System.Windows.Forms.TextBox txt_time_stdaud;
        private System.Windows.Forms.TextBox txt_action_name_stdaud;
        private System.Windows.Forms.TextBox txt_object_stdaud;
        private System.Windows.Forms.TextBox txt_owner_stdaud;
        private System.Windows.Forms.TextBox txt_username_stdaud;
        private System.Windows.Forms.Label lb_action_code_stdaud;
        private System.Windows.Forms.Label lb_time_stdaud;
        private System.Windows.Forms.Label lb_action_name_stdaud;
        private System.Windows.Forms.Label lb_object_stdaud;
        private System.Windows.Forms.Label lb_owner_stdaud;
        private System.Windows.Forms.Label lb_username_stdaud;
        private System.Windows.Forms.TextBox txt_policy_fgaaud;
        private System.Windows.Forms.TextBox txt_sqltext_fgaaud;
        private System.Windows.Forms.TextBox txt_timestamp_fgaaud;
        private System.Windows.Forms.TextBox txt_object_fgaaud;
        private System.Windows.Forms.TextBox txt_owner_fgaaud;
        private System.Windows.Forms.TextBox txt_username_fgaaud;
        private System.Windows.Forms.Label lb_policy_fgaaud;
        private System.Windows.Forms.Label lb_sqltext_fgaaud;
        private System.Windows.Forms.Label lb_timestamp_fgaaud;
        private System.Windows.Forms.Label lb_object_fgaaud;
        private System.Windows.Forms.Label lb_objschema_fgaaud;
        private System.Windows.Forms.Label lb_dbuser_fgaaud;
        private System.Windows.Forms.TextBox txt_sqlbind_fgaaud;
        private System.Windows.Forms.Label lb_sqlbind_fgaaud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_statementtype;
        private System.Windows.Forms.Label lb_HanhDong;
        private System.Windows.Forms.Button btn_audit;
        private System.Windows.Forms.Button btn_fgaaudit;
    }
}