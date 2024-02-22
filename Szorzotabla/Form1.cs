namespace Szorzotabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Button b = new Button();
                    b.Text = $"{i*j}";
                    b.Left = 80*i;
                    b.Top = 30*j;
                    Controls.Add(b);
                }
            }
        }
    }
}