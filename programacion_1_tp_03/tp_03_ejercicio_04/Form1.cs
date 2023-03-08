using System.Runtime.InteropServices;

namespace tp_03_ejercicio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /********** Events **********/
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Input is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                float result = Add(float.Parse(TextBoxInput0.Text), float.Parse(TextBoxInput1.Text));
                LabelResult.Text = $"Result: {result}";
            }
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Input is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float result = Minus(float.Parse(TextBoxInput0.Text), float.Parse(TextBoxInput1.Text));
                LabelResult.Text = $"Result: {result}";
            }
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Input is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float result = Multiply(float.Parse(TextBoxInput0.Text), float.Parse(TextBoxInput1.Text));
                LabelResult.Text = $"Result: {result}";
            }
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Input is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float result = Divide(float.Parse(TextBoxInput0.Text), float.Parse(TextBoxInput1.Text));
                LabelResult.Text = $"Result: {result}";
            }
        }

        /********** Methods **********/
        /// <summary>
        /// Validates if the input is parseable to float
        /// </summary>
        /// <returns>true if all the inputs are parseable to float or false if not</returns>
        public bool ValidateInput()
        {
            foreach(TextBox textBox in GroupBoxInput.Controls)
            {
                bool success = float.TryParse(textBox.Text, out _);
                if (!success)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        ///    Adds two numbers
        /// </summary>
        /// <param name="a">First value to be added</param>
        /// <param name="b">Second value to be added</param>
        /// <returns>Result of a + b</returns>
        public static float Add(float a, float b)
        {
            return a + b;
        }

        /// <summary>
        ///    Subtracts two numbers
        /// </summary>
        /// <param name="a">Minuendo</param>
        /// <param name="b">Sustraendo</param>
        /// <returns>Result of a - b</returns>
        /// 
        public static float Minus(float a, float b)
        {
            return a - b;
        }

        /// <summary>
        ///    Multiplies two numbers
        /// </summary>
        /// <param name="a">First value to be multiplied</param>
        /// <param name="b">Second value to be multiplied</param>
        /// <returns>Result of a * b</returns>
        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        /// <summary>
        ///    Divides two numbers
        /// </summary>
        /// <param name="a">Divisendo</param>
        /// <param name="b">Divisor</param>
        /// <returns>Result of a / b or infinite if b is 0</returns>
        public static float Divide(float a, float b)
        {
            return a / b;
        }

    }
}