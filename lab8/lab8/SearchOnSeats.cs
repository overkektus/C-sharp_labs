using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class SearchOnSeats : Form
    {
        Airport airport;

        public SearchOnSeats(Airport _airport)
        {
            InitializeComponent();
            airport = _airport;
        }

        private void Button_SearchOnSeats_Click(object sender, EventArgs e)
        {
            if (TextBox_SearachOnSeats.Text == "")
            {
                MessageBox.Show("Введите количество мест");
            }
            else
            {
                Result result = null;
                Regex regex = new Regex(TextBox_SearachOnSeats.Text.ToString(), RegexOptions.IgnoreCase);
                foreach (Airplane item in airport)
                {
                    if (regex.IsMatch(item.Seats.ToString()))
                    {
                        var objects = from Airplane it in airport
                                      where it.Seats.ToString() == item.Seats.ToString()
                                      select it;
                        result = new Result(objects);
                    }
                }
                if (result != null)
                {
                    result.Show();
                    result.ShowResult();
                }
                else
                    MessageBox.Show("No matches where found");
            }
        }

        public Airport GetAirport()
        {
            return airport;
        }
    }
}
