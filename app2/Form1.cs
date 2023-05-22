namespace app2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(number1.Text);
            int num2 = int.Parse(number2.Text);
            int add = num1 + num2;
            MessageBox.Show("sum of two number are : " + add.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(number1.Text);
            int num2 = int.Parse(number2.Text);
            int sub = num1 - num2;
            MessageBox.Show("Difference of two number are : " + sub.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(number1.Text);
            int num2 = int.Parse(number2.Text);
            int mul = num1 * num2;
            MessageBox.Show("multiplication of two number are : " + mul.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(number1.Text);
            int num2 = int.Parse(number2.Text);
            int div = num1 / num2;
            MessageBox.Show("division of two number are : " + div.ToString());
        }
    }
}