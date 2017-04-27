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
        private string operation;
        private double firstValue;
        private double secondValue;
        private MathOperations math;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "";
            math = new MathOperations();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e) // =
        {
            try
            {      
                secondValue = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                switch (operation)
                {
                    case "+":
                        {
                            textBox1.Text = math.Plus(firstValue, secondValue);
                        }
                        break;
                    case "-":
                        {
                            textBox1.Text = math.Minus(firstValue, secondValue);
                        }
                        break;
                    case "*":
                        {
                            textBox1.Text = math.Multiply(firstValue, secondValue);
                        }
                        break;
                    case "/":
                        {
                            textBox1.Text = math.Divide(firstValue, secondValue);
                        }
                        break;
                    case "^":
                        {
                            textBox1.Text = math.RaiseToPow(firstValue, secondValue);
                        }
                        break;
                }
            }
            catch(Exception) { }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                //textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.Text = "";
            }
            catch (Exception) { }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = math.Sin(Convert.ToDouble(textBox1.Text));
            }
            catch (Exception) { }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = math.Tan(Convert.ToDouble(textBox1.Text));
            }
            catch (Exception) { }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = math.Cos(Convert.ToDouble(textBox1.Text));
            }
            catch (Exception) { }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = math.CTan(Convert.ToDouble(textBox1.Text));
            }
            catch (Exception) { }
        }

        private void Plus_Click(object sender, EventArgs e) //+
        {
            try
            {
                operation = "+";
                firstValue = Convert.ToDouble(textBox1.Text);
                textBox1.Text += "+";
            }
            catch(Exception) { }
        }

        private void Minus_Click(object sender, EventArgs e) //-
        {
            try
            {
                operation = "-";
                firstValue = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            catch(Exception) { }
        }

        private void button19_Click(object sender, EventArgs e) //*
        {
            try
            {
                operation = "*";
                firstValue = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            catch(Exception) { }
        }

        private void button20_Click(object sender, EventArgs e) // /
        {
            try
            {
                operation = "/";
                firstValue = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            catch(Exception) { }
        }

        private void button21_Click(object sender, EventArgs e) // ,
        {
            if (textBox1.Text.LastIndexOf(',') != textBox1.Text.Length - 1)
            {
                textBox1.Text += ",";
            }
        }

        private void button22_Click(object sender, EventArgs e) // ^
        {
            try
            {
                operation = "^";
                firstValue = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            catch (Exception) { }
        }

    }
}
