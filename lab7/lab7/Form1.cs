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
        Airport airport;
        Airplane airplane;

        string deletedItem;

        public Form1()
        {
            InitializeComponent();
            DateTimePicker_Maintenance.Format = DateTimePickerFormat.Short;

            airport = new Airport();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            CarryingСapacity.Text = Convert.ToString(TrackBar_Carrying.Value);
        }

        private void Button_SaveToJSON_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(Button_SaveToJSON);
            /*
            airplane plane = new airplane(14223, "пассажирский", "модель", 2014, 200, 100);
            string json = JsonConvert.SerializeObject(plane);
            File.WriteAllText("airplane.json", json);
            */
        }

        private void Button_ReadFromJSON_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(Button_SaveToJSON);
            
            String str = "";
            //str = File.ReadAllText("airplane.json");
            //textBox2.Text = str;
            //airplane plane2 = new airplane();
            //airplane plane2 = JsonConvert.DeserializeObject(str, airplane);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String json = "";
            TextBox_JSON.Clear();
            json = File.ReadAllText(openFileDialog1.FileName);
            Airplane plane = JsonConvert.DeserializeObject<Airplane>(json);
            TextBox_JSON.AppendText(plane.ToString());
        }

        private void clear_Click(object sender, EventArgs e)
        {
            TextBox_JSON.Clear();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string path = saveFileDialog1.FileName;


          //  string json = Airplane.Save(plane);
            //File.WriteAllText(path, json);
        }

        private void Button_AddAirplane_Click(object sender, EventArgs e)
        {
            airplane = new Airplane();

            airplane.Id = Convert.ToInt16(TextBox_ID.Text);
            airplane.Type = Convert.ToString(ComboBox_type.SelectedItem);
            airplane.Model = Convert.ToString(ComboBox_model.SelectedItem);
            airplane.Year_of_issue = Convert.ToInt16(NumericUpDown_yearIssue.Value);
            airplane.Carrying = Convert.ToInt16(CarryingСapacity.Text);
            airplane.Maintenance = Convert.ToDateTime(DateTimePicker_Maintenance.Value);
            airplane.Seats = Convert.ToInt16(MaskedTextBox_seats.Text);

            airport.Add(airplane);

            string item = Convert.ToString(airplane.Id);
            ComboBox_Airplane.Items.Add(item);
        }

        private void Button_DeleteAirplane_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < airport.Count(); i++)
            {
                if (Convert.ToString(airport[i].Id) == Convert.ToString(ComboBox_Airplane.SelectedItem))
                {
                    airport.RemoveAt(i);
                    for(int j = 0; j < ComboBox_Airplane.Items.Count; j++)
                    {
                        if (Convert.ToString(ComboBox_Airplane.Items[j]) == deletedItem)
                        {
                            ComboBox_Airplane.Items.RemoveAt(j);
                            ComboBox_Airplane.Text = "";
                        }
                    }
                }
            }
        }

        private void ComboBox_Airplane_SelectedIndexChanged(object sender, EventArgs e)
        {
            deletedItem = Convert.ToString(ComboBox_Airplane.SelectedItem);
        }
    }
}
