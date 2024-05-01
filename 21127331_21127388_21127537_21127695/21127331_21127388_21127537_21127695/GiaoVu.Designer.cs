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
    partial class GiaoVu
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
            this.button12 = new System.Windows.Forms.Button();
            this.txt_dtbtl_sv = new System.Windows.Forms.TextBox();
            this.txt_diachi_sv = new System.Windows.Forms.TextBox();
            this.txt_tctl_sv = new System.Windows.Forms.TextBox();
            this.txt_ngaysinh_sv = new System.Windows.Forms.TextBox();
            this.txt_manganh_sv = new System.Windows.Forms.TextBox();
            this.txt_gioitinh_sv = new System.Windows.Forms.TextBox();
            this.txt_mact_sv = new System.Windows.Forms.TextBox();
            this.txt_hoten_sv = new System.Windows.Forms.TextBox();
            this.txt_dienthoai_sv = new System.Windows.Forms.TextBox();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.lb_dtbtl_sv = new System.Windows.Forms.Label();
            this.lb_tctl_sv = new System.Windows.Forms.Label();
            this.lb_manganh_sv = new System.Windows.Forms.Label();
            this.lb_mact_sv = new System.Windows.Forms.Label();
            this.lb_dienthoai_sv = new System.Windows.Forms.Label();
            this.lb_diachi_sv = new System.Windows.Forms.Label();
            this.lb_ngaysinh_sv = new System.Windows.Forms.Label();
            this.lb_gioitinh_sv = new System.Windows.Forms.Label();
            this.lb_hoten_sv = new System.Windows.Forms.Label();
            this.lb_masv = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgsv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.text_sv = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_truongdv = new System.Windows.Forms.TextBox();
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.txt_madv = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dtgdv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.text_donvi = new System.Windows.Forms.TextBox();
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
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dtghp = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.text_hp = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_khmo_mact = new System.Windows.Forms.TextBox();
            this.txt_khmo_nam = new System.Windows.Forms.TextBox();
            this.txt_khmo_hki = new System.Windows.Forms.TextBox();
            this.txt_khmo_mahp = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.text_khmo_nam = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_khmo_hki = new System.Windows.Forms.ComboBox();
            this.dtgkhmo = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.text_khmo_mahp = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txt_pc_mact = new System.Windows.Forms.TextBox();
            this.txt_pc_nam = new System.Windows.Forms.TextBox();
            this.txt_pc_mahp = new System.Windows.Forms.TextBox();
            this.txt_pc_hki = new System.Windows.Forms.TextBox();
            this.txt_pc_magv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.chinhsua_pc = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phancong_hki = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dtgphancong = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.phancong_magv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.phancong_mahp = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txt_dk_mact = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_dk_nam = new System.Windows.Forms.TextBox();
            this.txt_dk_hki = new System.Windows.Forms.TextBox();
            this.txt_dk_magv = new System.Windows.Forms.TextBox();
            this.txt_dk_mahp = new System.Windows.Forms.TextBox();
            this.txt_dk_masv = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.dtgdk = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.dtgdk_masv = new System.Windows.Forms.TextBox();
            this.thongbaotimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pn_thongbao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongbao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtghp)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgkhmo)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgphancong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage6.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1285, 39);
            this.panel1.TabIndex = 5;
            // 
            // btn_thongbao
            // 
            this.btn_thongbao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_thongbao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongbao.Image = global::_21127331_21127388_21127537_21127695.Properties.Resources.small_mail_envelope;
            this.btn_thongbao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thongbao.Location = new System.Drawing.Point(1057, 6);
            this.btn_thongbao.Name = "btn_thongbao";
            this.btn_thongbao.Size = new System.Drawing.Size(133, 28);
            this.btn_thongbao.TabIndex = 60;
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
            this.label1.Location = new System.Drawing.Point(8, 6);
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
            this.label2.Location = new System.Drawing.Point(46, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hoang Tran Thong";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1206, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1285, 664);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pn_thongbao);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.txt_dtbtl_sv);
            this.tabPage1.Controls.Add(this.txt_diachi_sv);
            this.tabPage1.Controls.Add(this.txt_tctl_sv);
            this.tabPage1.Controls.Add(this.txt_ngaysinh_sv);
            this.tabPage1.Controls.Add(this.txt_manganh_sv);
            this.tabPage1.Controls.Add(this.txt_gioitinh_sv);
            this.tabPage1.Controls.Add(this.txt_mact_sv);
            this.tabPage1.Controls.Add(this.txt_hoten_sv);
            this.tabPage1.Controls.Add(this.txt_dienthoai_sv);
            this.tabPage1.Controls.Add(this.txt_masv);
            this.tabPage1.Controls.Add(this.lb_dtbtl_sv);
            this.tabPage1.Controls.Add(this.lb_tctl_sv);
            this.tabPage1.Controls.Add(this.lb_manganh_sv);
            this.tabPage1.Controls.Add(this.lb_mact_sv);
            this.tabPage1.Controls.Add(this.lb_dienthoai_sv);
            this.tabPage1.Controls.Add(this.lb_diachi_sv);
            this.tabPage1.Controls.Add(this.lb_ngaysinh_sv);
            this.tabPage1.Controls.Add(this.lb_gioitinh_sv);
            this.tabPage1.Controls.Add(this.lb_hoten_sv);
            this.tabPage1.Controls.Add(this.lb_masv);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dtgsv);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.text_sv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Size = new System.Drawing.Size(1277, 638);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SINH VIÊN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pn_thongbao
            // 
            this.pn_thongbao.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pn_thongbao.Controls.Add(this.dtgv_thongbao);
            this.pn_thongbao.Location = new System.Drawing.Point(863, 5);
            this.pn_thongbao.Name = "pn_thongbao";
            this.pn_thongbao.Size = new System.Drawing.Size(409, 350);
            this.pn_thongbao.TabIndex = 59;
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
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(610, 13);
            this.button12.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(133, 23);
            this.button12.TabIndex = 41;
            this.button12.Text = "Thêm ĐĂNG KÝ";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // txt_dtbtl_sv
            // 
            this.txt_dtbtl_sv.Enabled = false;
            this.txt_dtbtl_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dtbtl_sv.Location = new System.Drawing.Point(960, 543);
            this.txt_dtbtl_sv.Name = "txt_dtbtl_sv";
            this.txt_dtbtl_sv.ReadOnly = true;
            this.txt_dtbtl_sv.Size = new System.Drawing.Size(309, 27);
            this.txt_dtbtl_sv.TabIndex = 33;
            this.txt_dtbtl_sv.TabStop = false;
            // 
            // txt_diachi_sv
            // 
            this.txt_diachi_sv.Enabled = false;
            this.txt_diachi_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi_sv.Location = new System.Drawing.Point(960, 274);
            this.txt_diachi_sv.Name = "txt_diachi_sv";
            this.txt_diachi_sv.ReadOnly = true;
            this.txt_diachi_sv.Size = new System.Drawing.Size(309, 27);
            this.txt_diachi_sv.TabIndex = 31;
            this.txt_diachi_sv.TabStop = false;
            // 
            // txt_tctl_sv
            // 
            this.txt_tctl_sv.Enabled = false;
            this.txt_tctl_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tctl_sv.Location = new System.Drawing.Point(960, 489);
            this.txt_tctl_sv.Name = "txt_tctl_sv";
            this.txt_tctl_sv.ReadOnly = true;
            this.txt_tctl_sv.Size = new System.Drawing.Size(309, 27);
            this.txt_tctl_sv.TabIndex = 30;
            this.txt_tctl_sv.TabStop = false;
            // 
            // txt_ngaysinh_sv
            // 
            this.txt_ngaysinh_sv.Enabled = false;
            this.txt_ngaysinh_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaysinh_sv.Location = new System.Drawing.Point(960, 220);
            this.txt_ngaysinh_sv.Name = "txt_ngaysinh_sv";
            this.txt_ngaysinh_sv.ReadOnly = true;
            this.txt_ngaysinh_sv.Size = new System.Drawing.Size(309, 27);
            this.txt_ngaysinh_sv.TabIndex = 29;
            this.txt_ngaysinh_sv.TabStop = false;
            // 
            // txt_manganh_sv
            // 
            this.txt_manganh_sv.Enabled = false;
            this.txt_manganh_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manganh_sv.Location = new System.Drawing.Point(960, 435);
            this.txt_manganh_sv.Name = "txt_manganh_sv";
            this.txt_manganh_sv.ReadOnly = true;
            this.txt_manganh_sv.Size = new System.Drawing.Size(309, 27);
            this.txt_manganh_sv.TabIndex = 28;
            this.txt_manganh_sv.TabStop = false;
            // 
            // txt_gioitinh_sv
            // 
            this.txt_gioitinh_sv.Enabled = false;
            this.txt_gioitinh_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gioitinh_sv.Location = new System.Drawing.Point(960, 165);
            this.txt_gioitinh_sv.Name = "txt_gioitinh_sv";
            this.txt_gioitinh_sv.ReadOnly = true;
            this.txt_gioitinh_sv.Size = new System.Drawing.Size(309, 27);
            this.txt_gioitinh_sv.TabIndex = 27;
            this.txt_gioitinh_sv.TabStop = false;
            this.txt_gioitinh_sv.TextChanged += new System.EventHandler(this.txt_gioitinh_sv_TextChanged);
            // 
            // txt_mact_sv
            // 
            this.txt_mact_sv.Enabled = false;
            this.txt_mact_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mact_sv.Location = new System.Drawing.Point(960, 382);
            this.txt_mact_sv.Name = "txt_mact_sv";
            this.txt_mact_sv.ReadOnly = true;
            this.txt_mact_sv.Size = new System.Drawing.Size(309, 27);
            this.txt_mact_sv.TabIndex = 26;
            this.txt_mact_sv.TabStop = false;
            // 
            // txt_hoten_sv
            // 
            this.txt_hoten_sv.Enabled = false;
            this.txt_hoten_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten_sv.Location = new System.Drawing.Point(960, 111);
            this.txt_hoten_sv.Name = "txt_hoten_sv";
            this.txt_hoten_sv.ReadOnly = true;
            this.txt_hoten_sv.Size = new System.Drawing.Size(309, 27);
            this.txt_hoten_sv.TabIndex = 25;
            this.txt_hoten_sv.TabStop = false;
            this.txt_hoten_sv.TextChanged += new System.EventHandler(this.txt_hoten_sv_TextChanged);
            // 
            // txt_dienthoai_sv
            // 
            this.txt_dienthoai_sv.Enabled = false;
            this.txt_dienthoai_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dienthoai_sv.Location = new System.Drawing.Point(960, 328);
            this.txt_dienthoai_sv.Name = "txt_dienthoai_sv";
            this.txt_dienthoai_sv.ReadOnly = true;
            this.txt_dienthoai_sv.Size = new System.Drawing.Size(309, 27);
            this.txt_dienthoai_sv.TabIndex = 32;
            this.txt_dienthoai_sv.TabStop = false;
            // 
            // txt_masv
            // 
            this.txt_masv.Enabled = false;
            this.txt_masv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masv.Location = new System.Drawing.Point(960, 57);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.ReadOnly = true;
            this.txt_masv.Size = new System.Drawing.Size(309, 27);
            this.txt_masv.TabIndex = 24;
            this.txt_masv.TabStop = false;
            this.txt_masv.TextChanged += new System.EventHandler(this.txt_masv_TextChanged);
            // 
            // lb_dtbtl_sv
            // 
            this.lb_dtbtl_sv.AutoSize = true;
            this.lb_dtbtl_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dtbtl_sv.Location = new System.Drawing.Point(780, 543);
            this.lb_dtbtl_sv.Name = "lb_dtbtl_sv";
            this.lb_dtbtl_sv.Size = new System.Drawing.Size(168, 20);
            this.lb_dtbtl_sv.TabIndex = 23;
            this.lb_dtbtl_sv.Text = "Điểm trung bình tích lũy";
            // 
            // lb_tctl_sv
            // 
            this.lb_tctl_sv.AutoSize = true;
            this.lb_tctl_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tctl_sv.Location = new System.Drawing.Point(780, 489);
            this.lb_tctl_sv.Name = "lb_tctl_sv";
            this.lb_tctl_sv.Size = new System.Drawing.Size(121, 20);
            this.lb_tctl_sv.TabIndex = 22;
            this.lb_tctl_sv.Text = "Số tín chỉ tích lũy";
            // 
            // lb_manganh_sv
            // 
            this.lb_manganh_sv.AutoSize = true;
            this.lb_manganh_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_manganh_sv.Location = new System.Drawing.Point(780, 435);
            this.lb_manganh_sv.Name = "lb_manganh_sv";
            this.lb_manganh_sv.Size = new System.Drawing.Size(75, 20);
            this.lb_manganh_sv.TabIndex = 21;
            this.lb_manganh_sv.Text = "Mã ngành";
            // 
            // lb_mact_sv
            // 
            this.lb_mact_sv.AutoSize = true;
            this.lb_mact_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mact_sv.Location = new System.Drawing.Point(780, 382);
            this.lb_mact_sv.Name = "lb_mact_sv";
            this.lb_mact_sv.Size = new System.Drawing.Size(118, 20);
            this.lb_mact_sv.TabIndex = 20;
            this.lb_mact_sv.Text = "Mã chương trình";
            // 
            // lb_dienthoai_sv
            // 
            this.lb_dienthoai_sv.AutoSize = true;
            this.lb_dienthoai_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dienthoai_sv.Location = new System.Drawing.Point(780, 328);
            this.lb_dienthoai_sv.Name = "lb_dienthoai_sv";
            this.lb_dienthoai_sv.Size = new System.Drawing.Size(97, 20);
            this.lb_dienthoai_sv.TabIndex = 19;
            this.lb_dienthoai_sv.Text = "Số điện thoại";
            // 
            // lb_diachi_sv
            // 
            this.lb_diachi_sv.AutoSize = true;
            this.lb_diachi_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diachi_sv.Location = new System.Drawing.Point(780, 274);
            this.lb_diachi_sv.Name = "lb_diachi_sv";
            this.lb_diachi_sv.Size = new System.Drawing.Size(55, 20);
            this.lb_diachi_sv.TabIndex = 18;
            this.lb_diachi_sv.Text = "Địa chỉ";
            // 
            // lb_ngaysinh_sv
            // 
            this.lb_ngaysinh_sv.AutoSize = true;
            this.lb_ngaysinh_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaysinh_sv.Location = new System.Drawing.Point(780, 220);
            this.lb_ngaysinh_sv.Name = "lb_ngaysinh_sv";
            this.lb_ngaysinh_sv.Size = new System.Drawing.Size(74, 20);
            this.lb_ngaysinh_sv.TabIndex = 17;
            this.lb_ngaysinh_sv.Text = "Ngày sinh";
            // 
            // lb_gioitinh_sv
            // 
            this.lb_gioitinh_sv.AutoSize = true;
            this.lb_gioitinh_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gioitinh_sv.Location = new System.Drawing.Point(780, 165);
            this.lb_gioitinh_sv.Name = "lb_gioitinh_sv";
            this.lb_gioitinh_sv.Size = new System.Drawing.Size(65, 20);
            this.lb_gioitinh_sv.TabIndex = 16;
            this.lb_gioitinh_sv.Text = "Giới tính";
            this.lb_gioitinh_sv.Click += new System.EventHandler(this.lb_gioitinh_sv_Click);
            // 
            // lb_hoten_sv
            // 
            this.lb_hoten_sv.AutoSize = true;
            this.lb_hoten_sv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoten_sv.Location = new System.Drawing.Point(780, 111);
            this.lb_hoten_sv.Name = "lb_hoten_sv";
            this.lb_hoten_sv.Size = new System.Drawing.Size(73, 20);
            this.lb_hoten_sv.TabIndex = 15;
            this.lb_hoten_sv.Text = "Họ và tên";
            this.lb_hoten_sv.Click += new System.EventHandler(this.lb_hoten_sv_Click);
            // 
            // lb_masv
            // 
            this.lb_masv.AutoSize = true;
            this.lb_masv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_masv.Location = new System.Drawing.Point(780, 57);
            this.lb_masv.Name = "lb_masv";
            this.lb_masv.Size = new System.Drawing.Size(91, 20);
            this.lb_masv.TabIndex = 14;
            this.lb_masv.Text = "Mã sinh viên";
            this.lb_masv.Click += new System.EventHandler(this.lb_masv_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1109, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 21);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cập nhật SV";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1191, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 21);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thêm SV";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtgsv
            // 
            this.dtgsv.AllowUserToDeleteRows = false;
            this.dtgsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgsv.Location = new System.Drawing.Point(2, 51);
            this.dtgsv.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgsv.Name = "dtgsv";
            this.dtgsv.RowHeadersWidth = 62;
            this.dtgsv.Size = new System.Drawing.Size(753, 533);
            this.dtgsv.TabIndex = 3;
            this.dtgsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgsv_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MSSV";
            // 
            // text_sv
            // 
            this.text_sv.Location = new System.Drawing.Point(59, 21);
            this.text_sv.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.text_sv.Name = "text_sv";
            this.text_sv.Size = new System.Drawing.Size(91, 20);
            this.text_sv.TabIndex = 0;
            this.text_sv.TextChanged += new System.EventHandler(this.text_sv_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_truongdv);
            this.tabPage2.Controls.Add(this.txt_tendv);
            this.tabPage2.Controls.Add(this.txt_madv);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.dtgdv);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.text_donvi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Size = new System.Drawing.Size(1277, 638);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ĐƠN VỊ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_truongdv
            // 
            this.txt_truongdv.Enabled = false;
            this.txt_truongdv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_truongdv.Location = new System.Drawing.Point(861, 297);
            this.txt_truongdv.Name = "txt_truongdv";
            this.txt_truongdv.ReadOnly = true;
            this.txt_truongdv.Size = new System.Drawing.Size(309, 27);
            this.txt_truongdv.TabIndex = 33;
            this.txt_truongdv.TabStop = false;
            // 
            // txt_tendv
            // 
            this.txt_tendv.Enabled = false;
            this.txt_tendv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendv.Location = new System.Drawing.Point(861, 243);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.ReadOnly = true;
            this.txt_tendv.Size = new System.Drawing.Size(309, 27);
            this.txt_tendv.TabIndex = 32;
            this.txt_tendv.TabStop = false;
            // 
            // txt_madv
            // 
            this.txt_madv.Enabled = false;
            this.txt_madv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_madv.Location = new System.Drawing.Point(861, 189);
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.ReadOnly = true;
            this.txt_madv.Size = new System.Drawing.Size(309, 27);
            this.txt_madv.TabIndex = 31;
            this.txt_madv.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(681, 297);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 20);
            this.label22.TabIndex = 30;
            this.label22.Text = "Trưởng đơn vị";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(681, 243);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 20);
            this.label23.TabIndex = 29;
            this.label23.Text = "Tên đơn vị";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(681, 189);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 20);
            this.label24.TabIndex = 28;
            this.label24.Text = "Mã đơn vị";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(931, 99);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Cập nhật Đơn vị";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button5.Location = new System.Drawing.Point(1070, 99);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 32);
            this.button5.TabIndex = 8;
            this.button5.Text = "Thêm Đơn vị";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dtgdv
            // 
            this.dtgdv.AllowUserToDeleteRows = false;
            this.dtgdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdv.Location = new System.Drawing.Point(29, 159);
            this.dtgdv.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgdv.Name = "dtgdv";
            this.dtgdv.RowHeadersWidth = 62;
            this.dtgdv.Size = new System.Drawing.Size(581, 200);
            this.dtgdv.TabIndex = 6;
            this.dtgdv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdv_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Đơn vị";
            // 
            // text_donvi
            // 
            this.text_donvi.Location = new System.Drawing.Point(121, 107);
            this.text_donvi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.text_donvi.Name = "text_donvi";
            this.text_donvi.Size = new System.Drawing.Size(122, 20);
            this.text_donvi.TabIndex = 4;
            this.text_donvi.TextChanged += new System.EventHandler(this.text_donvi_TextChanged);
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
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.dtghp);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.text_hp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1277, 638);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HỌC PHẦN";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_stth_hp
            // 
            this.txt_stth_hp.Enabled = false;
            this.txt_stth_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stth_hp.Location = new System.Drawing.Point(911, 361);
            this.txt_stth_hp.Name = "txt_stth_hp";
            this.txt_stth_hp.ReadOnly = true;
            this.txt_stth_hp.Size = new System.Drawing.Size(309, 27);
            this.txt_stth_hp.TabIndex = 51;
            this.txt_stth_hp.TabStop = false;
            // 
            // txt_stlt_hp
            // 
            this.txt_stlt_hp.Enabled = false;
            this.txt_stlt_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stlt_hp.Location = new System.Drawing.Point(911, 285);
            this.txt_stlt_hp.Name = "txt_stlt_hp";
            this.txt_stlt_hp.ReadOnly = true;
            this.txt_stlt_hp.Size = new System.Drawing.Size(309, 27);
            this.txt_stlt_hp.TabIndex = 50;
            this.txt_stlt_hp.TabStop = false;
            // 
            // txt_sotc_hp
            // 
            this.txt_sotc_hp.Enabled = false;
            this.txt_sotc_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotc_hp.Location = new System.Drawing.Point(911, 211);
            this.txt_sotc_hp.Name = "txt_sotc_hp";
            this.txt_sotc_hp.ReadOnly = true;
            this.txt_sotc_hp.Size = new System.Drawing.Size(309, 27);
            this.txt_sotc_hp.TabIndex = 49;
            this.txt_sotc_hp.TabStop = false;
            // 
            // txt_madv_hp
            // 
            this.txt_madv_hp.Enabled = false;
            this.txt_madv_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_madv_hp.Location = new System.Drawing.Point(911, 511);
            this.txt_madv_hp.Name = "txt_madv_hp";
            this.txt_madv_hp.ReadOnly = true;
            this.txt_madv_hp.Size = new System.Drawing.Size(309, 27);
            this.txt_madv_hp.TabIndex = 48;
            this.txt_madv_hp.TabStop = false;
            // 
            // txt_tenhp
            // 
            this.txt_tenhp.Enabled = false;
            this.txt_tenhp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenhp.Location = new System.Drawing.Point(911, 136);
            this.txt_tenhp.Name = "txt_tenhp";
            this.txt_tenhp.ReadOnly = true;
            this.txt_tenhp.Size = new System.Drawing.Size(309, 27);
            this.txt_tenhp.TabIndex = 47;
            this.txt_tenhp.TabStop = false;
            // 
            // txt_svtd_hp
            // 
            this.txt_svtd_hp.Enabled = false;
            this.txt_svtd_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_svtd_hp.Location = new System.Drawing.Point(911, 435);
            this.txt_svtd_hp.Name = "txt_svtd_hp";
            this.txt_svtd_hp.ReadOnly = true;
            this.txt_svtd_hp.Size = new System.Drawing.Size(309, 27);
            this.txt_svtd_hp.TabIndex = 46;
            this.txt_svtd_hp.TabStop = false;
            // 
            // txt_mahp
            // 
            this.txt_mahp.Enabled = false;
            this.txt_mahp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahp.Location = new System.Drawing.Point(911, 60);
            this.txt_mahp.Name = "txt_mahp";
            this.txt_mahp.ReadOnly = true;
            this.txt_mahp.Size = new System.Drawing.Size(309, 27);
            this.txt_mahp.TabIndex = 45;
            this.txt_mahp.TabStop = false;
            // 
            // lb_madv_hp
            // 
            this.lb_madv_hp.AutoSize = true;
            this.lb_madv_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_madv_hp.Location = new System.Drawing.Point(731, 511);
            this.lb_madv_hp.Name = "lb_madv_hp";
            this.lb_madv_hp.Size = new System.Drawing.Size(75, 20);
            this.lb_madv_hp.TabIndex = 44;
            this.lb_madv_hp.Text = "Mã đơn vị";
            // 
            // lb_svtd_hp
            // 
            this.lb_svtd_hp.AutoSize = true;
            this.lb_svtd_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_svtd_hp.Location = new System.Drawing.Point(731, 435);
            this.lb_svtd_hp.Name = "lb_svtd_hp";
            this.lb_svtd_hp.Size = new System.Drawing.Size(130, 20);
            this.lb_svtd_hp.TabIndex = 43;
            this.lb_svtd_hp.Text = "Số sinh viên tối đa";
            // 
            // lb_stth_hp
            // 
            this.lb_stth_hp.AutoSize = true;
            this.lb_stth_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stth_hp.Location = new System.Drawing.Point(731, 361);
            this.lb_stth_hp.Name = "lb_stth_hp";
            this.lb_stth_hp.Size = new System.Drawing.Size(121, 20);
            this.lb_stth_hp.TabIndex = 42;
            this.lb_stth_hp.Text = "Số tiết thực hành";
            // 
            // lb_stlt_hp
            // 
            this.lb_stlt_hp.AutoSize = true;
            this.lb_stlt_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stlt_hp.Location = new System.Drawing.Point(731, 285);
            this.lb_stlt_hp.Name = "lb_stlt_hp";
            this.lb_stlt_hp.Size = new System.Drawing.Size(112, 20);
            this.lb_stlt_hp.TabIndex = 41;
            this.lb_stlt_hp.Text = "Số tiết lý thuyết";
            // 
            // lb_sotc_hp
            // 
            this.lb_sotc_hp.AutoSize = true;
            this.lb_sotc_hp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sotc_hp.Location = new System.Drawing.Point(731, 211);
            this.lb_sotc_hp.Name = "lb_sotc_hp";
            this.lb_sotc_hp.Size = new System.Drawing.Size(70, 20);
            this.lb_sotc_hp.TabIndex = 40;
            this.lb_sotc_hp.Text = "Số tín chỉ";
            // 
            // lb_tenhp
            // 
            this.lb_tenhp.AutoSize = true;
            this.lb_tenhp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenhp.Location = new System.Drawing.Point(731, 136);
            this.lb_tenhp.Name = "lb_tenhp";
            this.lb_tenhp.Size = new System.Drawing.Size(97, 20);
            this.lb_tenhp.TabIndex = 39;
            this.lb_tenhp.Text = "Tên học phần";
            // 
            // lb_mahp
            // 
            this.lb_mahp.AutoSize = true;
            this.lb_mahp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahp.Location = new System.Drawing.Point(731, 60);
            this.lb_mahp.Name = "lb_mahp";
            this.lb_mahp.Size = new System.Drawing.Size(95, 20);
            this.lb_mahp.TabIndex = 38;
            this.lb_mahp.Text = "Mã học phần";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(447, 12);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 30);
            this.button6.TabIndex = 10;
            this.button6.Text = "Cập nhật HP";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(573, 12);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 30);
            this.button7.TabIndex = 11;
            this.button7.Text = "Thêm HP";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dtghp
            // 
            this.dtghp.AllowUserToDeleteRows = false;
            this.dtghp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtghp.Location = new System.Drawing.Point(0, 44);
            this.dtghp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtghp.Name = "dtghp";
            this.dtghp.RowHeadersWidth = 62;
            this.dtghp.Size = new System.Drawing.Size(717, 571);
            this.dtghp.TabIndex = 9;
            this.dtghp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtghp_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã HP";
            // 
            // text_hp
            // 
            this.text_hp.Location = new System.Drawing.Point(47, 12);
            this.text_hp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.text_hp.Name = "text_hp";
            this.text_hp.Size = new System.Drawing.Size(91, 20);
            this.text_hp.TabIndex = 7;
            this.text_hp.TextChanged += new System.EventHandler(this.text_hp_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txt_khmo_mact);
            this.tabPage4.Controls.Add(this.txt_khmo_nam);
            this.tabPage4.Controls.Add(this.txt_khmo_hki);
            this.tabPage4.Controls.Add(this.txt_khmo_mahp);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.text_khmo_nam);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.text_khmo_hki);
            this.tabPage4.Controls.Add(this.dtgkhmo);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.text_khmo_mahp);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1277, 638);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "KẾ HOẠCH MỞ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_khmo_mact
            // 
            this.txt_khmo_mact.Enabled = false;
            this.txt_khmo_mact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khmo_mact.Location = new System.Drawing.Point(913, 376);
            this.txt_khmo_mact.Name = "txt_khmo_mact";
            this.txt_khmo_mact.ReadOnly = true;
            this.txt_khmo_mact.Size = new System.Drawing.Size(309, 27);
            this.txt_khmo_mact.TabIndex = 43;
            this.txt_khmo_mact.TabStop = false;
            // 
            // txt_khmo_nam
            // 
            this.txt_khmo_nam.Enabled = false;
            this.txt_khmo_nam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khmo_nam.Location = new System.Drawing.Point(913, 302);
            this.txt_khmo_nam.Name = "txt_khmo_nam";
            this.txt_khmo_nam.ReadOnly = true;
            this.txt_khmo_nam.Size = new System.Drawing.Size(309, 27);
            this.txt_khmo_nam.TabIndex = 42;
            this.txt_khmo_nam.TabStop = false;
            // 
            // txt_khmo_hki
            // 
            this.txt_khmo_hki.Enabled = false;
            this.txt_khmo_hki.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khmo_hki.Location = new System.Drawing.Point(913, 227);
            this.txt_khmo_hki.Name = "txt_khmo_hki";
            this.txt_khmo_hki.ReadOnly = true;
            this.txt_khmo_hki.Size = new System.Drawing.Size(309, 27);
            this.txt_khmo_hki.TabIndex = 41;
            this.txt_khmo_hki.TabStop = false;
            // 
            // txt_khmo_mahp
            // 
            this.txt_khmo_mahp.Enabled = false;
            this.txt_khmo_mahp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khmo_mahp.Location = new System.Drawing.Point(913, 151);
            this.txt_khmo_mahp.Name = "txt_khmo_mahp";
            this.txt_khmo_mahp.ReadOnly = true;
            this.txt_khmo_mahp.Size = new System.Drawing.Size(309, 27);
            this.txt_khmo_mahp.TabIndex = 40;
            this.txt_khmo_mahp.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(733, 376);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(118, 20);
            this.label25.TabIndex = 39;
            this.label25.Text = "Mã chương trình";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(733, 302);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 20);
            this.label26.TabIndex = 38;
            this.label26.Text = "Năm";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(733, 227);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(51, 20);
            this.label27.TabIndex = 37;
            this.label27.Text = "Học kì";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(733, 151);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(95, 20);
            this.label28.TabIndex = 36;
            this.label28.Text = "Mã học phần";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(567, 6);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 29);
            this.button8.TabIndex = 21;
            this.button8.Text = "Cập nhật KHMO";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(567, 46);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(103, 25);
            this.button9.TabIndex = 22;
            this.button9.Text = "Thêm KHMO";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Năm học";
            // 
            // text_khmo_nam
            // 
            this.text_khmo_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_khmo_nam.FormattingEnabled = true;
            this.text_khmo_nam.Items.AddRange(new object[] {
            "2024"});
            this.text_khmo_nam.Location = new System.Drawing.Point(399, 21);
            this.text_khmo_nam.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.text_khmo_nam.Name = "text_khmo_nam";
            this.text_khmo_nam.Size = new System.Drawing.Size(111, 21);
            this.text_khmo_nam.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 18;
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
            this.text_khmo_hki.Location = new System.Drawing.Point(209, 21);
            this.text_khmo_hki.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.text_khmo_hki.Name = "text_khmo_hki";
            this.text_khmo_hki.Size = new System.Drawing.Size(111, 21);
            this.text_khmo_hki.TabIndex = 17;
            this.text_khmo_hki.SelectedIndexChanged += new System.EventHandler(this.text_khmo_hki_TextChanged);
            this.text_khmo_hki.TextChanged += new System.EventHandler(this.text_khmo_hki_TextChanged);
            // 
            // dtgkhmo
            // 
            this.dtgkhmo.AllowUserToDeleteRows = false;
            this.dtgkhmo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgkhmo.Location = new System.Drawing.Point(-3, 73);
            this.dtgkhmo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgkhmo.Name = "dtgkhmo";
            this.dtgkhmo.RowHeadersWidth = 62;
            this.dtgkhmo.Size = new System.Drawing.Size(677, 535);
            this.dtgkhmo.TabIndex = 16;
            this.dtgkhmo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgkhmo_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Mã HP";
            // 
            // text_khmo_mahp
            // 
            this.text_khmo_mahp.Location = new System.Drawing.Point(53, 21);
            this.text_khmo_mahp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.text_khmo_mahp.Name = "text_khmo_mahp";
            this.text_khmo_mahp.Size = new System.Drawing.Size(91, 20);
            this.text_khmo_mahp.TabIndex = 14;
            this.text_khmo_mahp.TextChanged += new System.EventHandler(this.text_khmo_mahp_TextChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txt_pc_mact);
            this.tabPage5.Controls.Add(this.txt_pc_nam);
            this.tabPage5.Controls.Add(this.txt_pc_mahp);
            this.tabPage5.Controls.Add(this.txt_pc_hki);
            this.tabPage5.Controls.Add(this.txt_pc_magv);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.label30);
            this.tabPage5.Controls.Add(this.chinhsua_pc);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.phancong_hki);
            this.tabPage5.Controls.Add(this.comboBox2);
            this.tabPage5.Controls.Add(this.dtgphancong);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.phancong_magv);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.phancong_mahp);
            this.tabPage5.Controls.Add(this.textBox6);
            this.tabPage5.Controls.Add(this.textBox5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage5.Size = new System.Drawing.Size(1277, 638);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "PHÂN CÔNG";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txt_pc_mact
            // 
            this.txt_pc_mact.Enabled = false;
            this.txt_pc_mact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pc_mact.Location = new System.Drawing.Point(885, 395);
            this.txt_pc_mact.Name = "txt_pc_mact";
            this.txt_pc_mact.ReadOnly = true;
            this.txt_pc_mact.Size = new System.Drawing.Size(309, 27);
            this.txt_pc_mact.TabIndex = 51;
            this.txt_pc_mact.TabStop = false;
            // 
            // txt_pc_nam
            // 
            this.txt_pc_nam.Enabled = false;
            this.txt_pc_nam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pc_nam.Location = new System.Drawing.Point(885, 342);
            this.txt_pc_nam.Name = "txt_pc_nam";
            this.txt_pc_nam.ReadOnly = true;
            this.txt_pc_nam.Size = new System.Drawing.Size(309, 27);
            this.txt_pc_nam.TabIndex = 50;
            this.txt_pc_nam.TabStop = false;
            // 
            // txt_pc_mahp
            // 
            this.txt_pc_mahp.Enabled = false;
            this.txt_pc_mahp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pc_mahp.Location = new System.Drawing.Point(885, 229);
            this.txt_pc_mahp.Name = "txt_pc_mahp";
            this.txt_pc_mahp.ReadOnly = true;
            this.txt_pc_mahp.Size = new System.Drawing.Size(309, 27);
            this.txt_pc_mahp.TabIndex = 49;
            this.txt_pc_mahp.TabStop = false;
            // 
            // txt_pc_hki
            // 
            this.txt_pc_hki.Enabled = false;
            this.txt_pc_hki.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pc_hki.Location = new System.Drawing.Point(885, 285);
            this.txt_pc_hki.Name = "txt_pc_hki";
            this.txt_pc_hki.ReadOnly = true;
            this.txt_pc_hki.Size = new System.Drawing.Size(309, 27);
            this.txt_pc_hki.TabIndex = 49;
            this.txt_pc_hki.TabStop = false;
            // 
            // txt_pc_magv
            // 
            this.txt_pc_magv.Enabled = false;
            this.txt_pc_magv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pc_magv.Location = new System.Drawing.Point(885, 170);
            this.txt_pc_magv.Name = "txt_pc_magv";
            this.txt_pc_magv.ReadOnly = true;
            this.txt_pc_magv.Size = new System.Drawing.Size(309, 27);
            this.txt_pc_magv.TabIndex = 48;
            this.txt_pc_magv.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(705, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Mã chương trình";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(705, 231);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(95, 20);
            this.label31.TabIndex = 45;
            this.label31.Text = "Mã học phần";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(705, 344);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 20);
            this.label16.TabIndex = 46;
            this.label16.Text = "Năm";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(705, 287);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(51, 20);
            this.label29.TabIndex = 45;
            this.label29.Text = "Học kì";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(705, 172);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(95, 20);
            this.label30.TabIndex = 44;
            this.label30.Text = "Mã giáo viên";
            // 
            // chinhsua_pc
            // 
            this.chinhsua_pc.Location = new System.Drawing.Point(543, 17);
            this.chinhsua_pc.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.chinhsua_pc.Name = "chinhsua_pc";
            this.chinhsua_pc.Size = new System.Drawing.Size(133, 30);
            this.chinhsua_pc.TabIndex = 30;
            this.chinhsua_pc.Text = "Chỉnh sửa PHÂN CÔNG";
            this.chinhsua_pc.UseVisualStyleBackColor = true;
            this.chinhsua_pc.Click += new System.EventHandler(this.button11_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 34);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Học kì";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Học kì";
            // 
            // phancong_hki
            // 
            this.phancong_hki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phancong_hki.FormattingEnabled = true;
            this.phancong_hki.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.phancong_hki.Location = new System.Drawing.Point(51, 32);
            this.phancong_hki.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.phancong_hki.Name = "phancong_hki";
            this.phancong_hki.Size = new System.Drawing.Size(111, 21);
            this.phancong_hki.TabIndex = 26;
            this.phancong_hki.SelectedIndexChanged += new System.EventHandler(this.phancong_hki_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(51, 32);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(111, 21);
            this.comboBox2.TabIndex = 26;
            // 
            // dtgphancong
            // 
            this.dtgphancong.AllowUserToDeleteRows = false;
            this.dtgphancong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgphancong.Location = new System.Drawing.Point(-1, 61);
            this.dtgphancong.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgphancong.Name = "dtgphancong";
            this.dtgphancong.RowHeadersWidth = 62;
            this.dtgphancong.Size = new System.Drawing.Size(677, 560);
            this.dtgphancong.TabIndex = 25;
            this.dtgphancong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgphancong_CellClick);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(-1, 61);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 62;
            this.dataGridView5.Size = new System.Drawing.Size(677, 236);
            this.dataGridView5.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(188, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Mã GV";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(188, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Mã GV";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Mã HP";
            // 
            // phancong_magv
            // 
            this.phancong_magv.Location = new System.Drawing.Point(242, 6);
            this.phancong_magv.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.phancong_magv.Name = "phancong_magv";
            this.phancong_magv.Size = new System.Drawing.Size(111, 20);
            this.phancong_magv.TabIndex = 23;
            this.phancong_magv.TextChanged += new System.EventHandler(this.phancong_magv_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Mã HP";
            // 
            // phancong_mahp
            // 
            this.phancong_mahp.Location = new System.Drawing.Point(51, 6);
            this.phancong_mahp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.phancong_mahp.Name = "phancong_mahp";
            this.phancong_mahp.Size = new System.Drawing.Size(111, 20);
            this.phancong_mahp.TabIndex = 23;
            this.phancong_mahp.TextChanged += new System.EventHandler(this.phancong_mahp_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(242, 6);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(111, 20);
            this.textBox6.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(51, 6);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(111, 20);
            this.textBox5.TabIndex = 23;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txt_dk_mact);
            this.tabPage6.Controls.Add(this.label33);
            this.tabPage6.Controls.Add(this.txt_dk_nam);
            this.tabPage6.Controls.Add(this.txt_dk_hki);
            this.tabPage6.Controls.Add(this.txt_dk_magv);
            this.tabPage6.Controls.Add(this.txt_dk_mahp);
            this.tabPage6.Controls.Add(this.txt_dk_masv);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.label21);
            this.tabPage6.Controls.Add(this.label32);
            this.tabPage6.Controls.Add(this.button13);
            this.tabPage6.Controls.Add(this.dtgdk);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.dtgdk_masv);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1277, 638);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "ĐĂNG KÝ";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txt_dk_mact
            // 
            this.txt_dk_mact.Enabled = false;
            this.txt_dk_mact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dk_mact.Location = new System.Drawing.Point(913, 366);
            this.txt_dk_mact.Name = "txt_dk_mact";
            this.txt_dk_mact.ReadOnly = true;
            this.txt_dk_mact.Size = new System.Drawing.Size(309, 27);
            this.txt_dk_mact.TabIndex = 63;
            this.txt_dk_mact.TabStop = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(733, 368);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(118, 20);
            this.label33.TabIndex = 62;
            this.label33.Text = "Mã chương trình";
            // 
            // txt_dk_nam
            // 
            this.txt_dk_nam.Enabled = false;
            this.txt_dk_nam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dk_nam.Location = new System.Drawing.Point(913, 313);
            this.txt_dk_nam.Name = "txt_dk_nam";
            this.txt_dk_nam.ReadOnly = true;
            this.txt_dk_nam.Size = new System.Drawing.Size(309, 27);
            this.txt_dk_nam.TabIndex = 61;
            this.txt_dk_nam.TabStop = false;
            // 
            // txt_dk_hki
            // 
            this.txt_dk_hki.Enabled = false;
            this.txt_dk_hki.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dk_hki.Location = new System.Drawing.Point(913, 260);
            this.txt_dk_hki.Name = "txt_dk_hki";
            this.txt_dk_hki.ReadOnly = true;
            this.txt_dk_hki.Size = new System.Drawing.Size(309, 27);
            this.txt_dk_hki.TabIndex = 60;
            this.txt_dk_hki.TabStop = false;
            // 
            // txt_dk_magv
            // 
            this.txt_dk_magv.Enabled = false;
            this.txt_dk_magv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dk_magv.Location = new System.Drawing.Point(913, 148);
            this.txt_dk_magv.Name = "txt_dk_magv";
            this.txt_dk_magv.ReadOnly = true;
            this.txt_dk_magv.Size = new System.Drawing.Size(309, 27);
            this.txt_dk_magv.TabIndex = 58;
            this.txt_dk_magv.TabStop = false;
            // 
            // txt_dk_mahp
            // 
            this.txt_dk_mahp.Enabled = false;
            this.txt_dk_mahp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dk_mahp.Location = new System.Drawing.Point(913, 203);
            this.txt_dk_mahp.Name = "txt_dk_mahp";
            this.txt_dk_mahp.ReadOnly = true;
            this.txt_dk_mahp.Size = new System.Drawing.Size(309, 27);
            this.txt_dk_mahp.TabIndex = 59;
            this.txt_dk_mahp.TabStop = false;
            // 
            // txt_dk_masv
            // 
            this.txt_dk_masv.Enabled = false;
            this.txt_dk_masv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dk_masv.Location = new System.Drawing.Point(913, 88);
            this.txt_dk_masv.Name = "txt_dk_masv";
            this.txt_dk_masv.ReadOnly = true;
            this.txt_dk_masv.Size = new System.Drawing.Size(309, 27);
            this.txt_dk_masv.TabIndex = 57;
            this.txt_dk_masv.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(733, 315);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 20);
            this.label17.TabIndex = 56;
            this.label17.Text = "Năm";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(733, 150);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 20);
            this.label18.TabIndex = 53;
            this.label18.Text = "Mã giáo viên";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(733, 262);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 20);
            this.label19.TabIndex = 55;
            this.label19.Text = "Học kì";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(733, 205);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 20);
            this.label21.TabIndex = 54;
            this.label21.Text = "Mã học phần";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(733, 90);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(91, 20);
            this.label32.TabIndex = 52;
            this.label32.Text = "Mã sinh viên";
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.Color.Coral;
            this.button13.Location = new System.Drawing.Point(540, 34);
            this.button13.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(133, 25);
            this.button13.TabIndex = 40;
            this.button13.Text = "Xóa ĐĂNG KÝ";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // dtgdk
            // 
            this.dtgdk.AllowUserToDeleteRows = false;
            this.dtgdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdk.Location = new System.Drawing.Point(-1, 61);
            this.dtgdk.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgdk.Name = "dtgdk";
            this.dtgdk.RowHeadersWidth = 62;
            this.dtgdk.Size = new System.Drawing.Size(677, 349);
            this.dtgdk.TabIndex = 35;
            this.dtgdk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdk_CellClick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 40);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "Mã SV";
            // 
            // dtgdk_masv
            // 
            this.dtgdk_masv.Location = new System.Drawing.Point(59, 38);
            this.dtgdk_masv.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgdk_masv.Name = "dtgdk_masv";
            this.dtgdk_masv.Size = new System.Drawing.Size(111, 20);
            this.dtgdk_masv.TabIndex = 32;
            this.dtgdk_masv.TextChanged += new System.EventHandler(this.dtgdk_masv_TextChanged);
            // 
            // thongbaotimer
            // 
            this.thongbaotimer.Tick += new System.EventHandler(this.thongbaotimer_Tick);
            // 
            // GiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 682);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "GiaoVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoVu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pn_thongbao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongbao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtghp)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgkhmo)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgphancong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dtgsv;
        private Label label3;
        private TextBox text_sv;
        private TabPage tabPage2;
        private DataGridView dtgdv;
        private Label label4;
        private TextBox text_donvi;
        private TabPage tabPage3;
        private DataGridView dtghp;
        private Label label5;
        private TextBox text_hp;
        private TabPage tabPage4;
        private Label label8;
        private ComboBox text_khmo_nam;
        private Label label9;
        private ComboBox text_khmo_hki;
        private DataGridView dtgkhmo;
        private Label label10;
        private TextBox text_khmo_mahp;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private TabPage tabPage5;
        private Label label7;
        private ComboBox comboBox2;
        private DataGridView dataGridView5;
        private Label label11;
        private TextBox textBox5;
        private Label label12;
        private TextBox textBox6;
        private TabPage tabPage6;
        private Button chinhsua_pc;
        private Label label15;
        private ComboBox phancong_hki;
        private DataGridView dtgphancong;
        private Label label14;
        private Label label13;
        private TextBox phancong_magv;
        private TextBox phancong_mahp;
        private Button button13;
        private DataGridView dtgdk;
        private Label label20;
        private TextBox dtgdk_masv;
        private TextBox txt_dtbtl_sv;
        private TextBox txt_diachi_sv;
        private TextBox txt_tctl_sv;
        private TextBox txt_ngaysinh_sv;
        private TextBox txt_manganh_sv;
        private TextBox txt_gioitinh_sv;
        private TextBox txt_mact_sv;
        private TextBox txt_hoten_sv;
        private TextBox txt_dienthoai_sv;
        private TextBox txt_masv;
        private Label lb_dtbtl_sv;
        private Label lb_tctl_sv;
        private Label lb_manganh_sv;
        private Label lb_mact_sv;
        private Label lb_dienthoai_sv;
        private Label lb_diachi_sv;
        private Label lb_ngaysinh_sv;
        private Label lb_gioitinh_sv;
        private Label lb_hoten_sv;
        private Label lb_masv;
        private TextBox txt_truongdv;
        private TextBox txt_tendv;
        private TextBox txt_madv;
        private Label label22;
        private Label label23;
        private Label label24;
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
        private TextBox txt_pc_mact;
        private TextBox txt_pc_nam;
        private TextBox txt_pc_hki;
        private TextBox txt_pc_magv;
        private Label label6;
        private Label label16;
        private Label label29;
        private Label label30;
        private TextBox txt_pc_mahp;
        private Label label31;
        private TextBox txt_dk_nam;
        private TextBox txt_dk_hki;
        private TextBox txt_dk_magv;
        private TextBox txt_dk_mahp;
        private TextBox txt_dk_masv;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label21;
        private Label label32;
        private TextBox txt_dk_mact;
        private Label label33;
        private Button button12;
        private Button btn_thongbao;
        private DataGridView dtgv_thongbao;
        private Timer thongbaotimer;
        private Panel pn_thongbao;
    }
}