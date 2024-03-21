using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class KigyoElem : PictureBox
    {
        public static int Méret = 20;
        public KigyoElem()
        {
            Width = Méret;
            Height = Méret;
            BackColor = Color.Fuchsia;
        }
    }
}
