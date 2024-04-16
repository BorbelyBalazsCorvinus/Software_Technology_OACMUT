using CsvHelper;
using CsvHelper.Configuration;
using System.ComponentModel;
using System.Globalization;

namespace MintaZH2
{
    public partial class Form1 : Form
    {
        BindingList<Versenyzo> versenyzolist = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("futoversenyzok.txt"))
                {
                    var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                    var tomb = csv.GetRecords<Versenyzo>();
                    foreach (var item in tomb)
                    {
                        versenyzolist.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Valami hiba történt!\n{ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = versenyzolist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefiledialog = new();
                if (savefiledialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(savefiledialog.FileName))
                    {
                        var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                        csv.WriteRecords(versenyzolist);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Valami hiba történt!\n{ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current == null)
            {
                MessageBox.Show("Nincs kijelölt sor!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Biztosan törölni szeretnéd?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingSource1.RemoveCurrent();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 ujsor = new();
            if (ujsor.ShowDialog() == DialogResult.OK)
            {
                bindingSource1.Add(ujsor.ujrekord);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int max = int.MaxValue;
            string maxnev = "";
            int db = 0;
            foreach (var elem in versenyzolist)
            {
                if (max > elem.EredmenyPerc)
                {
                    max = elem.EredmenyPerc;
                    maxnev = elem.Nev;
                }
                if (elem.Nemzetiseg == "USA")
                {
                    db++;
                }
            }
            MessageBox.Show($"Az USA-ból {db} versenyzõ érkezett és a legjobb idõt {maxnev} futotta!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}