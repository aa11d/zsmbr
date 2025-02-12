namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            utobal = new PictureBox();
            utojobb = new PictureBox();
            szamlalo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)utobal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)utojobb).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(352, 214);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // utobal
            // 
            utobal.Image = (Image)resources.GetObject("utobal.Image");
            utobal.Location = new Point(12, 141);
            utobal.Name = "utobal";
            utobal.Size = new Size(14, 179);
            utobal.SizeMode = PictureBoxSizeMode.CenterImage;
            utobal.TabIndex = 1;
            utobal.TabStop = false;
            // 
            // utojobb
            // 
            utojobb.Image = (Image)resources.GetObject("utojobb.Image");
            utojobb.Location = new Point(773, 141);
            utojobb.Name = "utojobb";
            utojobb.Size = new Size(15, 179);
            utojobb.SizeMode = PictureBoxSizeMode.CenterImage;
            utojobb.TabIndex = 2;
            utojobb.TabStop = false;
            // 
            // szamlalo
            // 
            szamlalo.AutoSize = true;
            szamlalo.Font = new Font("Segoe UI", 14F);
            szamlalo.Location = new Point(352, 9);
            szamlalo.Name = "szamlalo";
            szamlalo.Size = new Size(36, 25);
            szamlalo.TabIndex = 3;
            szamlalo.Text = "0:0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(szamlalo);
            Controls.Add(utojobb);
            Controls.Add(utobal);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            PreviewKeyDown += Form1_PreviewKeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)utobal).EndInit();
            ((System.ComponentModel.ISupportInitialize)utojobb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox utobal;
        private PictureBox utojobb;
        private Label szamlalo;
    }
}
