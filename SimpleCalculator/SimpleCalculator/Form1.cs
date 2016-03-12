using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        //Variables
        double firstNumber;
        double secondNumber;
        int TextBoxID = 0;
        int operationID; // 1= addition, 2= subtraction, 3= multiplication, 4= division

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text +  "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(richTextBox1.Text);
            richTextBox1.Text = string.Empty;
            operationID = 1;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(richTextBox1.Text);
            richTextBox1.Text = string.Empty;
            operationID = 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(richTextBox1.Text);
            richTextBox1.Text = string.Empty;
            operationID = 3;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(richTextBox1.Text);
            richTextBox1.Text = string.Empty;
            operationID = 4;

        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains('.'))
            {

            }
            else
            richTextBox1.Text = richTextBox1.Text + "."  ;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (operationID)
            {
                case 1:
                    richTextBox1.Text = (double.Parse(richTextBox1.Text) + firstNumber).ToString();
                    break;
                case 2:
                    richTextBox1.Text = ( firstNumber - double.Parse(richTextBox1.Text)).ToString();
                    break;
                case 3:
                    richTextBox1.Text = (double.Parse(richTextBox1.Text) * firstNumber).ToString();
                    break;
                case 4:
                    richTextBox1.Text = ( firstNumber/ double.Parse(richTextBox1.Text)).ToString();
                    break;
            }

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                    && e.KeyChar !='.')
                {
                e.Handled = true;
            }
            //only one decimal is allowed
            if(e.KeyChar == '.')
            {
                if (richTextBox1.Text.Contains('.'))
                    e.Handled = true;

            }
        }

    }
}
