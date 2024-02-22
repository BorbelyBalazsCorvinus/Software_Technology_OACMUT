namespace Pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Button b = new Button();
                    b.Top = i * 40;
                    b.Left = j * 80;
                    this.Controls.Add(b);
                    int p = Faktorialis(i) / (Faktorialis(j) * (Faktorialis(i - j)));
                    b.Text = p.ToString();
                }
            }

        }
        int Faktorialis(int n)
        {
            int eredmény = 1;
            for (int i = 1; i <= n; i++)
            {
                eredmény *= i;
            }
            return eredmény;
        }
    }
}