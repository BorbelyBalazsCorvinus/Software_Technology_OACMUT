using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Elem
    {
        public int Sorszam { get; set; }
        public long Ertek { get; set; }
        public Elem(int sorszam, long ertek)
        {
            this.Sorszam = sorszam;
            this.Ertek = ertek;
        }
    }
}
