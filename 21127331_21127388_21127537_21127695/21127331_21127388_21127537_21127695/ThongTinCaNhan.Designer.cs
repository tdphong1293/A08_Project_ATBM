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
            this.button1.Location = new System.Drawing.Point(628, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đổi SĐT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // manv
            // 
            this.manv.AutoSize = true;
            this.manv.Location = new System.Drawing.Point(149, 75);
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(81, 20);
            this.manv.TabIndex = 2;
            this.manv.Text = "21127695";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên";
            // 
            // hoten
            // 
            this.hoten.AutoSize = true;
            this.hoten.Location = new System.Drawing.Point(149, 118);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(142, 20);
            this.hoten.TabIndex = 4;
            this.hoten.Text = "Hoàng Trần Thông";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phái";
            // 
            // phai
            // 
            this.phai.AutoSize = true;
            this.phai.Location = new System.Drawing.Point(149, 162);
            this.phai.Name = "phai";
            this.phai.Size = new System.Drawing.Size(42, 20);
            this.phai.TabIndex = 6;
            this.phai.Text = "Nam";
            // 
            // phucap
            // 
            this.phucap.AutoSize = true;
            this.phucap.Location = new System.Drawing.Point(624, 75);
            this.phucap.Name = "phucap";
            this.phucap.Size = new System.Drawing.Size(81, 20);
            this.phucap.TabIndex = 2;
            this.phucap.Text = "21127695";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "SĐT";
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.Location = new System.Drawing.Point(624, 118);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(99, 20);
            this.sdt.TabIndex = 4;
            this.sdt.Text = "0123456789";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(487, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Vai trò";
            // 
            // vaitro
            // 
            this.vaitro.AutoSize = true;
            this.vaitro.Location = new System.Drawing.Point(624, 162);
            this.vaitro.Name = "vaitro";
            this.vaitro.Size = new System.Drawing.Size(40, 20);
            this.vaitro.TabIndex = 6;
            this.vaitro.Text = "CLC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Ngày sinh";
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSize = true;
            this.ngaysinh.Location = new System.Drawing.Point(149, 210);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(89, 20);
            this.ngaysinh.TabIndex = 6;
            this.ngaysinh.Text = "01/01/2001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "MANV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phụ cấp";
            // 
            // madv
            // 
            this.madv.AutoSize = true;
            this.madv.Location = new System.Drawing.Point(624, 210);
            this.madv.Name = "madv";
            this.madv.Size = new System.Drawing.Size(40, 20);
            this.madv.TabIndex = 10;
            this.madv.Text = "CLC";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(487, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "MADV";
            // 
            // ThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 250);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThongTinCaNhan";
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