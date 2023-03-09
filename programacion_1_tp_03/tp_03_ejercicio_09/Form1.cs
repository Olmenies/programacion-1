using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace tp_03_ejercicio_09
{
    public partial class Form1 : Form
    {
        private readonly DataTable dt = new DataTable();
        private readonly Random r = new Random();
        private uint amountThrow = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
            InitializeDataGridView();
        }

        /********** Events *********/
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {

            int randomNumber = r.Next(1, 7);
            amountThrow++;
            UpdateAmount(randomNumber);
            UpdateRates();

            LabelResult.Text = $"Dice: {randomNumber}";
            LabelThrow.Text = $"Throwns: {amountThrow}";
        }

        /********** Methods *********/
        private void InitializeDataTable()
        {
            // Columns creation
            dt.Columns.Add("Number");
            dt.Columns.Add("Occurrences");
            dt.Columns.Add("Rate");

            // Rows creation
            for (int i = 0; i < 6; i++)
            {
                DataRow row = dt.NewRow();
                row["Number"] = i + 1;
                row["Occurrences"] = 0;
                row["Rate"] = 0;
                dt.Rows.Add(row);
            }

            DataColumn[] primaryKeyColumns = new DataColumn[1];
            primaryKeyColumns[0] = dt.Columns["Number"];
            dt.PrimaryKey = primaryKeyColumns;
        }

        private void InitializeDataGridView()
        {
            DataGridViewResults.DataSource = dt;
            DataGridViewResults.ReadOnly = true;
            DataGridViewResults.ColumnHeadersVisible = true;
            DataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void UpdateRates()
        {
            foreach (DataRow row in dt.Rows)
            {
                row["Rate"] = Convert.ToInt32(row["Occurrences"]) * 100 / amountThrow;
            }
        }

        private void UpdateAmount(int randomNumber)
        {
            DataRow rowToUpdate = dt.Rows.Find(randomNumber);
            rowToUpdate["Occurrences"] = Convert.ToInt32(rowToUpdate["Occurrences"]) + 1;
        }
    }
}