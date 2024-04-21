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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            button4 = new Button();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            textBox2 = new TextBox();
            tabPage3 = new TabPage();
            button6 = new Button();
            button7 = new Button();
            dataGridView3 = new DataGridView();
            label5 = new Label();
            textBox3 = new TextBox();
            tabPage4 = new TabPage();
            button8 = new Button();
            button9 = new Button();
            label8 = new Label();
            comboBox3 = new ComboBox();
            label9 = new Label();
            comboBox4 = new ComboBox();
            dataGridView4 = new DataGridView();
            label10 = new Label();
            textBox4 = new TextBox();
            tabPage5 = new TabPage();
            button11 = new Button();
            button10 = new Button();
            label16 = new Label();
            label6 = new Label();
            comboBox6 = new ComboBox();
            comboBox1 = new ComboBox();
            label15 = new Label();
            label7 = new Label();
            comboBox5 = new ComboBox();
            comboBox2 = new ComboBox();
            dataGridView6 = new DataGridView();
            dataGridView5 = new DataGridView();
            label14 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox8 = new TextBox();
            label11 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            tabPage6 = new TabPage();
            button13 = new Button();
            button12 = new Button();
            label17 = new Label();
            comboBox7 = new ComboBox();
            label18 = new Label();
            comboBox8 = new ComboBox();
            dataGridView7 = new DataGridView();
            label19 = new Label();
            label21 = new Label();
            label20 = new Label();
            textBox9 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
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
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(0, 47);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1133, 616);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1125, 578);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "SINH VIÊN";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(826, 6);
            button3.Name = "button3";
            button3.Size = new Size(130, 34);
            button3.TabIndex = 4;
            button3.Text = "Cập nhật SV";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(984, 6);
            button2.Name = "button2";
            button2.Size = new Size(130, 34);
            button2.TabIndex = 4;
            button2.Text = "Thêm SV";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-6, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1131, 513);
            dataGridView1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 12);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "MSSV";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1125, 578);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ĐƠN VỊ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(768, 6);
            button4.Name = "button4";
            button4.Size = new Size(154, 34);
            button4.TabIndex = 7;
            button4.Text = "Cập nhật Đơn vị";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(945, 6);
            button5.Name = "button5";
            button5.Size = new Size(171, 34);
            button5.TabIndex = 8;
            button5.Text = "Thêm Đơn vị";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(-4, 62);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1129, 513);
            dataGridView2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 9);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 5;
            label4.Text = "Tên Đơn vị";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 4;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(button7);
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
            // button6
            // 
            button6.Location = new Point(746, 8);
            button6.Name = "button6";
            button6.Size = new Size(171, 34);
            button6.TabIndex = 10;
            button6.Text = "Cập nhật HP";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(947, 8);
            button7.Name = "button7";
            button7.Size = new Size(171, 34);
            button7.TabIndex = 11;
            button7.Text = "Thêm HP";
            button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 60);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(1119, 514);
            dataGridView3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 11);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 8;
            label5.Text = "Mã HP";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 8);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 7;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button8);
            tabPage4.Controls.Add(button9);
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
            // button8
            // 
            button8.Location = new Point(945, 9);
            button8.Name = "button8";
            button8.Size = new Size(171, 34);
            button8.TabIndex = 21;
            button8.Text = "Cập nhật KHMO";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(945, 64);
            button9.Name = "button9";
            button9.Size = new Size(171, 34);
            button9.TabIndex = 22;
            button9.Text = "Thêm KHMO";
            button9.UseVisualStyleBackColor = true;
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
            // tabPage5
            // 
            tabPage5.Controls.Add(button11);
            tabPage5.Controls.Add(button10);
            tabPage5.Controls.Add(label16);
            tabPage5.Controls.Add(label6);
            tabPage5.Controls.Add(comboBox6);
            tabPage5.Controls.Add(comboBox1);
            tabPage5.Controls.Add(label15);
            tabPage5.Controls.Add(label7);
            tabPage5.Controls.Add(comboBox5);
            tabPage5.Controls.Add(comboBox2);
            tabPage5.Controls.Add(dataGridView6);
            tabPage5.Controls.Add(dataGridView5);
            tabPage5.Controls.Add(label14);
            tabPage5.Controls.Add(label12);
            tabPage5.Controls.Add(label13);
            tabPage5.Controls.Add(textBox8);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(textBox7);
            tabPage5.Controls.Add(textBox6);
            tabPage5.Controls.Add(textBox5);
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1125, 578);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "PHÂN CÔNG";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(897, 6);
            button11.Name = "button11";
            button11.Size = new Size(222, 34);
            button11.TabIndex = 30;
            button11.Text = "Chỉnh sửa PHÂN CÔNG";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(897, 6);
            button10.Name = "button10";
            button10.Size = new Size(222, 34);
            button10.TabIndex = 30;
            button10.Text = "Chỉnh sửa PHÂN CÔNG";
            button10.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(313, 66);
            label16.Name = "label16";
            label16.Size = new Size(84, 25);
            label16.TabIndex = 29;
            label16.Text = "Năm học";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(313, 66);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 29;
            label6.Text = "Năm học";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(403, 64);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(182, 33);
            comboBox6.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(403, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 66);
            label15.Name = "label15";
            label15.Size = new Size(62, 25);
            label15.TabIndex = 27;
            label15.Text = "Học kì";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 66);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 27;
            label7.Text = "Học kì";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(86, 63);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(182, 33);
            comboBox5.TabIndex = 26;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(86, 63);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 26;
            // 
            // dataGridView6
            // 
            dataGridView6.AllowUserToDeleteRows = false;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(-2, 117);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 62;
            dataGridView6.Size = new Size(1129, 454);
            dataGridView6.TabIndex = 25;
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToDeleteRows = false;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(-2, 117);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 62;
            dataGridView5.Size = new Size(1129, 454);
            dataGridView5.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(313, 14);
            label14.Name = "label14";
            label14.Size = new Size(65, 25);
            label14.TabIndex = 24;
            label14.Text = "Mã GV";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(313, 14);
            label12.Name = "label12";
            label12.Size = new Size(65, 25);
            label12.TabIndex = 24;
            label12.Text = "Mã GV";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 14);
            label13.Name = "label13";
            label13.Size = new Size(65, 25);
            label13.TabIndex = 24;
            label13.Text = "Mã HP";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(403, 11);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(182, 31);
            textBox8.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 14);
            label11.Name = "label11";
            label11.Size = new Size(65, 25);
            label11.TabIndex = 24;
            label11.Text = "Mã HP";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(86, 11);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(182, 31);
            textBox7.TabIndex = 23;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(403, 11);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(182, 31);
            textBox6.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(86, 11);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(182, 31);
            textBox5.TabIndex = 23;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(button13);
            tabPage6.Controls.Add(button12);
            tabPage6.Controls.Add(label17);
            tabPage6.Controls.Add(comboBox7);
            tabPage6.Controls.Add(label18);
            tabPage6.Controls.Add(comboBox8);
            tabPage6.Controls.Add(dataGridView7);
            tabPage6.Controls.Add(label19);
            tabPage6.Controls.Add(label21);
            tabPage6.Controls.Add(label20);
            tabPage6.Controls.Add(textBox9);
            tabPage6.Controls.Add(textBox11);
            tabPage6.Controls.Add(textBox10);
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
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(313, 67);
            label17.Name = "label17";
            label17.Size = new Size(84, 25);
            label17.TabIndex = 39;
            label17.Text = "Năm học";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(403, 65);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(182, 33);
            comboBox7.TabIndex = 38;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(630, 68);
            label18.Name = "label18";
            label18.Size = new Size(62, 25);
            label18.TabIndex = 37;
            label18.Text = "Học kì";
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(701, 65);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(182, 33);
            comboBox8.TabIndex = 36;
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
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(313, 15);
            label19.Name = "label19";
            label19.Size = new Size(65, 25);
            label19.TabIndex = 33;
            label19.Text = "Mã GV";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(15, 70);
            label21.Name = "label21";
            label21.Size = new Size(65, 25);
            label21.TabIndex = 34;
            label21.Text = "Mã HP";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(15, 15);
            label20.Name = "label20";
            label20.Size = new Size(63, 25);
            label20.TabIndex = 34;
            label20.Text = "Mã SV";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(403, 12);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(182, 31);
            textBox9.TabIndex = 31;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(86, 67);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(182, 31);
            textBox11.TabIndex = 32;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(86, 12);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(182, 31);
            textBox10.TabIndex = 32;
            // 
            // GiaoVu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 659);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "GiaoVu";
            Text = "GiaoVu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private Label label4;
        private TextBox textBox2;
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
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private TabPage tabPage5;
        private Button button10;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private ComboBox comboBox2;
        private DataGridView dataGridView5;
        private Label label11;
        private TextBox textBox5;
        private Label label12;
        private TextBox textBox6;
        private TabPage tabPage6;
        private Button button11;
        private Label label16;
        private ComboBox comboBox6;
        private Label label15;
        private ComboBox comboBox5;
        private DataGridView dataGridView6;
        private Label label14;
        private Label label13;
        private TextBox textBox8;
        private TextBox textBox7;
        private Button button13;
        private Button button12;
        private Label label17;
        private ComboBox comboBox7;
        private Label label18;
        private ComboBox comboBox8;
        private DataGridView dataGridView7;
        private Label label19;
        private Label label21;
        private Label label20;
        private TextBox textBox9;
        private TextBox textBox11;
        private TextBox textBox10;
    }
}