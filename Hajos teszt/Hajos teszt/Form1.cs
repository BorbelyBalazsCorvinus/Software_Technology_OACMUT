namespace Hajos_teszt
{
    public partial class Form1 : Form
    {
        List<Kerdes> OsszKerdes;
        List<Kerdes> AktivKerdesek;
        int AktivKerdes = 5;
        int szamlalo = 0;
        public static bool jo = false;
        public Form1()
        {
            InitializeComponent();
        }
        List<Kerdes> KerdesBeolvasas()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            using StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt");
            {
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine() ?? string.Empty; //ha null, akkor string.empty-t ad vissza.
                    string[] tomb = sor.Split("\t");
                    if (tomb.Length != 7) continue;
                    Kerdes k = new Kerdes()
                    {
                        KerdesSzoveg = tomb[1],
                        Valasz1 = tomb[2],
                        Valasz2 = tomb[3],
                        Valasz3 = tomb[4],
                        URL = tomb[5]
                    };
                    int.TryParse(tomb[6], out int jovalasz); //ha sikerul parseolni a tomb6-ot akkor a jovalaszt adja
                    k.HelyesValasz = jovalasz;
                    kerdesek.Add(k);
                }
            }
            return kerdesek;
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            AktivKerdesek = new List<Kerdes>();
            OsszKerdes = KerdesBeolvasas();
            for (int i = 0; i < 7; i++)
            {
                AktivKerdesek.Add(OsszKerdes[i]);
                OsszKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AktivKerdesek;
            KerdesMegjelenites(AktivKerdesek[1]);
        }
        public void KerdesMegjelenites(Kerdes kerdes)
        {
            label1.Text = kerdes.KerdesSzoveg;
            valaszGomb1.Text = kerdes.Valasz1;
            valaszGomb2.Text = kerdes.Valasz2;
            valaszGomb3.Text = kerdes.Valasz3;
            if (kerdes.HelyesValasz == 1)
            {
                valaszGomb1.HelyesE = true;
                valaszGomb2.HelyesE = false;
                valaszGomb3.HelyesE = false;
            }
            else if (kerdes.HelyesValasz == 2)
            {
                valaszGomb2.HelyesE = true;
                valaszGomb1.HelyesE = false;
                valaszGomb3.HelyesE = false;
            }
            else
            {
                valaszGomb3.HelyesE = true;
                valaszGomb1.HelyesE = false;
                valaszGomb2.HelyesE = false;
            }
            if (!string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kerdes.URL);
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            if (Form1.jo)
            {
                kerdes.HelyesValaszokSzama++;
            }
            if (kerdes.HelyesValaszokSzama == 3)
            {
                AktivKerdesek.Remove(kerdes);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valaszGomb1.BackColor = Color.LightGray;
            valaszGomb2.BackColor = Color.LightGray;
            valaszGomb3.BackColor = Color.LightGray;
            ValaszGomb.voltE = false;
            KerdesMegjelenites(AktivKerdesek[szamlalo]);
            szamlalo++;
            if (szamlalo == AktivKerdesek.Count)
            {
                szamlalo = 0;
            }
        }
    }
}