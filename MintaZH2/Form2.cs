using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintaZH2
{
    public partial class Form2 : Form
    {
        public Versenyzo ujrekord = new Versenyzo();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ujrekord.VersenyzoID = int.Parse(textBox1.Text);
                ujrekord.Nev = textBox2.Text;
                ujrekord.Nemzetiseg = textBox3.Text;
                ujrekord.EredmenyPerc = int.Parse(textBox4.Text);
                ujrekord.Kategoria = textBox5.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Valami hiba történt!\n{ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
