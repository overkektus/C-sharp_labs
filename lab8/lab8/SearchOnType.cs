using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class SearchOnType : Form
    {
        Airport airport;

        public SearchOnType(Airport _airport)
        {
            InitializeComponent();
            airport = _airport;
        }

        private void Button_SearchOnSeats_Click(object sender, EventArgs e)
        {
            if (ComboBox_SearchOnType.Items.IndexOf(ComboBox_SearchOnType.Text) < 0)
            {
                MessageBox.Show("Enter data on blank");
            }
            else
            {
                var objects = from Airplane item in airport
                              where item.Type.ToString() == ComboBox_SearchOnType.Text.ToString()
                              select item;

                Result result = new Result(objects);
                result.Show();
                result.ShowResult();
            }
        }

        public Airport GetAirport()
        {
            return airport;
        }
    }
}
