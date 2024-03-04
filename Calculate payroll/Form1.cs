namespace Calculate_payroll
{
    public partial class Form1 : Form
    {
        employee one = new employee();
        payroll first = new payroll();

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                error1.SetError(txtname, "You need to enter a name");
                txtname.Focus();
                return;
            }

            error1.SetError(txtname, "");

            double asigned_day;
            if (double.TryParse(txtsalaryday.Text,out asigned_day))
            {
                error1.SetError(txtsalaryday, "You need to enter a number");
                txtname.Focus();
                return;
            }
            error1.SetError(txtsalaryday, "");


            one.Name = txtname.Text;
            one.Id = txtid.Text;
            one.Salary_day = Convert.ToDouble(txtsalaryday.Text);
            first.Worked_days = Convert.ToInt32(txtworkeddays.Text);
            MessageBox.Show("The record was saved correctly");

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            txttotal.Text = first.calculation(Convert.ToInt32(first.Worked_days),
                Convert.ToDouble(one.Salary_day)).ToString();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtid.Clear();
            txtsalaryday.Clear();
            txtworkeddays.Clear();
            txttotal.Clear();
        }
    }
}