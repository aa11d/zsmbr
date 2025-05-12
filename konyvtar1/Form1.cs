namespace konyvtar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Kkuj_Click(object sender, EventArgs e)
        {
            if (Kklistbox.Items.Count == 0)
            {
                Kkazon.Text = "1000";
            }
            else
            {
                int ujazon = 1001;
                for (int i = 0; i < Kklistbox.Items.Count; i++)
                {
                    string azonSzoveg = Kklistbox.Items[i].ToString().Substring(1, 4);
                    int azon = int.Parse(azonSzoveg);
                    if (azon >= ujazon)
                    {
                        ujazon = azon + 1;
                    }
                }
                Kkazon.Text = ujazon.ToString();
            }
            Kkfelvesz.Enabled = true;
            Kkszerzo.Text = "";
            Kkcim.Text = "";
            Kkkiad.Text = "";
        }

        private void Kkfelvesz_Click(object sender, EventArgs e)
        {
            if (Kkszerzo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Add meg a szerzõt!");
            }
            else if (Kkcim.Text.Trim().Length == 0)
            {
                MessageBox.Show("Add meg a címet!");
            }
            else
            {
                try
                {
                    int kiad = int.Parse(Kkkiad.Text);
                    string konyv = $"[{Kkazon.Text}] - {Kkszerzo.Text} - {Kkcim.Text}";
                    Kklistbox.Items.Add(konyv);
                    Kkfelvesz.Enabled = false;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Adj meg egy helyes kiadási évet!");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("konyvek.txt");
            for ( int i = 0; i < Kklistbox.Items.Count; i++ )
            {
                string pontos = Kklistbox.Items[i].ToString().Replace(" - ", ":");
                sw.WriteLine(pontos);
            }
            sw.Close();
        }
    }
}
