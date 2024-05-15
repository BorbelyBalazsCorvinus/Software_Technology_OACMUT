using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utsozhgyak.Models;

namespace utsozhgyak
{
    public partial class UserControl1 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            var er = from x in context.Instructors
                     select x;
            listBox1.DataSource = er.ToList();
            listBox1.DisplayMember = "Name";
            var oktatoSzam = context.Instructors.Count();
            var legmagasabbStatusz = (from x in context.Instructors
                                      select x.StatusFk).Max();
            var legrangosabb = from x in context.Instructors
                               where x.StatusFk == legmagasabbStatusz
                               select x.Name;
            MessageBox.Show($"{string.Join(',',legrangosabb)}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            var instructor = (Instructor)listBox1.SelectedItem;
            var orak = from x in context.Lessons
                       where x.InstructorFk == instructor.InstructorSk
                       select new
                       {
                           x.CourseFkNavigation.Name,
                           x.CourseFkNavigation.Code,
                           Nap = x.DayFkNavigation.Name,
                           Sav = x.TimeFkNavigation.Name,
                           Terem = x.RoomFkNavigation.Name
                       };
            dataGridView1.DataSource = orak.ToList();
        }
    }
    class RészletesÓra
    {
        public string Kurzus { get; set; }
        public string Nap { get; set; }

    }
}