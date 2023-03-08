using System.Data;

namespace tp_03_ejercicio_07
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        /*********** Events *********/
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {

            bool isInputValid = ValidateInput();
            if (isInputValid)
            {
                float amount = float.Parse(TextBoxAmount.Text);
                float tna = float.Parse(TextBoxTNA.Text);
                float days = float.Parse(TextBoxDays.Text);
                
                float result = CalculateTotal(amount, tna, days);
                SaveToDataTable(amount, tna, days, result);
            }
        }

        /********* Methods *********/
        /// <summary>
        /// Validates if the inputs are parseable to float
        /// </summary>
        /// <returns></returns>
        private bool ValidateInput()
        {
            //@@@TODO: This coud be improved
            if (float.TryParse(TextBoxAmount.Text, out float amount))
            {
                if (amount < 0)
                {
                    MessageBox.Show("Amount can't be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Amount is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (float.TryParse(TextBoxTNA.Text, out float tna))
            {
                if (tna < 0)
                {
                    MessageBox.Show("TNA can't be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("TNA is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!uint.TryParse(TextBoxDays.Text, out _))
            {
                MessageBox.Show("Days input is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Calculates the interest using the formula amount * tna * days / 36500 
        /// </summary>
        /// <param name="amount">Amount of money to be used</param>
        /// <param name="tna">TNA</param>
        /// <param name="days">Amount of days</param>
        /// <returns>Returns the interests</returns>
        private static float CalculateTotal(float amount, float tna, float days)
        {
            return amount * tna * days / 365000;
        }

        /// <summary>
        /// Initializes a new DataTable and sets some configuration to DataGridView
        /// </summary>
        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Amount", typeof(float));
            dataTable.Columns.Add("TNA", typeof(float));
            dataTable.Columns.Add("Days", typeof(float));
            dataTable.Columns.Add("Total", typeof(float));

            DataGridViewResult.DataSource = dataTable;
            DataGridViewResult.ReadOnly = true;
            DataGridViewResult.ColumnHeadersVisible = true;
        }

        /// <summary>
        /// Saves data to a DataTable
        /// </summary>
        /// <param name="amount">Amount of money to be used</param>
        /// <param name="tna">TNA</param>
        /// <param name="days">Amount of days</param>
        /// <param name="total">Interests</param>
        private void SaveToDataTable(float amount, float tna, float days, float total)
        {
            DataRow row = dataTable.NewRow();
            row["Amount"] = float.Parse(TextBoxAmount.Text);
            row["TNA"] = float.Parse(TextBoxTNA.Text);
            row["Days"] = float.Parse(TextBoxDays.Text);
            row["Total"] = total;

            dataTable.Rows.Add(row);
        }
    }
}