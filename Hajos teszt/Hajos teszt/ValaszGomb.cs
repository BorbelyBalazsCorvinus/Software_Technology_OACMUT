using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hajos_teszt
{
    public class ValaszGomb : TextBox
    {
        public static bool voltE=false;
        public bool HelyesE { get; set; }
        public ValaszGomb()
        {
            BackColor = Color.LightGray;
            Multiline = true; //több sorban lehessen írni
            ReadOnly = true;
            MouseEnter += ValaszGomb_MouseEnter;
            MouseLeave += ValaszGomb_MouseLeave;
            Click += ValaszGomb_Click;
            Cursor = Cursors.Hand;
        }
        private void ValaszGomb_Click(object? sender, EventArgs e)
        {
            
            if (HelyesE&&!voltE)
            {
                BackColor = Color.Green;
                voltE = true;
                Form1.jo = true;
            }
            else if(!HelyesE&&!voltE)
            {
                BackColor = Color.Red;
                voltE=true;
                Form1.jo = false;
            }
            
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
