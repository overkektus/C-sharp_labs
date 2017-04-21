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
    public partial class MainForm : Form
    {
        Airport airport;
        Airplane airplane;
        Member member;

        string deletedItem;
        string deletedMember;

        public MainForm()
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
        }

        private void Button_ReadFromJSON_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(Button_SaveToJSON);
            
            String str = "";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String json = "";
            TextBox_JSON.Clear();
            json = File.ReadAllText(openFileDialog1.FileName);
           // Airport airport = JsonConvert.DeserializeObject<Airport>(json);
            TextBox_JSON.AppendText(json);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            TextBox_JSON.Clear();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        string path = saveFileDialog1.FileName;
        string json = JsonConvert.SerializeObject(airport, Formatting.Indented);

        File.WriteAllText(path, json);
        }

        private void Button_AddAirplane_Click(object sender, EventArgs e)
        {
            if (!Check_Errors_Airplane())
            {
                try
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

                    ComboBox_Airplane.Items.Add(Convert.ToString(airplane.Id));
                    ComboBox_ListMembers.Items.Clear();


//                    SuccessAdd success = new SuccessAdd();
//                    success.Show();
                }
                catch (Exception) { }
            }
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

        private void MaskedTextBox_seats_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(MaskedTextBox_seats, "От 5 до 500 мест");
        }

        private void Button_AddAirplane_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(Button_AddAirplane, "Добавить самолет в аэропорт");
        }

        private void Button_DeleteAirplane_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(Button_DeleteAirplane, "Удалить самолет из аэропорт");
        }

        private void TextBox_ID_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void ComboBox_type_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void ComboBox_model_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void MaskedTextBox_seats_Enter(object sender, EventArgs e)
        {
            Error.Clear();
        }

        private void Button_AddToPlane_Click(object sender, EventArgs e)
        {
            if (!Check_Errors_Member())
            {
                try
                {
                    member = new Member();

                    member.Name = Convert.ToString(TextBox_FIO.Text);
                    member.Position = Convert.ToString(ComboBox_position.SelectedItem);
                    member.Age = Convert.ToUInt16(NumericUpDown_age.Value);
                    member.Experience = Convert.ToUInt16(NumericUpDown_exp.Value);

                    airplane.Add(member);

                    ComboBox_ListMembers.Items.Add(Convert.ToString(member.Name));
                }
                catch (Exception) { }
            }
        }

        private void Button_DeleteFromPlane_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < airplane.Count(); i++)
            {
                if (Convert.ToString(airplane[i].Name) == Convert.ToString(ComboBox_ListMembers.SelectedItem))
                {
                    airplane.RemoveAt(i);
                    for (int j = 0; j < ComboBox_ListMembers.Items.Count; j++)
                    {
                        if (Convert.ToString(ComboBox_ListMembers.Items[j]) == deletedMember)
                        {
                            ComboBox_ListMembers.Items.RemoveAt(j);
                            ComboBox_ListMembers.Text = "";
                        }
                    }
                }
            }
        }

        private bool Check_Errors_Airplane()
        {
            try
            {
                if (TextBox_ID.Text == "")
                    Error.SetError(TextBox_ID, "Введите ID");
                else
                    Error.Clear();

                if (ComboBox_type.Items.IndexOf(ComboBox_type.Text) < 0)
                    Error.SetError(ComboBox_type, "Выберите тип самолета");
                else
                    Error.Clear();

                if (ComboBox_model.Items.IndexOf(ComboBox_model.Text) < 0)
                    Error.SetError(ComboBox_model, "Выберите модель самолета");
                else
                    Error.Clear();

                if (MaskedTextBox_seats.Text == "")
                    Error.SetError(MaskedTextBox_seats, "Введите количество мест");
                else
                    Error.Clear();

                if (Convert.ToInt16(MaskedTextBox_seats.Text) > 500 ||
                    Convert.ToInt16(MaskedTextBox_seats.Text) < 5)
                    Error.SetError(MaskedTextBox_seats, "Некорректное значение");
                else
                    Error.Clear();
            }
            catch (Exception) { }

            if (Error.GetError(TextBox_ID) != "Введите ID" &&
                Error.GetError(ComboBox_type) != "Выберите тип самолета" &&
                Error.GetError(ComboBox_model) != "Выберите модель самолета" &&
                Error.GetError(MaskedTextBox_seats) != "Введите количество мест" &&
                Error.GetError(MaskedTextBox_seats) != "Некорректное значение")
                return false;
            else return true;
        }

        private bool Check_Errors_Member()
        {
            try
            {
                if (TextBox_FIO.Text == "")
                    Error.SetError(TextBox_FIO, "Введите ФИО");
                else
                    Error.Clear();

                if (ComboBox_position.Items.IndexOf(ComboBox_position.Text) < 0)
                    Error.SetError(ComboBox_position, "Выберите должность");
                else
                    Error.Clear();

            }
            catch (Exception) { }

            if (Error.GetError(TextBox_FIO) != "Введите ФИО" &&
                Error.GetError(ComboBox_position) != "Выберите должность")
                return false;
            else return true;
        }

        private void ComboBox_ListMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            deletedMember = Convert.ToString(ComboBox_ListMembers.SelectedItem);
        }

    }
}
