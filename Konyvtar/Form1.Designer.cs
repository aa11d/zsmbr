﻿namespace Konyvtar
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
            KKev = new TextBox();
            KKname = new TextBox();
            KKszer = new TextBox();
            KKazon = new TextBox();
            KKkiadas = new Label();
            KKCim = new Label();
            KKSzerzo = new Label();
            KKAzonosito = new Label();
            KKTorol = new Button();
            KKFelvesz = new Button();
            KKujkonyv = new Button();
            KKModosit = new Button();
            KKSzerkeszt = new Button();
            KKListbox = new ListBox();
            tabPage2 = new TabPage();
            OOEletkor = new TextBox();
            OOCim = new TextBox();
            OONev = new TextBox();
            OOAzonsito = new TextBox();
            OOTorles = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            OOFelvesz = new Button();
            OOUjOlv = new Button();
            OOModosit = new Button();
            OOSzerk = new Button();
            OOListBox = new ListBox();
            tabPage3 = new TabPage();
            kzkHosszabbit = new Button();
            kzkVisszavetel = new Button();
            kzkMettol = new TextBox();
            kzkMeddig = new TextBox();
            kzkOlvnev = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            kzkKolcsonzesek = new ComboBox();
            kzklistBox = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 451);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(KKev);
            tabPage1.Controls.Add(KKname);
            tabPage1.Controls.Add(KKszer);
            tabPage1.Controls.Add(KKazon);
            tabPage1.Controls.Add(KKkiadas);
            tabPage1.Controls.Add(KKCim);
            tabPage1.Controls.Add(KKSzerzo);
            tabPage1.Controls.Add(KKAzonosito);
            tabPage1.Controls.Add(KKTorol);
            tabPage1.Controls.Add(KKFelvesz);
            tabPage1.Controls.Add(KKujkonyv);
            tabPage1.Controls.Add(KKModosit);
            tabPage1.Controls.Add(KKSzerkeszt);
            tabPage1.Controls.Add(KKListbox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Könyvek";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // KKev
            // 
            KKev.Location = new Point(646, 368);
            KKev.Name = "KKev";
            KKev.Size = new Size(52, 23);
            KKev.TabIndex = 13;
            // 
            // KKname
            // 
            KKname.Location = new Point(320, 368);
            KKname.Name = "KKname";
            KKname.Size = new Size(320, 23);
            KKname.TabIndex = 12;
            // 
            // KKszer
            // 
            KKszer.Location = new Point(95, 368);
            KKszer.Name = "KKszer";
            KKszer.Size = new Size(218, 23);
            KKszer.TabIndex = 11;
            // 
            // KKazon
            // 
            KKazon.Enabled = false;
            KKazon.Location = new Point(8, 368);
            KKazon.Name = "KKazon";
            KKazon.Size = new Size(56, 23);
            KKazon.TabIndex = 10;
            // 
            // KKkiadas
            // 
            KKkiadas.AutoSize = true;
            KKkiadas.Location = new Point(636, 350);
            KKkiadas.Name = "KKkiadas";
            KKkiadas.Size = new Size(62, 15);
            KKkiadas.TabIndex = 9;
            KKkiadas.Text = "Kiadás éve";
            // 
            // KKCim
            // 
            KKCim.AutoSize = true;
            KKCim.Location = new Point(320, 350);
            KKCim.Name = "KKCim";
            KKCim.Size = new Size(29, 15);
            KKCim.TabIndex = 8;
            KKCim.Text = "Cím";
            // 
            // KKSzerzo
            // 
            KKSzerzo.AutoSize = true;
            KKSzerzo.Location = new Point(95, 350);
            KKSzerzo.Name = "KKSzerzo";
            KKSzerzo.Size = new Size(40, 15);
            KKSzerzo.TabIndex = 7;
            KKSzerzo.Text = "Szerző";
            // 
            // KKAzonosito
            // 
            KKAzonosito.AutoSize = true;
            KKAzonosito.Location = new Point(8, 350);
            KKAzonosito.Name = "KKAzonosito";
            KKAzonosito.Size = new Size(60, 15);
            KKAzonosito.TabIndex = 6;
            KKAzonosito.Text = "Azonosító";
            // 
            // KKTorol
            // 
            KKTorol.Enabled = false;
            KKTorol.Location = new Point(709, 235);
            KKTorol.Name = "KKTorol";
            KKTorol.Size = new Size(75, 23);
            KKTorol.TabIndex = 5;
            KKTorol.Text = "Töröl";
            KKTorol.UseVisualStyleBackColor = true;
            KKTorol.Click += KKTorol_Click;
            // 
            // KKFelvesz
            // 
            KKFelvesz.Enabled = false;
            KKFelvesz.Location = new Point(709, 177);
            KKFelvesz.Name = "KKFelvesz";
            KKFelvesz.Size = new Size(75, 23);
            KKFelvesz.TabIndex = 4;
            KKFelvesz.Text = "Felvesz";
            KKFelvesz.UseVisualStyleBackColor = true;
            KKFelvesz.Click += KKFelvesz_Click;
            // 
            // KKujkonyv
            // 
            KKujkonyv.Location = new Point(709, 148);
            KKujkonyv.Name = "KKujkonyv";
            KKujkonyv.Size = new Size(75, 23);
            KKujkonyv.TabIndex = 3;
            KKujkonyv.Text = "ÚjKönyv";
            KKujkonyv.UseVisualStyleBackColor = true;
            KKujkonyv.Click += KKujkonyv_Click;
            // 
            // KKModosit
            // 
            KKModosit.Enabled = false;
            KKModosit.Location = new Point(709, 96);
            KKModosit.Name = "KKModosit";
            KKModosit.Size = new Size(75, 23);
            KKModosit.TabIndex = 2;
            KKModosit.Text = "Módosítás";
            KKModosit.UseVisualStyleBackColor = true;
            KKModosit.Click += KKModosit_Click;
            // 
            // KKSzerkeszt
            // 
            KKSzerkeszt.Enabled = false;
            KKSzerkeszt.Location = new Point(709, 67);
            KKSzerkeszt.Name = "KKSzerkeszt";
            KKSzerkeszt.Size = new Size(75, 23);
            KKSzerkeszt.TabIndex = 1;
            KKSzerkeszt.Text = "Szerkeztés";
            KKSzerkeszt.UseVisualStyleBackColor = true;
            KKSzerkeszt.Click += KKSzerkeszt_Click;
            // 
            // KKListbox
            // 
            KKListbox.FormattingEnabled = true;
            KKListbox.ItemHeight = 15;
            KKListbox.Location = new Point(0, 0);
            KKListbox.Name = "KKListbox";
            KKListbox.Size = new Size(698, 334);
            KKListbox.TabIndex = 0;
            KKListbox.SelectedIndexChanged += KKListbox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(OOEletkor);
            tabPage2.Controls.Add(OOCim);
            tabPage2.Controls.Add(OONev);
            tabPage2.Controls.Add(OOAzonsito);
            tabPage2.Controls.Add(OOTorles);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(OOFelvesz);
            tabPage2.Controls.Add(OOUjOlv);
            tabPage2.Controls.Add(OOModosit);
            tabPage2.Controls.Add(OOSzerk);
            tabPage2.Controls.Add(OOListBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Olvasók";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // OOEletkor
            // 
            OOEletkor.Location = new Point(688, 373);
            OOEletkor.Name = "OOEletkor";
            OOEletkor.Size = new Size(100, 23);
            OOEletkor.TabIndex = 13;
            // 
            // OOCim
            // 
            OOCim.Location = new Point(430, 373);
            OOCim.Name = "OOCim";
            OOCim.Size = new Size(246, 23);
            OOCim.TabIndex = 12;
            // 
            // OONev
            // 
            OONev.Location = new Point(81, 373);
            OONev.Name = "OONev";
            OONev.Size = new Size(337, 23);
            OONev.TabIndex = 11;
            // 
            // OOAzonsito
            // 
            OOAzonsito.Enabled = false;
            OOAzonsito.Location = new Point(8, 373);
            OOAzonsito.Name = "OOAzonsito";
            OOAzonsito.Size = new Size(47, 23);
            OOAzonsito.TabIndex = 10;
            // 
            // OOTorles
            // 
            OOTorles.Enabled = false;
            OOTorles.Location = new Point(698, 237);
            OOTorles.Name = "OOTorles";
            OOTorles.Size = new Size(75, 23);
            OOTorles.TabIndex = 9;
            OOTorles.Text = "Törlés";
            OOTorles.UseVisualStyleBackColor = true;
            OOTorles.Click += OOTorles_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(688, 346);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "Életkor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 346);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 7;
            label3.Text = "Cím";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 346);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 6;
            label2.Text = "Név";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 346);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Azonosító";
            // 
            // OOFelvesz
            // 
            OOFelvesz.Enabled = false;
            OOFelvesz.Location = new Point(698, 151);
            OOFelvesz.Name = "OOFelvesz";
            OOFelvesz.Size = new Size(75, 23);
            OOFelvesz.TabIndex = 4;
            OOFelvesz.Text = "Felvesz";
            OOFelvesz.UseVisualStyleBackColor = true;
            OOFelvesz.Click += OOFelvesz_Click;
            // 
            // OOUjOlv
            // 
            OOUjOlv.Location = new Point(698, 122);
            OOUjOlv.Name = "OOUjOlv";
            OOUjOlv.Size = new Size(75, 23);
            OOUjOlv.TabIndex = 3;
            OOUjOlv.Text = "Új olvasó";
            OOUjOlv.UseVisualStyleBackColor = true;
            OOUjOlv.Click += OOUjOlv_Click;
            // 
            // OOModosit
            // 
            OOModosit.Enabled = false;
            OOModosit.Location = new Point(698, 62);
            OOModosit.Name = "OOModosit";
            OOModosit.Size = new Size(75, 23);
            OOModosit.TabIndex = 2;
            OOModosit.Text = "Módosítás";
            OOModosit.UseVisualStyleBackColor = true;
            OOModosit.Click += OOModosit_Click;
            // 
            // OOSzerk
            // 
            OOSzerk.Enabled = false;
            OOSzerk.Location = new Point(698, 33);
            OOSzerk.Name = "OOSzerk";
            OOSzerk.Size = new Size(75, 23);
            OOSzerk.TabIndex = 1;
            OOSzerk.Text = "Szerkeztés";
            OOSzerk.UseVisualStyleBackColor = true;
            OOSzerk.Click += OOSzerk_Click;
            // 
            // OOListBox
            // 
            OOListBox.FormattingEnabled = true;
            OOListBox.ItemHeight = 15;
            OOListBox.Location = new Point(0, 0);
            OOListBox.Name = "OOListBox";
            OOListBox.Size = new Size(676, 334);
            OOListBox.TabIndex = 0;
            OOListBox.SelectedIndexChanged += OOListBox_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(kzkHosszabbit);
            tabPage3.Controls.Add(kzkVisszavetel);
            tabPage3.Controls.Add(kzkMettol);
            tabPage3.Controls.Add(kzkMeddig);
            tabPage3.Controls.Add(kzkOlvnev);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(kzkKolcsonzesek);
            tabPage3.Controls.Add(kzklistBox);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(794, 423);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kölcsönzés";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // kzkHosszabbit
            // 
            kzkHosszabbit.Location = new Point(633, 142);
            kzkHosszabbit.Name = "kzkHosszabbit";
            kzkHosszabbit.Size = new Size(151, 52);
            kzkHosszabbit.TabIndex = 9;
            kzkHosszabbit.Text = "Meghosszabbítás";
            kzkHosszabbit.UseVisualStyleBackColor = true;
            kzkHosszabbit.Click += kzkHosszabbit_Click;
            // 
            // kzkVisszavetel
            // 
            kzkVisszavetel.Location = new Point(476, 142);
            kzkVisszavetel.Name = "kzkVisszavetel";
            kzkVisszavetel.Size = new Size(151, 52);
            kzkVisszavetel.TabIndex = 8;
            kzkVisszavetel.Text = "Visszavétel";
            kzkVisszavetel.UseVisualStyleBackColor = true;
            kzkVisszavetel.Click += kzkVisszavetel_Click;
            // 
            // kzkMettol
            // 
            kzkMettol.Location = new Point(582, 100);
            kzkMettol.Name = "kzkMettol";
            kzkMettol.Size = new Size(83, 23);
            kzkMettol.TabIndex = 7;
            // 
            // kzkMeddig
            // 
            kzkMeddig.Location = new Point(671, 99);
            kzkMeddig.Name = "kzkMeddig";
            kzkMeddig.Size = new Size(113, 23);
            kzkMeddig.TabIndex = 6;
            // 
            // kzkOlvnev
            // 
            kzkOlvnev.Location = new Point(476, 100);
            kzkOlvnev.Name = "kzkOlvnev";
            kzkOlvnev.Size = new Size(100, 23);
            kzkOlvnev.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(671, 81);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 4;
            label7.Text = "Meddig:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(582, 81);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 3;
            label6.Text = "Mettől:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(476, 82);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 2;
            label5.Text = "Kölcsönzője:";
            // 
            // kzkKolcsonzesek
            // 
            kzkKolcsonzesek.FormattingEnabled = true;
            kzkKolcsonzesek.Location = new Point(476, 40);
            kzkKolcsonzesek.Name = "kzkKolcsonzesek";
            kzkKolcsonzesek.Size = new Size(308, 23);
            kzkKolcsonzesek.TabIndex = 1;
            kzkKolcsonzesek.SelectedIndexChanged += kzkKolcsonzesek_SelectedIndexChanged;
            kzkKolcsonzesek.Enter += kzkKolcsonzesek_Enter;
            // 
            // kzklistBox
            // 
            kzklistBox.FormattingEnabled = true;
            kzklistBox.ItemHeight = 15;
            kzklistBox.Location = new Point(8, 7);
            kzklistBox.Name = "kzklistBox";
            kzklistBox.Size = new Size(462, 259);
            kzklistBox.TabIndex = 0;
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
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox KKListbox;
        private TabPage tabPage3;
        private Button KKFelvesz;
        private Button KKujkonyv;
        private Button KKModosit;
        private Button KKSzerkeszt;
        private Button KKTorol;
        private Label KKkiadas;
        private Label KKCim;
        private Label KKSzerzo;
        private Label KKAzonosito;
        private TextBox KKev;
        private TextBox KKname;
        private TextBox KKszer;
        private TextBox KKazon;
        private Label label1;
        private Button OOFelvesz;
        private Button OOUjOlv;
        private Button OOModosit;
        private Button OOSzerk;
        private ListBox OOListBox;
        private TextBox OOEletkor;
        private TextBox OOCim;
        private TextBox OONev;
        private TextBox OOAzonsito;
        private Button OOTorles;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox kzklistBox;
        private ComboBox kzkKolcsonzesek;
        private Label label5;
        private TextBox kzkMettol;
        private TextBox kzkMeddig;
        private TextBox kzkOlvnev;
        private Label label7;
        private Label label6;
        private Button kzkHosszabbit;
        private Button kzkVisszavetel;
    }
}
