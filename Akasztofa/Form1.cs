using System.Data;

namespace Akasztofa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> words = new List<string>();
        HashSet<char> notInList;
        Word word;
        int notIn;
        int wonGames = 0;
        int lostGames = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("szavak.txt"))
            {
                while (!sr.EndOfStream)
                {
                    words.Add(sr.ReadLine());
                }
            }
            Play();
        }
        private void Play()
        {
            Random rnd = new Random();
            word = new Word(words[rnd.Next(0, words.Count)]);
            notInList = new HashSet<char>();
            label1.Text = word.Masked;
            label2.Text = $"Nyert játékok: {wonGames}";
            label3.Text = $"Vesztett játékok: {lostGames}";
            label4.Text = "Hibák száma: 0 / 8";
            label5.Text = "Nincs benne: ";
            pictureBox1.Image = null;
            notIn = 0;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!word.Guess(e.KeyChar) && !notInList.Contains(e.KeyChar))
            {
                notIn++;
                pictureBox1.Image = Image.FromFile($"{notIn}.png");
                label4.Text = $"Hibák száma: {notIn} / 8";
                notInList.Add(e.KeyChar);
                label5.Text += $"{e.KeyChar}; ";
            }
            label1.Text = word.Masked;
            if (notIn == 8)
            {
                Lost();
            }
            if (word.wordtoguess == word.Masked)
            {
                Won();
            }
        }
        private void Lost()
        {
            MessageBox.Show($"Vesztettél!\nA szó a(z) {word.wordtoguess} volt.", "Vége", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lostGames++;
            label3.Text = $"Vesztett játékok: {lostGames}";
            AskNew();
        }
        private void Won()
        {
            MessageBox.Show($"Gratulálunk!\nNyertél!", "Vége", MessageBoxButtons.OK, MessageBoxIcon.Information);
            wonGames++;
            label2.Text = $"Nyert játékok: {wonGames}";
            AskNew();
        }
        private void AskNew()
        {
            if (MessageBox.Show("Szeretnél új játékot kezdeni?", "Új játék", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Play();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}