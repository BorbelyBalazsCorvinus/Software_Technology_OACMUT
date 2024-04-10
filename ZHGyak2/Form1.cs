using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace ZHGyak2
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countryDataBindingSource.DataSource = countryList;
            using (StreamReader sr = new StreamReader("countries.csv"))
            {
                //using (var csv = new CsvReader(sr, CultureInfo.InvariantCulture))
                //{
                //    var x = csv.GetRecords<CountryData>();
                //    foreach (var item in x)
                //    {
                //        countryList.Add(item);
                //    }
                //}
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] s = sor.Split(',');
                    CountryData countrydata = new CountryData();
                    countrydata.Name = s[0];
                    countrydata.Population = long.Parse(s[1]);
                    countrydata.AreaInSquareKm = double.Parse(s[2]);
                    countryList.Add(countrydata);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 formnewcountry = new Form2();
            if (formnewcountry.ShowDialog()==DialogResult.OK)
            {
                countryList.Add(formnewcountry.Country);
            }
            
        }
    }
}