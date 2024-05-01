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
    partial class ThongTinCaNhan
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
            this.button1 = new System.Windows.Forms.Button();
            this.manv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phai = new System.Windows.Forms.Label();
            this.phucap = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.vaitro = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ngaysinh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.madv = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đổi SĐT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // manv
            // 
            this.manv.AutoSize = true;
            this.manv.Location = new System.Drawing.Point(99, 49);
            this.manv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(55, 13);
            this.manv.TabIndex = 2;
            this.manv.Text = "21127695";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên";
            // 
            // hoten
            // 
            this.hoten.AutoSize = true;
            this.hoten.Location = new System.Drawing.Point(99, 77);
            this.hoten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(98, 13);
            this.hoten.TabIndex = 4;
            this.hoten.Text = "Hoàng Trần Thông";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phái";
            // 
            // phai
            // 
            this.phai.AutoSize = true;
            this.phai.Location = new System.Drawing.Point(99, 105);
            this.phai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phai.Name = "phai";
            this.phai.Size = new System.Drawing.Size(29, 13);
            this.phai.TabIndex = 6;
            this.phai.Text = "Nam";
            // 
            // phucap
            // 
            this.phucap.AutoSize = true;
            this.phucap.Location = new System.Drawing.Point(416, 49);
            this.phucap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phucap.Name = "phucap";
            this.phucap.Size = new System.Drawing.Size(55, 13);
            this.phucap.TabIndex = 2;
            this.phucap.Text = "21127695";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "SĐT";
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.Location = new System.Drawing.Point(416, 77);
            this.sdt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(67, 13);
            this.sdt.TabIndex = 4;
            this.sdt.Text = "0123456789";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 105);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Vai trò";
            // 
            // vaitro
            // 
            this.vaitro.AutoSize = true;
            this.vaitro.Location = new System.Drawing.Point(416, 105);
            this.vaitro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vaitro.Name = "vaitro";
            this.vaitro.Size = new System.Drawing.Size(27, 13);
            this.vaitro.TabIndex = 6;
            this.vaitro.Text = "CLC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 136);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Ngày sinh";
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSize = true;
            this.ngaysinh.Location = new System.Drawing.Point(99, 136);
            this.ngaysinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(65, 13);
            this.ngaysinh.TabIndex = 6;
            this.ngaysinh.Text = "01/01/2001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MANV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phụ cấp";
            // 
            // madv
            // 
            this.madv.AutoSize = true;
            this.madv.Location = new System.Drawing.Point(416, 136);
            this.madv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.madv.Name = "madv";
            this.madv.Size = new System.Drawing.Size(27, 13);
            this.madv.TabIndex = 10;
            this.madv.Text = "CLC";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(325, 136);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "MADV";
            // 
            // ThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 162);
            this.Controls.Add(this.madv);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vaitro);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.phai);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phucap);
            this.Controls.Add(this.manv);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ThongTinCaNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinCaNhan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label manv;
        private Label label3;
        private Label hoten;
        private Label label5;
        private Label phai;
        private Label phucap;
        private Label label9;
        private Label sdt;
        private Label label11;
        private Label vaitro;
        private Label label13;
        private Label ngaysinh;
        private Label label1;
        private Label label7;
        private Label madv;
        private Label label16;
    }
}