namespace Snake
{
    public partial class Form1 : Form
    {
        int ir�ny_x = 1;
        int ir�ny_y = 0;
        int fej_x = 100;
        int fej_y = 100;
        int lepesszam = 0;
        int hossz = 6;
        List<KigyoElem> kigyo = new List<KigyoElem>();
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lepesszam++;
            fej_x += ir�ny_x * KigyoElem.M�ret;
            fej_y += ir�ny_y * KigyoElem.M�ret;
            foreach (object item in Controls)
            {
                if (item is KigyoElem)
                {
                    KigyoElem k = (KigyoElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }
            KigyoElem ke = new KigyoElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            if (lepesszam % 2 == 0) ke.BackColor = Color.Yellow;
            Controls.Add(ke);
            kigyo.Add(ke);
            if (Controls.Count > hossz)
            {
                Controls.RemoveAt(0);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }

        }
    }
}