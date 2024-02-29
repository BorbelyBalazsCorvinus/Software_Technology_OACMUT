using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo
{
    internal class SzamoloGomb : Button
    {
        public static int szam = 0;
        public SzamoloGomb()
        {
            Width = 20;
            Height = 20;
            Click += SzamoloGomb_Click;
        }

        private void SzamoloGomb_Click(object? sender, EventArgs e)
        {
            if (szam == 5)
            {
                szam = 0;
            }
            szam++;
            Text = szam.ToString();
        }
    }
}
