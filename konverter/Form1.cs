using System.Text;

namespace konverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked)
            {
                textBox2.Text = $" {a * 0.1804}";
            }
            if (radioButton2.Checked)
            {
                textBox2.Text = $" {a * 0.6}";
            }
            if (radioButton3.Checked)
            {
                textBox2.Text = $" {a * 0.9464}";
            }
            if (radioButton3.Checked)
            {
                textBox2.Text = $" {a * 0.118}";
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked)
            {
                textBox2.Text = $" {a * 0.1804 / 1000}";
            }
            if (radioButton2.Checked)
            {
                textBox2.Text = $" {a * 0.6 / 1000}";
            }
            if (radioButton3.Checked)
            {
                textBox2.Text = $" {a * 0.9464 / 1000}";
            }
            if (radioButton3.Checked)
            {
                textBox2.Text = $" {a * 0.118 / 1000}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                string text = textBox2.Text;
                SaveFileDialog open = new SaveFileDialog();

                open.ShowDialog();

                string path = open.FileName;

                try
                {

                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(text);
                        fs.Write(info, 0, info.Length);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }
    }
}