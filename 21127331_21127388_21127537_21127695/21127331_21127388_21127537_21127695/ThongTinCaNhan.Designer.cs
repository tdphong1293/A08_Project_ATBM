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
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label1 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(699, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Đổi SĐT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 84);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 2;
            label2.Text = "21127695";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 138);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 3;
            label3.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 138);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 4;
            label4.Text = "Hoàng Trần Thông";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 193);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 5;
            label5.Text = "Phái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(160, 193);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 6;
            label6.Text = "Nam";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(688, 84);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 2;
            label8.Text = "21127695";
            label8.Click += label2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(536, 138);
            label9.Name = "label9";
            label9.Size = new Size(44, 25);
            label9.TabIndex = 3;
            label9.Text = "SĐT";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(688, 138);
            label10.Name = "label10";
            label10.Size = new Size(112, 25);
            label10.TabIndex = 4;
            label10.Text = "0123456789";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(536, 193);
            label11.Name = "label11";
            label11.Size = new Size(64, 25);
            label11.TabIndex = 5;
            label11.Text = "MADV";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(688, 193);
            label12.Name = "label12";
            label12.Size = new Size(41, 25);
            label12.TabIndex = 6;
            label12.Text = "CLC";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 252);
            label13.Name = "label13";
            label13.Size = new Size(91, 25);
            label13.TabIndex = 5;
            label13.Text = "Ngày sinh";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(160, 252);
            label14.Name = "label14";
            label14.Size = new Size(106, 25);
            label14.TabIndex = 6;
            label14.Text = "01/01/2001";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 84);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 7;
            label1.Text = "MSSV";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(536, 84);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 8;
            label7.Text = "Phụ cấp";
            // 
            // ThongTinCaNhan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 312);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label6);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "ThongTinCaNhan";
            Text = "ThongTinCaNhan";
            Load += ThongTinCaNhan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label1;
        private Label label7;
    }
}