using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCollectionUI
{
    public partial class Form1 : Form
    {
        private CollectionList<int> list;
        private Random rnd;

        public Form1()
        {
            InitializeComponent();
            list = new CollectionList<int>();
            rnd = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = "";
                for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                {
                    list.Add(rnd.Next(-10000,10000));
                    richTextBox1.Text += list[i].ToString() + "\r\n"; 
                }
                textBox1.Text = "";
            }
            catch (Exception) { }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            list.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            list.Add(Convert.ToInt32(textBox6.Text));
            richTextBox1.Text += list[list.Count() - 1]+"\r\n";
            textBox6.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Text = "";

                var listMore = from int item in list.GetList()
                               where item > Convert.ToInt32(textBox4.Text)
                               select item;

                foreach(int item in listMore)
                {
                    richTextBox2.Text += item.ToString() + "\r\n";
                }

                textBox4.Text = "";
            }
            catch (Exception) { }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    richTextBox2.Text = "";

                    var listMore = from int item in list.GetList()
                                   where item > 0
                                   select item;

                    foreach (int item in listMore)
                    {
                        richTextBox2.Text += item.ToString() + "\r\n";
                    }

                    textBox4.Text = "";
                }
                if (radioButton2.Checked)
                {
                    richTextBox2.Text = "";

                    var listMore = from int item in list.GetList()
                                   where item < 0
                                   select item;

                    foreach (int item in listMore)
                    {
                        richTextBox2.Text += item.ToString() + "\r\n";
                    }

                    textBox4.Text = "";
                }
            }
            catch(Exception) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            list.Sort();
            list.ReverseList();
            for (int i = 0; i < list.Count(); i++)
                richTextBox2.Text += list[i].ToString() + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            list.Sort();
            for (int i = 0; i < list.Count(); i++)
                richTextBox2.Text += list[i].ToString() + "\r\n";
        }
    }
}
