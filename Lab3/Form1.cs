using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result1 = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)) / Convert.ToDouble(textBox3.Text);
            textBox4.Text = Convert.ToString(result1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (radioButton1.Checked == true)
                    textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 10 / 100);
                if (radioButton2.Checked == true)
                    textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 20 / 100);
                if (radioButton3.Checked == true)
                    textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 50 / 100);
            }

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
