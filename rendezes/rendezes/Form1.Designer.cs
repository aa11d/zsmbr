﻿namespace rendezes
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
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            KozvCsere = new Button();
            MinKiv = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(52, 112);
            button1.Name = "button1";
            button1.Size = new Size(48, 23);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(106, 112);
            button2.Name = "button2";
            button2.Size = new Size(48, 23);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(160, 112);
            button3.Name = "button3";
            button3.Size = new Size(48, 23);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(214, 112);
            button4.Name = "button4";
            button4.Size = new Size(48, 23);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(268, 112);
            button5.Name = "button5";
            button5.Size = new Size(48, 23);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(322, 112);
            button6.Name = "button6";
            button6.Size = new Size(48, 23);
            button6.TabIndex = 4;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(376, 112);
            button7.Name = "button7";
            button7.Size = new Size(48, 23);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(430, 112);
            button8.Name = "button8";
            button8.Size = new Size(48, 23);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(484, 112);
            button9.Name = "button9";
            button9.Size = new Size(48, 23);
            button9.TabIndex = 7;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(538, 112);
            button10.Name = "button10";
            button10.Size = new Size(48, 23);
            button10.TabIndex = 12;
            button10.Text = "10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(592, 112);
            button11.Name = "button11";
            button11.Size = new Size(48, 23);
            button11.TabIndex = 11;
            button11.Text = "11";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(646, 112);
            button12.Name = "button12";
            button12.Size = new Size(48, 23);
            button12.TabIndex = 10;
            button12.Text = "12";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(214, 234);
            button13.Name = "button13";
            button13.Size = new Size(156, 55);
            button13.TabIndex = 13;
            button13.Text = "Feltölt";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(376, 234);
            button14.Name = "button14";
            button14.Size = new Size(156, 55);
            button14.TabIndex = 14;
            button14.Text = "Ide-oda sort";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // KozvCsere
            // 
            KozvCsere.Location = new Point(52, 234);
            KozvCsere.Name = "KozvCsere";
            KozvCsere.Size = new Size(156, 55);
            KozvCsere.TabIndex = 15;
            KozvCsere.Text = "Közvetlen Csere";
            KozvCsere.UseVisualStyleBackColor = true;
            KozvCsere.Click += KozvCsere_Click;
            // 
            // MinKiv
            // 
            MinKiv.Location = new Point(538, 234);
            MinKiv.Name = "MinKiv";
            MinKiv.Size = new Size(156, 52);
            MinKiv.TabIndex = 16;
            MinKiv.Text = "Minimum-kiválasztás";
            MinKiv.UseVisualStyleBackColor = true;
            MinKiv.Click += MinKiv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MinKiv);
            Controls.Add(KozvCsere);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
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
        private Button button12;
        private Button button13;
        private Button button14;
        private Button KozvCsere;
        private Button MinKiv;
    }
}
