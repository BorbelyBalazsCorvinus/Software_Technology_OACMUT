using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hajos_teszt
{
    public class ValaszGomb : TextBox
    {
        public ValaszGomb()
        {
            BackColor = Color.LightGray;
            Multiline = true; //több sorban lehessen írni
            ReadOnly = true;
            MouseEnter += ValaszGomb_MouseEnter;
            MouseLeave += ValaszGomb_MouseLeave;
            Cursor = Cursors.Hand;
        }

        private void ValaszGomb_MouseLeave(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        private void ValaszGomb_MouseEnter(object? sender, EventArgs e)
        {
            BorderStyle=BorderStyle.FixedSingle;
        }
    }
}
