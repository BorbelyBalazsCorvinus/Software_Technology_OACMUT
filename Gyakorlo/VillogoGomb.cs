using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Gyakorlo
{
    internal class VillogoGomb : Button
    {
        public VillogoGomb()
        {
            MouseEnter += OnMouseEnter;
            MouseLeave += OnMouseLeave;
        }

        private void OnMouseLeave(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

        private void OnMouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
