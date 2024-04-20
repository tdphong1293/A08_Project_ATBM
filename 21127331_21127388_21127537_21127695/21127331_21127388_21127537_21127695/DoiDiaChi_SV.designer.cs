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
    partial class DoiDiaChi_SV
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(282, 203);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 31);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 79);
            label2.Name = "label2";
            label2.Size = new Size(271, 25);
            label2.TabIndex = 8;
            label2.Text = "123 Nguyễn Văn Cừ, Q5, TPHCM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 133);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 9;
            label3.Text = "Địa chỉ mới";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 79);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 10;
            label1.Text = "Địa chỉ hiện tại";
            // 
            // DoiDiaChi_SV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 284);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "DoiDiaChi_SV";
            Text = "DoiDiaChi_SV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}