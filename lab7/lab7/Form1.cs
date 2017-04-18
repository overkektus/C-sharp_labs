using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            CarryingСapacity.Text = Convert.ToString(trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            airplane plane = new airplane(14223, "пассажирский", "модель", 2014, 200, 100);
            string json = JsonConvert.SerializeObject(plane);
            File.WriteAllText("airplane.json", json);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String str = "";
            str = File.ReadAllText("airplane.json");
            textBox2.Text = str;
            airplane plane2 = new airplane();
            airplane plane2 = JsonConvert.DeserializeObject(str, airplane);
        }
    }
}
