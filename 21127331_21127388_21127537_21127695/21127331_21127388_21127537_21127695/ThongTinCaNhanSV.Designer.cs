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
    partial class ThongTinCaNhanSV
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manganh = new System.Windows.Forms.Label();
            this.ngaysinh = new System.Windows.Forms.Label();
            this.phai = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mact = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.Label();
            this.mssv = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.diachi = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.sotctl = new System.Windows.Forms.Label();
            this.dtbtl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "SĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "MSSV";
            // 
            // manganh
            // 
            this.manganh.AutoSize = true;
            this.manganh.Location = new System.Drawing.Point(413, 136);
            this.manganh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manganh.Name = "manganh";
            this.manganh.Size = new System.Drawing.Size(36, 13);
            this.manganh.TabIndex = 19;
            this.manganh.Text = "HTTT";
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSize = true;
            this.ngaysinh.Location = new System.Drawing.Point(97, 167);
            this.ngaysinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(65, 13);
            this.ngaysinh.TabIndex = 20;
            this.ngaysinh.Text = "01/01/2001";
            // 
            // phai
            // 
            this.phai.AutoSize = true;
            this.phai.Location = new System.Drawing.Point(97, 136);
            this.phai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phai.Name = "phai";
            this.phai.Size = new System.Drawing.Size(29, 13);
            this.phai.TabIndex = 21;
            this.phai.Text = "Nam";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 167);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Ngày sinh";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(322, 136);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "MANGANH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Phái";
            // 
            // mact
            // 
            this.mact.AutoSize = true;
            this.mact.Location = new System.Drawing.Point(413, 108);
            this.mact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mact.Name = "mact";
            this.mact.Size = new System.Drawing.Size(39, 13);
            this.mact.TabIndex = 14;
            this.mact.Text = "21CLC";
            // 
            // hoten
            // 
            this.hoten.AutoSize = true;
            this.hoten.Location = new System.Drawing.Point(97, 108);
            this.hoten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(98, 13);
            this.hoten.TabIndex = 15;
            this.hoten.Text = "Hoàng Trần Thông";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "MACT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Họ tên";
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.Location = new System.Drawing.Point(413, 79);
            this.sdt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(67, 13);
            this.sdt.TabIndex = 10;
            this.sdt.Text = "0123456789";
            // 
            // mssv
            // 
            this.mssv.AutoSize = true;
            this.mssv.Location = new System.Drawing.Point(97, 79);
            this.mssv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mssv.Name = "mssv";
            this.mssv.Size = new System.Drawing.Size(55, 13);
            this.mssv.TabIndex = 11;
            this.mssv.Text = "21127695";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Đổi SĐT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 198);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Địa chỉ";
            // 
            // diachi
            // 
            this.diachi.AutoSize = true;
            this.diachi.Location = new System.Drawing.Point(97, 198);
            this.diachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(103, 13);
            this.diachi.TabIndex = 25;
            this.diachi.Text = "123 Nguyễn Văn Cừ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(322, 167);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "SOTCTL";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(322, 198);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "DTBTL";
            // 
            // sotctl
            // 
            this.sotctl.AutoSize = true;
            this.sotctl.Location = new System.Drawing.Point(413, 167);
            this.sotctl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sotctl.Name = "sotctl";
            this.sotctl.Size = new System.Drawing.Size(25, 13);
            this.sotctl.TabIndex = 28;
            this.sotctl.Text = "100";
            // 
            // dtbtl
            // 
            this.dtbtl.AutoSize = true;
            this.dtbtl.Location = new System.Drawing.Point(413, 198);
            this.dtbtl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dtbtl.Name = "dtbtl";
            this.dtbtl.Size = new System.Drawing.Size(22, 13);
            this.dtbtl.TabIndex = 29;
            this.dtbtl.Text = "5.0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 27);
            this.button2.TabIndex = 30;
            this.button2.Text = "Đổi địa chỉ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ThongTinCaNhanSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 219);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtbtl);
            this.Controls.Add(this.sotctl);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manganh);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.phai);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mact);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.mssv);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ThongTinCaNhanSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinCaNhanSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Label label1;
        private Label manganh;
        private Label ngaysinh;
        private Label phai;
        private Label label13;
        private Label label11;
        private Label label5;
        private Label mact;
        private Label hoten;
        private Label label9;
        private Label label3;
        private Label sdt;
        private Label mssv;
        private Button button1;
        private Label label15;
        private Label diachi;
        private Label label17;
        private Label label18;
        private Label sotctl;
        private Label dtbtl;
        private Button button2;
    }
}