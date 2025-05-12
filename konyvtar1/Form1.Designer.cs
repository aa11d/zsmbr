namespace konyvtar1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Kkkiad = new TextBox();
            Kkcim = new TextBox();
            Kkszerzo = new TextBox();
            Kkazon = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Kktorol = new Button();
            Kkfelvesz = new Button();
            Kkuj = new Button();
            Kkmodosit = new Button();
            Kkszerkeszt = new Button();
            Kklistbox = new ListBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(804, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Kkkiad);
            tabPage1.Controls.Add(Kkcim);
            tabPage1.Controls.Add(Kkszerzo);
            tabPage1.Controls.Add(Kkazon);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(Kktorol);
            tabPage1.Controls.Add(Kkfelvesz);
            tabPage1.Controls.Add(Kkuj);
            tabPage1.Controls.Add(Kkmodosit);
            tabPage1.Controls.Add(Kkszerkeszt);
            tabPage1.Controls.Add(Kklistbox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(796, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Könyvek";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Kkkiad
            // 
            Kkkiad.Location = new Point(617, 385);
            Kkkiad.Name = "Kkkiad";
            Kkkiad.Size = new Size(100, 23);
            Kkkiad.TabIndex = 13;
            // 
            // Kkcim
            // 
            Kkcim.Location = new Point(314, 385);
            Kkcim.Name = "Kkcim";
            Kkcim.Size = new Size(297, 23);
            Kkcim.TabIndex = 12;
            // 
            // Kkszerzo
            // 
            Kkszerzo.Location = new Point(142, 385);
            Kkszerzo.Name = "Kkszerzo";
            Kkszerzo.Size = new Size(166, 23);
            Kkszerzo.TabIndex = 11;
            // 
            // Kkazon
            // 
            Kkazon.Enabled = false;
            Kkazon.Location = new Point(55, 385);
            Kkazon.Name = "Kkazon";
            Kkazon.Size = new Size(81, 23);
            Kkazon.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(634, 367);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Kiadás éve";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 367);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 8;
            label3.Text = "Cím";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 367);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Szerző";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 367);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "Azonosító";
            // 
            // Kktorol
            // 
            Kktorol.Enabled = false;
            Kktorol.Location = new Point(711, 252);
            Kktorol.Name = "Kktorol";
            Kktorol.Size = new Size(75, 23);
            Kktorol.TabIndex = 5;
            Kktorol.Text = "Töröl";
            Kktorol.UseVisualStyleBackColor = true;
            // 
            // Kkfelvesz
            // 
            Kkfelvesz.Enabled = false;
            Kkfelvesz.Location = new Point(711, 207);
            Kkfelvesz.Name = "Kkfelvesz";
            Kkfelvesz.Size = new Size(75, 23);
            Kkfelvesz.TabIndex = 4;
            Kkfelvesz.Text = "Felvesz";
            Kkfelvesz.UseVisualStyleBackColor = true;
            Kkfelvesz.Click += Kkfelvesz_Click;
            // 
            // Kkuj
            // 
            Kkuj.Location = new Point(711, 178);
            Kkuj.Name = "Kkuj";
            Kkuj.Size = new Size(75, 23);
            Kkuj.TabIndex = 3;
            Kkuj.Text = "Új Könyv";
            Kkuj.UseVisualStyleBackColor = true;
            Kkuj.Click += Kkuj_Click;
            // 
            // Kkmodosit
            // 
            Kkmodosit.Enabled = false;
            Kkmodosit.Location = new Point(711, 104);
            Kkmodosit.Name = "Kkmodosit";
            Kkmodosit.Size = new Size(75, 23);
            Kkmodosit.TabIndex = 2;
            Kkmodosit.Text = "Módosít";
            Kkmodosit.UseVisualStyleBackColor = true;
            // 
            // Kkszerkeszt
            // 
            Kkszerkeszt.Enabled = false;
            Kkszerkeszt.Location = new Point(711, 75);
            Kkszerkeszt.Name = "Kkszerkeszt";
            Kkszerkeszt.Size = new Size(75, 23);
            Kkszerkeszt.TabIndex = 1;
            Kkszerkeszt.Text = "Szerkesztés";
            Kkszerkeszt.UseVisualStyleBackColor = true;
            // 
            // Kklistbox
            // 
            Kklistbox.FormattingEnabled = true;
            Kklistbox.ItemHeight = 15;
            Kklistbox.Location = new Point(-4, 0);
            Kklistbox.Name = "Kklistbox";
            Kklistbox.Size = new Size(700, 364);
            Kklistbox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(796, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Olvasók";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(796, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kölcsönzés";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button Kkmodosit;
        private Button Kkszerkeszt;
        private ListBox Kklistbox;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button Kktorol;
        private Button Kkfelvesz;
        private Button Kkuj;
        private TextBox Kkkiad;
        private TextBox Kkcim;
        private TextBox Kkszerzo;
        private TextBox Kkazon;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
