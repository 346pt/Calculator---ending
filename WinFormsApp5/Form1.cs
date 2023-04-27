namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        float a, b;
        int count;
        bool znak = true;

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }
        public Form1()
        {
            InitializeComponent();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox3.Text);
            textBox2.Text = ("Тангенс " + Math.Tan(a));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {


            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label3.Text = a.ToString() + "+";
            znak = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label3.Text = a.ToString() + "-";
            znak = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label3.Text = a.ToString() + "*";
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label3.Text = a.ToString() + "/";
            znak = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            calculate();
            label3.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            textBox2.Text = Convert.ToString(a, 2);
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            textBox2.Text = Convert.ToString(a, 8);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            textBox2.Text = Convert.ToString(a, 16);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox3.Text);
            textBox2.Text = "Синус " + Math.Sin(a);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox3.Text);
            textBox2.Text = "Косинус " + Math.Cos(a);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = ($"Степень {a} от {b} = " + Math.Pow(a, b));

        }

        private void button16_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox3.Text);
            textBox3.Text = ($"Корень из {a} = " + Math.Sqrt(a));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

