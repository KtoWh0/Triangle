﻿namespace Triangle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(173, 406);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(177, 71);
            button1.TabIndex = 0;
            button1.Text = "Опрелить тип треугольника";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(351, 249);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 34);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(351, 169);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 34);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(351, 330);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(136, 34);
            textBox3.TabIndex = 3;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 172);
            label1.Name = "label1";
            label1.Size = new Size(285, 20);
            label1.TabIndex = 4;
            label1.Text = "Введите длину 1 стороны";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(82, 65);
            label2.Name = "label2";
            label2.Size = new Size(386, 20);
            label2.TabIndex = 5;
            label2.Text = "Определение типа треугольника";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 252);
            label3.Name = "label3";
            label3.Size = new Size(285, 20);
            label3.TabIndex = 6;
            label3.Text = "Введите длину 2 стороны";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 333);
            label4.Name = "label4";
            label4.Size = new Size(285, 20);
            label4.TabIndex = 7;
            label4.Text = "Введите длину 3 стороны";
            // 
            // TraingleType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(538, 510);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "TraingleType";
            Text = "TraingleType";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}