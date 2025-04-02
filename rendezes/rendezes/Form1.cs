namespace rendezes
{
    public partial class Form1 : Form
    {
        Button[] tomb;
        Button m1, m2;
        int h1, h2;
        int v1, v2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tomb = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12 };
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                tomb[i].Text = rnd.Next(100, 1000).ToString();
            }
        }
        void cseRe(int i, int j)
        {
            Button ment = tomb[i];
            tomb[i] = tomb[j];
            tomb[j] = ment;

            tomb[i].BringToFront();
            tomb[j].BringToFront();
            int iLeft = tomb[i].Left;
            int jLeft = tomb[j].Left;

            while (Math.Abs(iLeft - tomb[j].Left) > 10)
            {
                if (iLeft < jLeft)
                {
                    tomb[i].Left += 10;
                    tomb[j].Left -= 10;
                }
                else
                {
                    tomb[i].Left -= 10;
                    tomb[j].Left += 10;
                }
                Refresh();
                Thread.Sleep(100);
            }
            tomb[i].Left = jLeft;
            tomb[j].Left = iLeft;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            for (int meddig = 11; meddig >= 0; meddig--)
            {
                for (int mutato = 0; mutato < meddig; mutato++)
                {
                    if (tomb[mutato].Text.CompareTo(tomb[mutato + 1].Text) > 0)
                    {
                        cseRe(mutato, mutato + 1);
                    }
                }
            }
        }

        private void KozvCsere_Click(object sender, EventArgs e)
        {
            for (int meddig = 11; meddig >= 0; meddig--)
            {
                for(int mutato = 0; mutato < meddig; mutato++)
                {
                    if (tomb[mutato].Text.CompareTo(tomb[mutato + 1].Text) > 0)
                    {

                    }
                }
            }
        }

        private void MinKiv_Click(object sender, EventArgs e)
        {
            for(int meddig = 11;meddig >= 0;meddig--)
            {
                int 
            }
        }
    }
}
    
