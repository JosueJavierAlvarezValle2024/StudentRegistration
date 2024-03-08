namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {

            Student student = new Student(Convert.ToDouble(txtavergeer.Text),txtcareer.Text,txtregistration.Text,txtname.Text,txtpaternal.Text,txtmothernal.Text,Convert.ToDateTime(dateTimePicker1.Text));
            lblstudent.Text = student.ToString();
        }
    }
}
