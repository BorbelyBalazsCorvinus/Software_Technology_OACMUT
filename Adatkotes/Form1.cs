using CsvHelper;
using System.ComponentModel;
using System.Globalization;
namespace Adatkotes
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countrylist = new();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countrylist;
            dataGridView1.DataSource = countryDataBindingSource;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("countries.csv"))
            {
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tomb = csv.GetRecords<CountryData>();
                foreach (var item in tomb)
                {
                    countrylist.Add(item);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fcd = new Form2();
            fcd.countryData = countryDataBindingSource.Current as CountryData;
            fcd.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}