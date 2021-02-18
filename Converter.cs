using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long number = long.Parse(textBox1.Text);
            string Base = Convert.ToString(number, 2);
            textBox2.Text = Base;
        }

        private void Converter_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            long number = long.Parse(textBox1.Text);
            string Base = Convert.ToString(number, 8);
            textBox2.Text = Base;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long number = long.Parse(textBox1.Text);
            string Base = Convert.ToString(number, 16);
            textBox2.Text = Base;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            long Base = Convert.ToInt32(textBox1.Text, 8);
            string finalBase = Convert.ToString(Base, 16);
            textBox2.Text = finalBase;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Base=Convert.ToInt32(textBox1.Text, 2).ToString();
            textBox2.Text = Base;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            long Base = Convert.ToInt32(textBox1.Text, 2);
            string finalBase = Convert.ToString(Base, 8);
            textBox2.Text = finalBase;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            long Base = Convert.ToInt32(textBox1.Text, 2);
            string finalBase = Convert.ToString(Base, 16);
            textBox2.Text = finalBase;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            long Base = Convert.ToInt32(textBox1.Text, 8);
            string finalBase = Convert.ToString(Base, 2);
            textBox2.Text = finalBase;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            long Base = Convert.ToInt32(textBox1.Text, 8);
            string finalBase = Convert.ToString(Base, 10);
            textBox2.Text = finalBase;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            long Base = Convert.ToInt32(textBox1.Text, 16);
            string finalBase = Convert.ToString(Base, 2);
            textBox2.Text = finalBase;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            long Base = Convert.ToInt32(textBox1.Text, 16);
            string finalBase = Convert.ToString(Base, 10);
            textBox2.Text = finalBase;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            long Base = Convert.ToInt32(textBox1.Text, 16);
            string finalBase = Convert.ToString(Base, 8);
            textBox2.Text = finalBase;
        }
    }
}
