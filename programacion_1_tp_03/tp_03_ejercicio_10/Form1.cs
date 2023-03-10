using System.Data;
using System.Diagnostics;

namespace tp_03_ejercicio_10
{
    public partial class Form1 : Form
    {
        private DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
            InitializeDataGridView();
        }

        /********** Events **********/
        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            float celsius = 0, fahrenheit = 0, kelvin = 0, inputValue = 0;
            bool isInputValid = ValidateInput(TextBoxInput.Text);
            if(isInputValid )
            {
                inputValue = float.Parse(TextBoxInput.Text);
                foreach (Control control in GroupBoxRadioButtons.Controls)
                {
                    if (control is RadioButton)
                    {
                        string selectedScale = control.Text;

                        if (selectedScale == "Celsius")
                        {
                            celsius = inputValue;
                            fahrenheit = CelsiusToFahrenheit(inputValue);
                            kelvin = CelsiusToKelvin(inputValue);
                        }
                        else if (selectedScale == "Fahrenheit")
                        {
                            fahrenheit = inputValue;
                            celsius = FahrenheitToCelsius(inputValue);
                            kelvin = FahrenheitToKelvin(inputValue);
                        }
                        else if (selectedScale == "Kelvin")
                        {
                            kelvin = inputValue;
                            celsius = KelvinToCelsius(inputValue);
                            fahrenheit = KelvinToFahrenheit(inputValue);
                        }
                    }
                }
                AddRow(celsius, fahrenheit, kelvin);
                TextBoxInput.Clear();
            }
        }

        /********** Methods **********/
        /// <summary>
        /// Initializes a DataTable defining amount of columns
        /// </summary>
        private void InitializeDataTable()
        {
            // Create columns
            dt.Columns.Add("Celsius");
            dt.Columns.Add("Fahrenheit");
            dt.Columns.Add("Kelvin");

            // Create rows
            // Define primaryKey
        }

        /// <summary>
        /// Sets some default properties of a DataGridView such as ReadOnly and DataSource
        /// </summary>
        private void InitializeDataGridView()
        {
            DataGridViewResults.DataSource = dt;

            DataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewResults.ColumnHeadersVisible = true;
            DataGridViewResults.ReadOnly = true;
        }

        /// <summary>
        /// Adds a new row to a DataTable
        /// </summary>
        /// <param name="c">Temperature in Celsius scale</param>
        /// <param name="f">Temperature in Fahrenheit scale</param>
        /// <param name="k">Temperature in Kelvin scale</param>
        private void AddRow(float c, float f, float k)
        {
            DataRow dr = dt.NewRow();
            dr["Celsius"] = c;
            dr["Fahrenheit"] = f;
            dr["Kelvin"] = k;

            dt.Rows.Add(dr);
        }

        /// <summary>
        /// Validates if the input is parseable to float
        /// </summary>
        /// <param name="inputValue">Value to be tested</param>
        /// <returns>true if value is parseable to float and false if not</returns>
        private static bool ValidateInput(string inputValue)
        {

            if(float.TryParse(inputValue, out _))
            {
                return true;
            } else
            {
                MessageBox.Show("Input is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Converts provided number from Celsius scale to Fahnrenheit scale
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static float CelsiusToFahrenheit(float c)
        {
            return (c * 9 / 5) + 32;
        }

        /// <summary>
        /// Converts provided number from Celsius scale to Kelvin scale
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static float CelsiusToKelvin(float c)
        {
            return c + 273.73f;
        }

        /// <summary>
        /// Converts provided number from Fahrenheit scale to Celsius scale
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        private static float FahrenheitToCelsius(float f)
        {
            return (f - 32) * 5 / 9;
        }

        /// <summary>
        /// Converts provided number from Fahrenheit scale to Kelvin scale
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        private static float FahrenheitToKelvin(float f)
        {
            return (f - 32) * 5 / 9 + 273.15f;
        }

        /// <summary>
        /// Converts provided number from Kelvin scale to Celsius scale
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        private static float KelvinToCelsius(float k)
        {
            return k - 273.15f;
        }

        /// <summary>
        /// Converts provided number from Kelvin scale to Fahrenheit scale
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        private static float KelvinToFahrenheit(float k)
        {
            return (k - 273) * 9 / 5 + 32;
        }
    }
}