namespace OmhsLaw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class var
        {
            public static double? V = null;
            public static double? I = null;
            public static double? R = null;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = string.Empty;
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Text = string.Empty;
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox3.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox3.Text = string.Empty;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                try
                {
                    var.I = Double.Parse(textBox2.Text);
                    var.R = Double.Parse(textBox3.Text);
                    var.V = var.I * var.R;
                    textBox1.Text = Convert.ToString(var.V);
                }
                catch (FormatException)
                {
                    textBox1.Text = textBox2.Text = textBox3.Text = "Error!";
                }
            } else if (radioButton2.Checked)
            {
                try
                {
                    var.V = Double.Parse(textBox1.Text);
                    var.R = Double.Parse(textBox3.Text);
                    var.I = var.V / var.R;
                    textBox2.Text = Convert.ToString(var.I);
                }
                catch (FormatException)
                {
                    textBox1.Text = textBox2.Text = textBox3.Text = "Error!";
                }
            } else if (radioButton3.Checked)
            {
                try
                {
                    var.V = Double.Parse(textBox1.Text);
                    var.I = Double.Parse(textBox2.Text);
                    var.R = var.V / var.I;
                    textBox3.Text = Convert.ToString(var.R);
                }
                catch (FormatException)
                {
                    textBox1.Text = textBox2.Text = textBox3.Text = "Error!";
                }
            } else
            {
                textBox3.Text = Convert.ToString(var.R);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}