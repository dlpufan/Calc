using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int.MaxValue - int.Parse(FirstText.Text)) - int.Parse(SecondText.Text) <= 0)
            {
                this.ResultLable.Text = "超出int上限";
                return;
            }
            this.ResultLable.Text = (int.Parse(FirstText.Text) + int.Parse(SecondText.Text)).ToString();
            FirstText.Text = ResultLable.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.ResultLable.Text = (int.Parse(FirstText.Text) - int.Parse(SecondText.Text)).ToString();
            FirstText.Text = ResultLable.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(SecondText.Text) != 0)
            {
                this.ResultLable.Text = (int.Parse(FirstText.Text) / int.Parse(SecondText.Text)).ToString();
                FirstText.Text = ResultLable.Text;
            }
            else
            {
                this.ResultLable.Text = "0不能作为除数";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if ((int.MaxValue / int.Parse(FirstText.Text)) / int.Parse(SecondText.Text) == 0)
            {
                this.ResultLable.Text = "超出int上限";
                return;
            }
            this.ResultLable.Text = (int.Parse(FirstText.Text) * int.Parse(SecondText.Text)).ToString();
            FirstText.Text = ResultLable.Text;
            
            
        }

        private void ResultLable_Click(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
            this.ResultLable.Text = (int.Parse(FirstText.Text) % int.Parse(SecondText.Text)).ToString();
        }
    }
}
