namespace fhh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> szavak = new List<string>();
        Word szo;
        int hiba;
        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("szavak.txt"))
            {
                while (!sr.EndOfStream)
                {
                    szavak.Add(sr.ReadLine());
                }
            }
            UjJatek();
        }
        private void UjJatek()
        {
            pictureBox1.Image = null;
            Random rnd = new Random();
            szo = new Word(szavak[rnd.Next(0, szavak.Count)]);
            hiba = 0;
            label1.Text = szo.masked;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!szo.Tipp(e.KeyChar))
            {
                hiba++;
                pictureBox1.Image = Image.FromFile($"{hiba}.png");
            }
            label1.Text = szo.masked;
            bool vege = false;
            if (hiba == 8)
            {
                MessageBox.Show($"Vesztett�l!\nA kital�land� sz� a(z) {szo.wordtoguess} volt!", "V�ge", MessageBoxButtons.OK);
                vege = true;
            }
            else if (szo.wordtoguess == szo.masked)
            {
                MessageBox.Show($"Nyert�l!", "V�ge", MessageBoxButtons.OK);
                vege = true;
            }
            if (vege)
            {
                if (MessageBox.Show("Szeretn�l �jra j�tszani?", "�j j�t�k", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UjJatek();
                }
                else
                {
                    Environment.Exit(0);
                }
            }

        }

    }
}