using Csillagos.Models;

namespace Csillagos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.White);
            Brush brush = new SolidBrush(Color.White);
            g.FillEllipse(brush, 0, 0, 100, 100);
            HajosContext context = new HajosContext();
            var stars = from x in context.StarData
                        select new { x.Hip, x.Magnitude, x.X, x.Y };
            double nagyitas = Math.Min(ClientRectangle.Height, ClientRectangle.Width) / 2;
            int ox = ClientRectangle.Width / 2, oy = ClientRectangle.Height / 2;
            g.Clear(Color.DarkBlue);
            foreach (var star in stars)
            {
                if (Math.Sqrt(Math.Pow(star.X, 2) + Math.Pow(star.Y, 2)) > 1)
                {
                    continue;
                }
                if (star.Magnitude > 6)
                {
                    continue;
                }
                double size = 10 * Math.Pow(10, star.Magnitude / -2.5);
                double x = star.X * nagyitas + ox;
                double y = star.Y * nagyitas + oy;
                g.FillEllipse(brush, (float)(x - size / 2), (float)(y - size / 2), (float)size, (float)size);
            }
            var lines = context.ConstellationLines.ToList();
            foreach (var line in lines)
            {
                var star1 = (from x in stars
                             where x.Hip == line.Star1
                             select x).FirstOrDefault();
                var star2 = (from x in stars
                             where x.Hip == line.Star2
                             select x).FirstOrDefault();
                if (star1 == null || star2 == null) continue;
                double x1 = star1.X * nagyitas + ox;
                double y1 = star1.Y * nagyitas + oy;
                double x2 = star2.X * nagyitas + ox;
                double y2 = star2.Y * nagyitas + oy;
                g.DrawLine(pen, (float)x1, (float)y1, (float)x2, (float)y2);
            }
        }
    }
}