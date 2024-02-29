namespace HaromSzog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i >= j)
                    {
                        Button gomb = new Button();
                        gomb.Left = j * 50;
                        gomb.Top = i * 50;
                        gomb.Width = 50;
                        gomb.Height = 50;
                        Controls.Add(gomb);
                    }
                }
            }
        }
    }
}