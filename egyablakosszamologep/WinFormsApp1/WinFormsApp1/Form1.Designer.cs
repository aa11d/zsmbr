﻿namespace WinFormsApp1
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            textBox1 = new TextBox();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            listBox1 = new ListBox();
            button16 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button1.Location = new Point(29, 118);
            button1.Name = "button1";
            button1.Size = new Size(65, 65);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SzamKatt;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button2.Location = new Point(116, 118);
            button2.Name = "button2";
            button2.Size = new Size(65, 65);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SzamKatt;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button3.Location = new Point(202, 118);
            button3.Name = "button3";
            button3.Size = new Size(65, 65);
            button3.TabIndex = 2;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += SzamKatt;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button4.Location = new Point(29, 201);
            button4.Name = "button4";
            button4.Size = new Size(65, 65);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += SzamKatt;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button5.Location = new Point(116, 201);
            button5.Name = "button5";
            button5.Size = new Size(65, 65);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += SzamKatt;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button6.Location = new Point(202, 201);
            button6.Name = "button6";
            button6.Size = new Size(65, 65);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += SzamKatt;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button7.Location = new Point(29, 280);
            button7.Name = "button7";
            button7.Size = new Size(65, 61);
            button7.TabIndex = 6;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += SzamKatt;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button8.Location = new Point(116, 280);
            button8.Name = "button8";
            button8.Size = new Size(65, 61);
            button8.TabIndex = 7;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += SzamKatt;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button9.Location = new Point(202, 280);
            button9.Name = "button9";
            button9.Size = new Size(65, 61);
            button9.TabIndex = 8;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = true;
            button9.Click += SzamKatt;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button10.Location = new Point(29, 360);
            button10.Name = "button10";
            button10.Size = new Size(152, 56);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += SzamKatt;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button11.Location = new Point(202, 360);
            button11.Name = "button11";
            button11.Size = new Size(65, 56);
            button11.TabIndex = 10;
            button11.Text = "Del";
            button11.UseVisualStyleBackColor = true;
            button11.Click += DelKatt;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBox1.Location = new Point(29, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 33);
            textBox1.TabIndex = 11;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button12.Location = new Point(292, 108);
            button12.Name = "button12";
            button12.Size = new Size(85, 82);
            button12.TabIndex = 12;
            button12.Text = "+";
            button12.UseVisualStyleBackColor = true;
            button12.Click += MuvKatt;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button13.Location = new Point(401, 108);
            button13.Name = "button13";
            button13.Size = new Size(85, 82);
            button13.TabIndex = 13;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = true;
            button13.Click += MuvKatt;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button14.Location = new Point(292, 210);
            button14.Name = "button14";
            button14.Size = new Size(85, 84);
            button14.TabIndex = 14;
            button14.Text = "*";
            button14.UseVisualStyleBackColor = true;
            button14.Click += MuvKatt;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button15.Location = new Point(401, 210);
            button15.Name = "button15";
            button15.Size = new Size(85, 84);
            button15.TabIndex = 15;
            button15.Text = "/";
            button15.UseVisualStyleBackColor = true;
            button15.Click += MuvKatt;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(514, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(274, 379);
            listBox1.TabIndex = 16;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button16.Location = new Point(292, 311);
            button16.Name = "button16";
            button16.Size = new Size(194, 84);
            button16.TabIndex = 17;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = true;
            button16.Click += MuvKatt;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button16);
            Controls.Add(listBox1);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(textBox1);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private TextBox textBox1;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private ListBox listBox1;
        private Button button16;
    }
}
