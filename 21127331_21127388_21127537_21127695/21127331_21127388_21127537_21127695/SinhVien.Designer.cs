using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21127331_21127388_21127537_21127695
{
    partial class SinhVien
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thongbao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pn_thongbao = new System.Windows.Forms.Panel();
            this.dtgv_thongbao = new System.Windows.Forms.DataGridView();
            this.txt_diemtk = new System.Windows.Forms.TextBox();
            this.txt_diemck = new System.Windows.Forms.TextBox();
            this.txt_diemqt = new System.Windows.Forms.TextBox();
            this.txt_diemth = new System.Windows.Forms.TextBox();
            this.DIEMTK = new System.Windows.Forms.Label();
            this.DIEMCK = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kq_hki = new System.Windows.Forms.ComboBox();
            this.kq_hp = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_stth_hp = new System.Windows.Forms.TextBox();
            this.txt_stlt_hp = new System.Windows.Forms.TextBox();
            this.txt_sotc_hp = new System.Windows.Forms.TextBox();
            this.txt_madv_hp = new System.Windows.Forms.TextBox();
            this.txt_tenhp = new System.Windows.Forms.TextBox();
            this.txt_svtd_hp = new System.Windows.Forms.TextBox();
            this.txt_mahp = new System.Windows.Forms.TextBox();
            this.lb_madv_hp = new System.Windows.Forms.Label();
            this.lb_svtd_hp = new System.Windows.Forms.Label();
            this.lb_stth_hp = new System.Windows.Forms.Label();
            this.lb_stlt_hp = new System.Windows.Forms.Label();
            this.lb_sotc_hp = new System.Windows.Forms.Label();
            this.lb_tenhp = new System.Windows.Forms.Label();
            this.lb_mahp = new System.Windows.Forms.Label();
            this.dtghp = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.text_hp = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_khmo_nam = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_khmo_hki = new System.Windows.Forms.ComboBox();
            this.text_khmo_mahp = new System.Windows.Forms.TextBox();
            this.txt_khmo_mact = new System.Windows.Forms.TextBox();
            this.txt_khmo_nam = new System.Windows.Forms.TextBox();
            this.txt_khmo_hki = new System.Windows.Forms.TextBox();
            this.txt_khmo_mahp = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.dtgkhmo = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_pc_magv = new System.Windows.Forms.TextBox();
            this.txt_pc_mact = new System.Windows.Forms.TextBox();
            this.txt_pc_nam = new System.Windows.Forms.TextBox();
            this.txt_pc_hki = new System.Windows.Forms.TextBox();
            this.txt_pc_mahp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_dk_mahp = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.dtgmo = new System.Windows.Forms.DataGridView();
            this.dtgdk = new System.Windows.Forms.DataGridView();
            this.thongbaotimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pn_thongbao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongbao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kq_hp)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtghp)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgkhmo)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btn_thongbao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 40);
            this.panel1.TabIndex = 5;
            // 
            // btn_thongbao
            // 
            this.btn_thongbao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_thongbao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongbao.Image = global::_21127331_21127388_21127537_21127695.Properties.Resources.small_mail_envelope;
            this.btn_thongbao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thongbao.Location = new System.Drawing.Point(889, 7);
            this.btn_thongbao.Name = "btn_thongbao";
            this.btn_thongbao.Size = new System.Drawing.Size(133, 28);
            this.btn_thongbao.TabIndex = 61;
            this.btn_thongbao.Text = "Thông báo";
            this.btn_thongbao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongbao.UseVisualStyleBackColor = true;
            this.btn_thongbao.Click += new System.EventHandler(this.btn_thongbao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hoang Tran Thong";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1027, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(1, 43);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1109, 526);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pn_thongbao);
            this.tabPage1.Controls.Add(this.txt_diemtk);
            this.tabPage1.Controls.Add(this.txt_diemck);
            this.tabPage1.Controls.Add(this.txt_diemqt);
            this.tabPage1.Controls.Add(this.txt_diemth);
            this.tabPage1.Controls.Add(this.DIEMTK);
            this.tabPage1.Controls.Add(this.DIEMCK);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.kq_hki);
            this.tabPage1.Controls.Add(this.kq_hp);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1101, 500);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "KẾT QUẢ HỌC PHẦN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pn_thongbao
            // 
            this.pn_thongbao.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pn_thongbao.Controls.Add(this.dtgv_thongbao);
            this.pn_thongbao.Location = new System.Drawing.Point(688, 3);
            this.pn_thongbao.Name = "pn_thongbao";
            this.pn_thongbao.Size = new System.Drawing.Size(409, 350);
            this.pn_thongbao.TabIndex = 73;
            // 
            // dtgv_thongbao
            // 
            this.dtgv_thongbao.AllowUserToAddRows = false;
            this.dtgv_thongbao.AllowUserToDeleteRows = false;
            this.dtgv_thongbao.AllowUserToOrderColumns = true;
            this.dtgv_thongbao.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dtgv_thongbao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_thongbao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_thongbao.ColumnHeadersVisible = false;
            this.dtgv_thongbao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_thongbao.Location = new System.Drawing.Point(0, 0);
            this.dtgv_thongbao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgv_thongbao.MultiSelect = false;
            this.dtgv_thongbao.Name = "dtgv_thongbao";
            this.dtgv_thongbao.ReadOnly = true;
            this.dtgv_thongbao.RowHeadersVisible = false;
            this.dtgv_thongbao.RowHeadersWidth = 62;
            this.dtgv_thongbao.RowTemplate.Height = 28;
            this.dtgv_thongbao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv_thongbao.Size = new System.Drawing.Size(409, 350);
            this.dtgv_thongbao.TabIndex = 0;
            // 
            // txt_diemtk
            // 
            this.txt_diemtk.Enabled = false;
            this.txt_diemtk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diemtk.Location = new System.Drawing.Point(867, 314);
            this.txt_diemtk.Name = "txt_diemtk";
            this.txt_diemtk.ReadOnly = true;
            this.txt_diemtk.Size = new System.Drawing.Size(74, 27);
            this.txt_diemtk.TabIndex = 72;
            this.txt_diemtk.TabStop = false;
            // 
            // txt_diemck
            // 
            this.txt_diemck.Enabled = false;
            this.txt_diemck.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diemck.Location = new System.Drawing.Point(867, 248);
            this.txt_diemck.Name = "txt_diemck";
            this.txt_diemck.ReadOnly = true;
            this.txt_diemck.Size = new System.Drawing.Size(74, 27);
            this.txt_diemck.TabIndex = 71;
            this.txt_diemck.TabStop = false;
            // 
            // txt_diemqt
            // 
            this.txt_diemqt.Enabled = false;
            this.txt_diemqt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diemqt.Location = new System.Drawing.Point(867, 187);
            this.txt_diemqt.Name = "txt_diemqt";
            this.txt_diemqt.ReadOnly = true;
            this.txt_diemqt.Size = new System.Drawing.Size(74, 27);
            this.txt_diemqt.TabIndex = 70;
            this.txt_diemqt.TabStop = false;
            // 
            // txt_diemth
            // 
            this.txt_diemth.Enabled = false;
            this.txt_diemth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diemth.Location = new System.Drawing.Point(867, 123);
            this.txt_diemth.Name = "txt_diemth";
            this.txt_diemth.ReadOnly = true;
            this.txt_diemth.Size = new System.Drawing.Size(74, 27);
            this.txt_diemth.TabIndex = 69;
            this.txt_diemth.TabStop = false;
            // 
            // DIEMTK
            // 
            this.DIEMTK.AutoSize = true;
            this.DIEMTK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIEMTK.Location = new System.Drawing.Point(799, 314);
            this.DIEMTK.Name = "DIEMTK";
            this.DIEMTK.Size = new System.Drawing.Size(62, 20);
            this.DIEMTK.TabIndex = 68;
            this.DIEMTK.Text = "DIEMTK";
            // 
            // DIEMCK
            // 
            this.DIEMCK.AutoSize = true;
            this.DIEMCK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIEMCK.Location = new System.Drawing.Point(797, 248);
            this.DIEMCK.Name = "DIEMCK";
            this.DIEMCK.Size = new System.Drawing.Size(63, 20);
            this.DIEMCK.TabIndex = 67;
            this.DIEMCK.Text = "DIEMCK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(797, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "DIEMQT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(797, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "DIEMTH";
            // 
            // kq_hki
            // 
            this.kq_hki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kq_hki.FormattingEnabled = true;
            this.kq_hki.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.kq_hki.Location = new System.Drawing.Point(43, 4);
            this.kq_hki.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.kq_hki.Name = "kq_hki";
            this.kq_hki.Size = new System.Drawing.Size(111, 21);
            this.kq_hki.TabIndex = 13;
            this.kq_hki.TextChanged += new System.EventHandler(this.kq_hki_TextChanged);
            // 
            // kq_hp
            // 
            this.kq_hp.AllowUserToDeleteRows = false;
            this.kq_hp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kq_hp.Location = new System.Drawing.Point(0, 29);
            this.kq_hp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.kq_hp.Name = "kq_hp";
            this.kq_hp.RowHeadersWidth = 62;
            this.kq_hp.Size = new System.Drawing.Size(709, 424);
            this.kq_hp.TabIndex = 12;
            this.kq_hp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kq_hp_CellClick);
            this.kq_hp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kq_hp_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Học kì";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_stth_hp);
            this.tabPage3.Controls.Add(this.txt_stlt_hp);
            this.tabPage3.Controls.Add(this.txt_sotc_hp);
            this.tabPage3.Controls.Add(this.txt_madv_hp);
            this.tabPage3.Controls.Add(this.txt_tenhp);
            this.tabPage3.Controls.Add(this.txt_svtd_hp);
            this.tabPage3.Controls.Add(this.txt_mahp);
            this.tabPage3.Controls.Add(this.lb_madv_hp);
            this.tabPage3.Controls.Add(this.lb_svtd_hp);
            this.tabPage3.Controls.Add(this.lb_stth_hp);
            this.tabPage3.Controls.Add(this.lb_stlt_hp);
            this.tabPage3.Controls.Add(this.lb_sotc_hp);
            this.tabPage3.Controls.Add(this.lb_tenhp);
            this.tabPage3.Controls.Add(this.lb_mahp);
            this.tabPage3.Controls.Add(this.dtghp);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.text_hp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1101, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HỌC PHẦN";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_stth_hp
            // 
            this.txt_stth_hp.Enabled = false;
            this.txt_stth_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stth_hp.Location = new System.Drawing.Point(776, 344);
            this.txt_stth_hp.Name = "txt_stth_hp";
            this.txt_stth_hp.ReadOnly = true;
            this.txt_stth_hp.Size = new System.Drawing.Size(309, 27);
            this.txt_stth_hp.TabIndex = 65;
            this.txt_stth_hp.TabStop = false;
            // 
            // txt_stlt_hp
            // 
            this.txt_stlt_hp.Enabled = false;
            this.txt_stlt_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stlt_hp.Location = new System.Drawing.Point(776, 268);
            this.txt_stlt_hp.Name = "txt_stlt_hp";
            this.txt_stlt_hp.ReadOnly = true;
            this.txt_stlt_hp.Size = new System.Drawing.Size(309, 27);
            this.txt_stlt_hp.TabIndex = 64;
            this.txt_stlt_hp.TabStop = false;
            // 
            // txt_sotc_hp
            // 
            this.txt_sotc_hp.Enabled = false;
            this.txt_sotc_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotc_hp.Location = new System.Drawing.Point(776, 194);
            this.txt_sotc_hp.Name = "txt_sotc_hp";
            this.txt_sotc_hp.ReadOnly = true;
            this.txt_sotc_hp.Size = new System.Drawing.Size(309, 27);
            this.txt_sotc_hp.TabIndex = 63;
            this.txt_sotc_hp.TabStop = false;
            // 
            // txt_madv_hp
            // 
            this.txt_madv_hp.Enabled = false;
            this.txt_madv_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_madv_hp.Location = new System.Drawing.Point(776, 480);
            this.txt_madv_hp.Name = "txt_madv_hp";
            this.txt_madv_hp.ReadOnly = true;
            this.txt_madv_hp.Size = new System.Drawing.Size(309, 27);
            this.txt_madv_hp.TabIndex = 62;
            this.txt_madv_hp.TabStop = false;
            // 
            // txt_tenhp
            // 
            this.txt_tenhp.Enabled = false;
            this.txt_tenhp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenhp.Location = new System.Drawing.Point(776, 119);
            this.txt_tenhp.Name = "txt_tenhp";
            this.txt_tenhp.ReadOnly = true;
            this.txt_tenhp.Size = new System.Drawing.Size(309, 27);
            this.txt_tenhp.TabIndex = 61;
            this.txt_tenhp.TabStop = false;
            // 
            // txt_svtd_hp
            // 
            this.txt_svtd_hp.Enabled = false;
            this.txt_svtd_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_svtd_hp.Location = new System.Drawing.Point(776, 419);
            this.txt_svtd_hp.Name = "txt_svtd_hp";
            this.txt_svtd_hp.ReadOnly = true;
            this.txt_svtd_hp.Size = new System.Drawing.Size(309, 27);
            this.txt_svtd_hp.TabIndex = 60;
            this.txt_svtd_hp.TabStop = false;
            // 
            // txt_mahp
            // 
            this.txt_mahp.Enabled = false;
            this.txt_mahp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahp.Location = new System.Drawing.Point(776, 44);
            this.txt_mahp.Name = "txt_mahp";
            this.txt_mahp.ReadOnly = true;
            this.txt_mahp.Size = new System.Drawing.Size(309, 27);
            this.txt_mahp.TabIndex = 59;
            this.txt_mahp.TabStop = false;
            // 
            // lb_madv_hp
            // 
            this.lb_madv_hp.AutoSize = true;
            this.lb_madv_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_madv_hp.Location = new System.Drawing.Point(596, 480);
            this.lb_madv_hp.Name = "lb_madv_hp";
            this.lb_madv_hp.Size = new System.Drawing.Size(75, 20);
            this.lb_madv_hp.TabIndex = 58;
            this.lb_madv_hp.Text = "Mã đơn vị";
            // 
            // lb_svtd_hp
            // 
            this.lb_svtd_hp.AutoSize = true;
            this.lb_svtd_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_svtd_hp.Location = new System.Drawing.Point(596, 419);
            this.lb_svtd_hp.Name = "lb_svtd_hp";
            this.lb_svtd_hp.Size = new System.Drawing.Size(130, 20);
            this.lb_svtd_hp.TabIndex = 57;
            this.lb_svtd_hp.Text = "Số sinh viên tối đa";
            // 
            // lb_stth_hp
            // 
            this.lb_stth_hp.AutoSize = true;
            this.lb_stth_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stth_hp.Location = new System.Drawing.Point(596, 344);
            this.lb_stth_hp.Name = "lb_stth_hp";
            this.lb_stth_hp.Size = new System.Drawing.Size(121, 20);
            this.lb_stth_hp.TabIndex = 56;
            this.lb_stth_hp.Text = "Số tiết thực hành";
            // 
            // lb_stlt_hp
            // 
            this.lb_stlt_hp.AutoSize = true;
            this.lb_stlt_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stlt_hp.Location = new System.Drawing.Point(596, 268);
            this.lb_stlt_hp.Name = "lb_stlt_hp";
            this.lb_stlt_hp.Size = new System.Drawing.Size(112, 20);
            this.lb_stlt_hp.TabIndex = 55;
            this.lb_stlt_hp.Text = "Số tiết lý thuyết";
            // 
            // lb_sotc_hp
            // 
            this.lb_sotc_hp.AutoSize = true;
            this.lb_sotc_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sotc_hp.Location = new System.Drawing.Point(596, 194);
            this.lb_sotc_hp.Name = "lb_sotc_hp";
            this.lb_sotc_hp.Size = new System.Drawing.Size(70, 20);
            this.lb_sotc_hp.TabIndex = 54;
            this.lb_sotc_hp.Text = "Số tín chỉ";
            // 
            // lb_tenhp
            // 
            this.lb_tenhp.AutoSize = true;
            this.lb_tenhp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenhp.Location = new System.Drawing.Point(596, 119);
            this.lb_tenhp.Name = "lb_tenhp";
            this.lb_tenhp.Size = new System.Drawing.Size(97, 20);
            this.lb_tenhp.TabIndex = 53;
            this.lb_tenhp.Text = "Tên học phần";
            // 
            // lb_mahp
            // 
            this.lb_mahp.AutoSize = true;
            this.lb_mahp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahp.Location = new System.Drawing.Point(596, 44);
            this.lb_mahp.Name = "lb_mahp";
            this.lb_mahp.Size = new System.Drawing.Size(95, 20);
            this.lb_mahp.TabIndex = 52;
            this.lb_mahp.Text = "Mã học phần";
            // 
            // dtghp
            // 
            this.dtghp.AllowUserToDeleteRows = false;
            this.dtghp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtghp.Location = new System.Drawing.Point(0, 30);
            this.dtghp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtghp.Name = "dtghp";
            this.dtghp.RowHeadersWidth = 62;
            this.dtghp.Size = new System.Drawing.Size(580, 486);
            this.dtghp.TabIndex = 9;
            this.dtghp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtghp_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Học phần";
            // 
            // text_hp
            // 
            this.text_hp.Location = new System.Drawing.Point(60, 6);
            this.text_hp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.text_hp.Name = "text_hp";
            this.text_hp.Size = new System.Drawing.Size(91, 20);
            this.text_hp.TabIndex = 7;
            this.text_hp.TextChanged += new System.EventHandler(this.text_hp_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.text_khmo_nam);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.text_khmo_hki);
            this.tabPage4.Controls.Add(this.text_khmo_mahp);
            this.tabPage4.Controls.Add(this.txt_khmo_mact);
            this.tabPage4.Controls.Add(this.txt_khmo_nam);
            this.tabPage4.Controls.Add(this.txt_khmo_hki);
            this.tabPage4.Controls.Add(this.txt_khmo_mahp);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.dtgkhmo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1101, 500);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "KẾ HOẠCH MỞ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Mã HP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Năm học";
            // 
            // text_khmo_nam
            // 
            this.text_khmo_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_khmo_nam.FormattingEnabled = true;
            this.text_khmo_nam.Items.AddRange(new object[] {
            "2024"});
            this.text_khmo_nam.Location = new System.Drawing.Point(408, 27);
            this.text_khmo_nam.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.text_khmo_nam.Name = "text_khmo_nam";
            this.text_khmo_nam.Size = new System.Drawing.Size(111, 21);
            this.text_khmo_nam.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Học kì";
            // 
            // text_khmo_hki
            // 
            this.text_khmo_hki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_khmo_hki.FormattingEnabled = true;
            this.text_khmo_hki.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.text_khmo_hki.Location = new System.Drawing.Point(219, 27);
            this.text_khmo_hki.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.text_khmo_hki.Name = "text_khmo_hki";
            this.text_khmo_hki.Size = new System.Drawing.Size(111, 21);
            this.text_khmo_hki.TabIndex = 53;
            this.text_khmo_hki.TextChanged += new System.EventHandler(this.text_khmo_hki_TextChanged);
            // 
            // text_khmo_mahp
            // 
            this.text_khmo_mahp.Location = new System.Drawing.Point(63, 27);
            this.text_khmo_mahp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.text_khmo_mahp.Name = "text_khmo_mahp";
            this.text_khmo_mahp.Size = new System.Drawing.Size(91, 20);
            this.text_khmo_mahp.TabIndex = 52;
            this.text_khmo_mahp.TextChanged += new System.EventHandler(this.text_khmo_mahp_TextChanged);
            // 
            // txt_khmo_mact
            // 
            this.txt_khmo_mact.Enabled = false;
            this.txt_khmo_mact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khmo_mact.Location = new System.Drawing.Point(784, 369);
            this.txt_khmo_mact.Name = "txt_khmo_mact";
            this.txt_khmo_mact.ReadOnly = true;
            this.txt_khmo_mact.Size = new System.Drawing.Size(309, 27);
            this.txt_khmo_mact.TabIndex = 51;
            this.txt_khmo_mact.TabStop = false;
            // 
            // txt_khmo_nam
            // 
            this.txt_khmo_nam.Enabled = false;
            this.txt_khmo_nam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khmo_nam.Location = new System.Drawing.Point(784, 294);
            this.txt_khmo_nam.Name = "txt_khmo_nam";
            this.txt_khmo_nam.ReadOnly = true;
            this.txt_khmo_nam.Size = new System.Drawing.Size(309, 27);
            this.txt_khmo_nam.TabIndex = 50;
            this.txt_khmo_nam.TabStop = false;
            // 
            // txt_khmo_hki
            // 
            this.txt_khmo_hki.Enabled = false;
            this.txt_khmo_hki.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khmo_hki.Location = new System.Drawing.Point(784, 219);
            this.txt_khmo_hki.Name = "txt_khmo_hki";
            this.txt_khmo_hki.ReadOnly = true;
            this.txt_khmo_hki.Size = new System.Drawing.Size(309, 27);
            this.txt_khmo_hki.TabIndex = 49;
            this.txt_khmo_hki.TabStop = false;
            // 
            // txt_khmo_mahp
            // 
            this.txt_khmo_mahp.Enabled = false;
            this.txt_khmo_mahp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khmo_mahp.Location = new System.Drawing.Point(784, 144);
            this.txt_khmo_mahp.Name = "txt_khmo_mahp";
            this.txt_khmo_mahp.ReadOnly = true;
            this.txt_khmo_mahp.Size = new System.Drawing.Size(309, 27);
            this.txt_khmo_mahp.TabIndex = 48;
            this.txt_khmo_mahp.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(604, 369);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(118, 20);
            this.label25.TabIndex = 47;
            this.label25.Text = "Mã chương trình";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(604, 294);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 20);
            this.label26.TabIndex = 46;
            this.label26.Text = "Năm";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(604, 219);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(51, 20);
            this.label27.TabIndex = 45;
            this.label27.Text = "Học kì";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(604, 144);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(95, 20);
            this.label28.TabIndex = 44;
            this.label28.Text = "Mã học phần";
            // 
            // dtgkhmo
            // 
            this.dtgkhmo.AllowUserToDeleteRows = false;
            this.dtgkhmo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgkhmo.Location = new System.Drawing.Point(-3, 61);
            this.dtgkhmo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgkhmo.Name = "dtgkhmo";
            this.dtgkhmo.RowHeadersWidth = 62;
            this.dtgkhmo.Size = new System.Drawing.Size(592, 392);
            this.dtgkhmo.TabIndex = 16;
            this.dtgkhmo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgkhmo_CellClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.txt_pc_magv);
            this.tabPage6.Controls.Add(this.txt_pc_mact);
            this.tabPage6.Controls.Add(this.txt_pc_nam);
            this.tabPage6.Controls.Add(this.txt_pc_hki);
            this.tabPage6.Controls.Add(this.txt_pc_mahp);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.text_dk_mahp);
            this.tabPage6.Controls.Add(this.button13);
            this.tabPage6.Controls.Add(this.button12);
            this.tabPage6.Controls.Add(this.dtgmo);
            this.tabPage6.Controls.Add(this.dtgdk);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1101, 500);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "ĐĂNG KÝ";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 191);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 68;
            this.label16.Text = "Học phần mở";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 61);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 13);
            this.label15.TabIndex = 68;
            this.label15.Text = "Học phần đã đăng ký";
            // 
            // txt_pc_magv
            // 
            this.txt_pc_magv.Enabled = false;
            this.txt_pc_magv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pc_magv.Location = new System.Drawing.Point(833, 339);
            this.txt_pc_magv.Name = "txt_pc_magv";
            this.txt_pc_magv.ReadOnly = true;
            this.txt_pc_magv.Size = new System.Drawing.Size(176, 27);
            this.txt_pc_magv.TabIndex = 67;
            this.txt_pc_magv.TabStop = false;
            this.txt_pc_magv.Visible = false;
            // 
            // txt_pc_mact
            // 
            this.txt_pc_mact.Enabled = false;
            this.txt_pc_mact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pc_mact.Location = new System.Drawing.Point(821, 284);
            this.txt_pc_mact.Name = "txt_pc_mact";
            this.txt_pc_mact.ReadOnly = true;
            this.txt_pc_mact.Size = new System.Drawing.Size(176, 27);
            this.txt_pc_mact.TabIndex = 67;
            this.txt_pc_mact.TabStop = false;
            // 
            // txt_pc_nam
            // 
            this.txt_pc_nam.Enabled = false;
            this.txt_pc_nam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pc_nam.Location = new System.Drawing.Point(821, 209);
            this.txt_pc_nam.Name = "txt_pc_nam";
            this.txt_pc_nam.ReadOnly = true;
            this.txt_pc_nam.Size = new System.Drawing.Size(176, 27);
            this.txt_pc_nam.TabIndex = 66;
            this.txt_pc_nam.TabStop = false;
            // 
            // txt_pc_hki
            // 
            this.txt_pc_hki.Enabled = false;
            this.txt_pc_hki.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pc_hki.Location = new System.Drawing.Point(821, 133);
            this.txt_pc_hki.Name = "txt_pc_hki";
            this.txt_pc_hki.ReadOnly = true;
            this.txt_pc_hki.Size = new System.Drawing.Size(176, 27);
            this.txt_pc_hki.TabIndex = 65;
            this.txt_pc_hki.TabStop = false;
            // 
            // txt_pc_mahp
            // 
            this.txt_pc_mahp.Enabled = false;
            this.txt_pc_mahp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pc_mahp.Location = new System.Drawing.Point(821, 61);
            this.txt_pc_mahp.Name = "txt_pc_mahp";
            this.txt_pc_mahp.ReadOnly = true;
            this.txt_pc_mahp.Size = new System.Drawing.Size(176, 27);
            this.txt_pc_mahp.TabIndex = 64;
            this.txt_pc_mahp.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(689, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "Mã chương trình";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(689, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 20);
            this.label12.TabIndex = 62;
            this.label12.Text = "Năm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(689, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 61;
            this.label13.Text = "Học kì";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(689, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 20);
            this.label14.TabIndex = 60;
            this.label14.Text = "Mã học phần";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Mã HP";
            // 
            // text_dk_mahp
            // 
            this.text_dk_mahp.Location = new System.Drawing.Point(54, 26);
            this.text_dk_mahp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.text_dk_mahp.Name = "text_dk_mahp";
            this.text_dk_mahp.Size = new System.Drawing.Size(91, 20);
            this.text_dk_mahp.TabIndex = 58;
            this.text_dk_mahp.TextChanged += new System.EventHandler(this.text_dk_mahp_TextChanged);
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.Color.Coral;
            this.button13.Location = new System.Drawing.Point(540, 43);
            this.button13.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(133, 24);
            this.button13.TabIndex = 40;
            this.button13.Text = "Xóa ĐĂNG KÝ";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(540, 8);
            this.button12.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(133, 26);
            this.button12.TabIndex = 40;
            this.button12.Text = "Thêm ĐĂNG KÝ";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // dtgmo
            // 
            this.dtgmo.AllowUserToDeleteRows = false;
            this.dtgmo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgmo.Location = new System.Drawing.Point(0, 79);
            this.dtgmo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgmo.Name = "dtgmo";
            this.dtgmo.RowHeadersWidth = 62;
            this.dtgmo.Size = new System.Drawing.Size(677, 96);
            this.dtgmo.TabIndex = 35;
            this.dtgmo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgmo_CellClick);
            // 
            // dtgdk
            // 
            this.dtgdk.AllowUserToDeleteRows = false;
            this.dtgdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdk.Location = new System.Drawing.Point(0, 211);
            this.dtgdk.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgdk.Name = "dtgdk";
            this.dtgdk.RowHeadersWidth = 62;
            this.dtgdk.Size = new System.Drawing.Size(677, 236);
            this.dtgdk.TabIndex = 35;
            this.dtgdk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdk_CellClick);
            // 
            // thongbaotimer
            // 
            this.thongbaotimer.Tick += new System.EventHandler(this.thongbaotimer_Tick);
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 515);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "SinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SinhVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pn_thongbao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongbao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kq_hp)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtghp)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgkhmo)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private DataGridView dtghp;
        private Label label5;
        private TextBox text_hp;
        private TabPage tabPage4;
        private DataGridView dtgkhmo;
        private TabPage tabPage6;
        private Button button13;
        private Button button12;
        private DataGridView dtgdk;
        private TabPage tabPage1;
        private ComboBox kq_hki;
        private DataGridView kq_hp;
        private Label label3;
        private TextBox txt_stth_hp;
        private TextBox txt_stlt_hp;
        private TextBox txt_sotc_hp;
        private TextBox txt_madv_hp;
        private TextBox txt_tenhp;
        private TextBox txt_svtd_hp;
        private TextBox txt_mahp;
        private Label lb_madv_hp;
        private Label lb_svtd_hp;
        private Label lb_stth_hp;
        private Label lb_stlt_hp;
        private Label lb_sotc_hp;
        private Label lb_tenhp;
        private Label lb_mahp;
        private TextBox txt_khmo_mact;
        private TextBox txt_khmo_nam;
        private TextBox txt_khmo_hki;
        private TextBox txt_khmo_mahp;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label8;
        private ComboBox text_khmo_nam;
        private Label label9;
        private ComboBox text_khmo_hki;
        private TextBox text_khmo_mahp;
        private Label label10;
        private TextBox txt_diemtk;
        private TextBox txt_diemck;
        private TextBox txt_diemqt;
        private TextBox txt_diemth;
        private Label DIEMTK;
        private Label DIEMCK;
        private Label label6;
        private Label label4;
        private Label label7;
        private TextBox text_dk_mahp;
        private TextBox txt_pc_mact;
        private TextBox txt_pc_nam;
        private TextBox txt_pc_hki;
        private TextBox txt_pc_mahp;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txt_pc_magv;
        private Label label16;
        private Label label15;
        private DataGridView dtgmo;
        private Timer thongbaotimer;
        private Panel pn_thongbao;
        private DataGridView dtgv_thongbao;
        private Button btn_thongbao;
    }
}