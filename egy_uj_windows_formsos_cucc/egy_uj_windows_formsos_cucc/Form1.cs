using System.ComponentModel;

namespace egy_uj_windows_formsos_cucc
{
    public partial class Form1 : Form
    {
        List<PictureBox> labdak = new List<PictureBox>();
        List<int> labdavX = new List<int>();
        List<int> labdavY = new List<int>();
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (rnd.NextDouble() < 0.004)
            {
                PictureBox labda = new PictureBox();
                int vx = rnd.Next(-5, 6);
                int vy = rnd.Next(2, 6);
                labda.Location = new Point(ClientRectangle.Width / 2, 0);
                labda.Size = new Size(25, 25);
                labda.Image = Image.FromFile(@"..\..\..\lapda3.png");
                labda.SizeMode = PictureBoxSizeMode.StretchImage;
                labdak.Add(labda);
                labdavX.Add(vx);
                labdavY.Add(vy);
                Controls.Add(labda);
            }

            for (int i = 0; i < labdak.Count; i++)
            {
                int newLeft = labdak[i].Left + labdavX[i];
                int newTop = labdak[i].Top + labdavY[i];
                if (newLeft < 0)
                {
                    labdavX[i] *= -1;
                }
                else if (newTop < 0)
                {
                    labdavY[i] *= -1;
                }
                else if (newLeft + labdak[i].Width > ClientRectangle.Width)
                {
                    labdavX[i] *= -1;
                }
                else
                {
                    labdak[i].Top = newTop;
                    labdak[i].Left = newLeft;
                }
            }

            int k = 0;
            while (k < labdavX.Count)
            {
                if (labdak[k].Top > ClientRectangle.Height)
                {
                    Controls.Remove(labdak[k]);
                    labdak.RemoveAt(k);
                    labdavX.RemoveAt(k);
                    labdavY.RemoveAt(k);
                }
                else
                {
                    k++;
                }
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox1.Left > 10) { pictureBox1.Left -= 10; }
            }
            else if (e.KeyCode == Keys.Right) 
            {
                if (pictureBox1.Left + pictureBox1.Width + 10 < ClientRectangle.Width)
                {
                    pictureBox1.Left += 10;
                }
            }
        }
    }
}
