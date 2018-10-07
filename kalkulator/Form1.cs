using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Hasil : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Hasil()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")||(operation_pressed))
                textBox1.Clear();
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
            operation_pressed = true;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            switch (operation)
            { 
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            } operation_pressed = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            value = 0;
        }
    }
}
