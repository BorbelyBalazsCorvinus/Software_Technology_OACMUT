using gyak11.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak11
{
    public partial class UserControl2 : UserControl
    {
        StudiesContext context;
        public UserControl2()
        {
            InitializeComponent();
            context = new StudiesContext();
            FillDateSource();
            listBox1.DisplayMember = "Name";
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            
        }
        private void FillDateSource()
        {
            listBox1.DataSource = (from c in context.Courses
                                   where c.Name.Contains(textBox1.Text)
                                   select c).ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null) return;
            Course course = listBox1.SelectedItem as Course;
            dataGridView1.DataSource = (from l in context.Lessons
                                        where l.CourseFk == course.CourseSk
                                        select new
                                        {
                                            Nap = l.DayFkNavigation.Name,
                                            Sav = l.TimeFkNavigation.Name,
                                            Oktato = l.InstructorFkNavigation.Name
                                        }).ToList();
        }
    }
}
