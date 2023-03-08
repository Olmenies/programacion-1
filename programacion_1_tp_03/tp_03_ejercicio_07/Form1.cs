using System.Data;

namespace tp_03_ejercicio_07
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
            
            dataTable = new DataTable();
            dataTable.Columns.Add("Amount", typeof(float));
            dataTable.Columns.Add("TNA", typeof(float));
            dataTable.Columns.Add("Days", typeof(float));
            dataTable.Columns.Add("Total", typeof(float));

            DataGridViewResult.DataSource = dataTable;
            DataGridViewResult.ReadOnly = true;
            DataGridViewResult.ColumnHeadersVisible = true;
        }

        /*********** Events *********/
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {

            bool isInputValid = ValidateInput();
            if (isInputValid)
            {
                MessageBox.Show("Cumbia");
                float result = CalculateTotal(float.Parse(TextBoxAmount.Text), float.Parse(TextBoxTNA.Text), float.Parse(TextBoxDays.Text));
                DataRow row = dataTable.NewRow();
                row["Amount"] = float.Parse(TextBoxAmount.Text);
                row["TNA"] = float.Parse(TextBoxTNA.Text);
                row["Days"] = float.Parse(TextBoxDays.Text);
                row["Total"] = result;

                dataTable.Rows.Add(row);   
            }
        }

        /********* Methods *********/
        private bool ValidateInput()
        {
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

        private static float CalculateTotal(float amount, float tna, float days)
        {
            return amount * tna * days / 365000;
        }

    }
}