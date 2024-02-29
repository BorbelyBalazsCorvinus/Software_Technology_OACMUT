namespace Veletlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                Button gomb = new Button();
                gomb.Left = rnd.Next(20, ClientSize.Width - 40);
                gomb.Top = rnd.Next(0, ClientSize.Height - 40);
                gomb.Width = rnd.Next(10, 40);
                gomb.Height = rnd.Next(10, 40);
                gomb.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                Controls.Add(gomb);
            }
        }
    }
}