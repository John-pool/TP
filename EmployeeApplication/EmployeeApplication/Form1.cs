namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ComputeSalary_Click(object sender, EventArgs e)
        {
            
        }

        private void ComputeSalary_Click_1(object sender, EventArgs e)
        {


            PartTimeEmployee pte = new PartTimeEmployee(FirstNameTextBox.Text, LastNameTextBox.Text, DepartmentTextBox.Text, JobTitleTextBox.Text);

            pte.ComputeSalary(Convert.ToInt32(TotalHoursTextBox.Text),Convert.ToDouble(RatePerHourTextBox.Text));
            label10.Text = pte.FirstName;
            label11.Text = pte.LastName;

            label12.Text = pte.getSalary().ToString("0.00");
        }
    }
}
