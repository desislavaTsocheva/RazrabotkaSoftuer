namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtNum1.Text);
                int value2 = int.Parse(txtNum2.Text);
                int sum = value + value2;
                textBox3.Text = sum.ToString();
            }
            catch (FormatException)
            {
                textBox3.Text = "Invalide numbers";
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            txtNum1.Clear();
            txtNum2.Clear();
        }

        private void sub_button_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtNum1.Text);
                int value2 = int.Parse(txtNum2.Text);
                double sub = value - value2;
                textBox3.Text = sub.ToString();
            }
            catch (FormatException)
            {
                textBox3.Text = "Invalide numbers";
            }
        }

        private void multy_button_Click(object sender, EventArgs e)
        {

            try
            {
                int value = int.Parse(txtNum1.Text);
                int value2 = int.Parse(txtNum2.Text);
                double multy = value * value2;
                textBox3.Text = multy.ToString();
            }
            catch (FormatException)
            {
                textBox3.Text = "Invalide numbers";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtNum1.Text);
                int value2 = int.Parse(txtNum2.Text);
                double divide = value / value2;
                textBox3.Text = divide.ToString();
            }
            catch (FormatException)
            {
                textBox3.Text = "Invalide numbers";
            }
            catch (DivideByZeroException)
            {
                textBox3.Text = "Divide by zero is imposible!";
            }
        }

        private void power_button_Click(object sender, EventArgs e)
        {

            int value = int.Parse(txtNum1.Text);
            int value2 = int.Parse(txtNum2.Text);
            double power = 0;
            for (int i = 0; i < value2+1; i++)
            {
                power= value * value;
            }
            textBox3.Text = power.ToString();
        }
    }
}