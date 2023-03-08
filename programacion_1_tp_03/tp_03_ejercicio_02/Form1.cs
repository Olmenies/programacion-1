using System.Diagnostics;

namespace tp_03_ejercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*********** Events **********/
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Ensure inputs are numbers            
            bool isInputValid = ValidateInput();

            // Conditional response according if the input is or not valid 
            if(isInputValid)
            {
                float result = Add(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
                resultLabel.Text = result.ToString();
            } else
            {
                MessageBox.Show("Provided input is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*********** Methods **********/
        /// <summary> This method adds to floats </summary>
        /// <param name="value0">The first float to be added</param>
        /// <param name="value1">The second float to be added</param>
        /// <returns>The sum of value0 and value1</returns>
        private static float Add(float value0, float value1)
        {
            return value0 + value1;
        }

        /// <summary> This method validates wether the input provided is a float or not </summary>
        /// <returns> true if all the inputs within the groupBox are numbers or false if not</returns>
        private bool ValidateInput()
        {
            foreach (TextBox textBox in inputGroupBox.Controls)
            {
                bool isValid = float.TryParse(textBox.Text, out float parsedInput);
                if (!isValid) { return false; }
            }
            return true;
        }
    }
}