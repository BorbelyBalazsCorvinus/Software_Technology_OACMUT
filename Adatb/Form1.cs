using Adatb.Adatbazis;

namespace Adatb
{
    public partial class Form1 : Form
    {
        private Adatbazis.StudentContext studentcontext = new Adatbazis.StudentContext();
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = studentcontext.Students.ToList();
            studentBindingSource.DataSource = studentcontext.Students.ToList();
            dataGridView1.DataSource = studentBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                studentcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text=((TextBox)sender).Text = textBox1.Text;
            var eredmeny = from student in students
                           where student.Name.Contains(text)
                           select student;
            var eredmeny2 = students.Where(student => student.Name.Contains(text));
            eredmeny2 = eredmeny2.OrderBy(x => x.Name);
            List<Student> eredmeny3 = new();
            foreach (var elem in students)
            {
                if (elem.Name.Contains(text))
                {
                    eredmeny3.Add(elem);
                }
            }
            studentBindingSource.DataSource = eredmeny2.ToList();
        }
    }
}