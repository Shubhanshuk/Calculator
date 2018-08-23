using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double TempValue = 0;
        string Operator = "";
        bool OperatorClicked = false;
        bool ResultClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Numbers Click
        {
            if (textBox1.Text == "0" || OperatorClicked == true)
                textBox1.Clear();

            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;
            OperatorClicked = false;
        }

        private void Operator_click(object sender, EventArgs e) //Operators Click
        {
            Button button = (Button)sender;
            if(TempValue !=0)
            {
                button16.PerformClick();
            }
            else
                TempValue = double.Parse(textBox1.Text);

            Operator = button.Text;
            label1.Text = TempValue + " " + Operator;
            OperatorClicked = true;
        }

        private void Result_click(object sender, EventArgs e)
        {
            switch(Operator)
            {
                case "+":
                        textBox1.Text = (TempValue + double.Parse(textBox1.Text)).ToString();
                        break;
                case "-":
                    textBox1.Text = (TempValue - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (TempValue * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (TempValue / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            TempValue = double.Parse(textBox1.Text);
            label1.Text = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            TempValue = 0;
            label1.Text = "";
        }
    }
}
