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
    public partial class Result : Form
    {
        IEnumerable<Airplane> airplane;
        Airport airport;
        int currentRow;

        public Result(IEnumerable<Airplane> _airplane)
        {
            InitializeComponent();
            InitFirstRow();
            currentRow = 0;
            airplane = _airplane;
        }

        public Result(Airport _airport)
        {
            InitializeComponent();
            InitFirstRow();
            currentRow = 0;
            airport = _airport;
        }

        private void InitFirstRow()
        {
            for (int x = 0; x < 7; x++)
            {
                DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn();
                Column.Width = 115;
                DataGridView_Result.Columns.Add(Column);
            }
            DataGridView_Result.Rows.Add("ID", "Тип", "Модель", "Год выпуска", "Кол-во мест", "Грузоподъёмность", "Дата последнего ТО");
        }

        public void ShowResult()
        {
            foreach (Airplane item in airplane)
            {
                DataGridView_Result.Rows.Add();
                currentRow++;
                DataGridView_Result.Rows[currentRow].Cells[0].Value = item.Id;
                DataGridView_Result.Rows[currentRow].Cells[1].Value = item.Type;
                DataGridView_Result.Rows[currentRow].Cells[2].Value = item.Model;
                DataGridView_Result.Rows[currentRow].Cells[3].Value = item.Year_of_issue;
                DataGridView_Result.Rows[currentRow].Cells[4].Value = item.Seats;
                DataGridView_Result.Rows[currentRow].Cells[5].Value = item.Carrying;
                DataGridView_Result.Rows[currentRow].Cells[6].Value = item.Maintenance;
            }
        }

        public void ShowResultAirport()
        {
            foreach (Airplane item in airport)
            {
                DataGridView_Result.Rows.Add();
                currentRow++;
                DataGridView_Result.Rows[currentRow].Cells[0].Value = item.Id;
                DataGridView_Result.Rows[currentRow].Cells[1].Value = item.Type;
                DataGridView_Result.Rows[currentRow].Cells[2].Value = item.Model;
                DataGridView_Result.Rows[currentRow].Cells[3].Value = item.Year_of_issue;
                DataGridView_Result.Rows[currentRow].Cells[4].Value = item.Seats;
                DataGridView_Result.Rows[currentRow].Cells[5].Value = item.Carrying;
                DataGridView_Result.Rows[currentRow].Cells[6].Value = item.Maintenance;
            }
        }

        public Airport GetAirport()
        {
            return airport;
        }
    }
}
