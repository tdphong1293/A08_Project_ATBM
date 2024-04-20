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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            label5 = new Label();
            textBox3 = new TextBox();
            tabPage4 = new TabPage();
            label8 = new Label();
            comboBox3 = new ComboBox();
            label9 = new Label();
            comboBox4 = new ComboBox();
            dataGridView4 = new DataGridView();
            label10 = new Label();
            textBox4 = new TextBox();
            tabPage6 = new TabPage();
            button13 = new Button();
            button12 = new Button();
            dataGridView7 = new DataGridView();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 53);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Hello!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(77, 13);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 1;
            label2.Text = "Hoang Tran Thong";
            // 
            // button1
            // 
            button1.Location = new Point(1008, 8);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(1, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1133, 616);
            tabControl1.TabIndex = 7;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1125, 578);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "HỌC PHẦN";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 58);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(1125, 516);
            dataGridView3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 11);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 8;
            label5.Text = "Học phần";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 11);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 7;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(comboBox3);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(comboBox4);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(textBox4);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1125, 578);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "KẾ HOẠCH MỞ";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(575, 43);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 20;
            label8.Text = "Năm học";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(665, 40);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(182, 33);
            comboBox3.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(281, 43);
            label9.Name = "label9";
            label9.Size = new Size(62, 25);
            label9.TabIndex = 18;
            label9.Text = "Học kì";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(349, 40);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(182, 33);
            comboBox4.TabIndex = 17;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(-4, 118);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.Size = new Size(1129, 454);
            dataGridView4.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 43);
            label10.Name = "label10";
            label10.Size = new Size(65, 25);
            label10.TabIndex = 15;
            label10.Text = "Mã HP";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(88, 40);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 14;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(button13);
            tabPage6.Controls.Add(button12);
            tabPage6.Controls.Add(dataGridView7);
            tabPage6.Location = new Point(4, 34);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1125, 578);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "ĐĂNG KÝ";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.ForeColor = Color.Coral;
            button13.Location = new Point(900, 66);
            button13.Name = "button13";
            button13.Size = new Size(222, 34);
            button13.TabIndex = 40;
            button13.Text = "Xóa ĐĂNG KÝ";
            button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(900, 15);
            button12.Name = "button12";
            button12.Size = new Size(222, 34);
            button12.TabIndex = 40;
            button12.Text = "Thêm ĐĂNG KÝ";
            button12.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            dataGridView7.AllowUserToDeleteRows = false;
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(-2, 118);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 62;
            dataGridView7.Size = new Size(1129, 454);
            dataGridView7.TabIndex = 35;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1125, 578);
            tabPage1.TabIndex = 6;
            tabPage1.Text = "KẾT QUẢ HỌC PHẦN";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1125, 516);
            dataGridView1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 11;
            label3.Text = "Học kì";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(72, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 13;
            // 
            // SinhVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 670);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "SinhVien";
            Text = "SinhVien";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private Label label5;
        private TextBox textBox3;
        private TabPage tabPage4;
        private Label label8;
        private ComboBox comboBox3;
        private Label label9;
        private ComboBox comboBox4;
        private DataGridView dataGridView4;
        private Label label10;
        private TextBox textBox4;
        private TabPage tabPage6;
        private Button button13;
        private Button button12;
        private DataGridView dataGridView7;
        private TabPage tabPage1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label label3;
    }
}