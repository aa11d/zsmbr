namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int vx, vy;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 20;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            vx = rnd.Next(5, 11);
            if (rnd.NextDouble() < 0.5)
            {
                vx *= -1;
            }
            vy = rnd.Next(-5, 6);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int balfent = pictureBox1.Top + vy;
            int balbal = pictureBox1.Left + vx;
            int jobblent = balfent + pictureBox1.Height;
            int jobbjobb = balbal + pictureBox1.Width;

            if (balbal < 0 || jobbjobb > ClientRectangle.Width)
            {
                vx = -vx;
            }
            else
            {
                pictureBox1.Left = balbal;
            }
            if (balfent < 0 || jobblent > ClientRectangle.Height)
            {
                vy = -vy;
            }
            else
            {
                pictureBox1.Top = balfent;
            }
            if (pictureBox1.Left + pictureBox1.Width >= utojobb.Left && pictureBox1.Top >= utojobb.Top && pictureBox1.Top + pictureBox1.Height <= utojobb.Top + utojobb.Height)
            {
                vx = -vx;
            }
        }
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (utojobb.Top > 10)
                {
                    utojobb.Top -= 10;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (utojobb.Top + utojobb.Height + 10 < ClientRectangle.Height)
                {
                    utojobb.Top += 10;
                }
            }
        }
    }
}
