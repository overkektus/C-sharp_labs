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
    public partial class SearchOnCarrying : Form
    {
        Airport airport;

        public SearchOnCarrying(Airport _airport)
        {
            InitializeComponent();
            airport = _airport;
        }

        private void Button_SearchOnCarrying_Click(object sender, EventArgs e)
        {
            if (TrackBar_SearchOnCarrying.Value == 0)
            {
                MessageBox.Show("Enter animal age");
            }
            else
            {
                var objects = from Airplane item in airport
                              where item.Carrying.ToString() == TrackBar_SearchOnCarrying.Value.ToString()
                              select item;

                Result result = new Result(objects);
                result.Show();
                result.ShowResult();
            }
        }

        private void TrackBar_SearchOnCarrying_ValueChanged(object sender, EventArgs e)
        {
            Label_SearchOnCarrying.Text = Convert.ToString(TrackBar_SearchOnCarrying.Value);
        }

        public Airport GetAirport()
        {
            return airport;
        }

    }
}
