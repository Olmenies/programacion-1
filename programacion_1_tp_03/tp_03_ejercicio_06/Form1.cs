namespace tp_03_ejercicio_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /********** Events *********/
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            bool isInputValid = ValidateInput(TextBoxInput.Text);
            if (isInputValid)
            {
                uint[] fibonacciArray = GenerateFibonacci(uint.Parse(TextBoxInput.Text));
                PrintToListBox(fibonacciArray);
            }
        }

        /********* Methods *********/

        /// <summary>
        /// Validates if the input is parseable to uint
        /// </summary>
        /// <param name="input">Value to be evaluated</param>
        /// <returns></returns>
        private static bool ValidateInput(string input)
        {
            if (!uint.TryParse(input, out _))
            {
                MessageBox.Show("Input is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Generates the Fibonacci sequence
        /// </summary>
        /// <param name="maxNumber">Amount of elments of the sequence desired</param>
        /// <returns>An uint array with the Fibonacci sequence</returns>
        private static uint[] GenerateFibonacci(uint maxNumber)
        {
            uint[] tempArray = { 0, 1 };

            for (int i = 0; i < maxNumber; i++)
            {
                Array.Resize(ref tempArray, tempArray.Length + 1);
                tempArray[tempArray.Length - 1] = tempArray[tempArray.Length - 2] + tempArray[tempArray.Length - 3];
            }

            return tempArray;
        }

        /// <summary>
        /// Prints an array into a ListBox
        /// </summary>
        /// <param name="fibonacciArray">Array to be printed</param>
        private void PrintToListBox(uint[] fibonacciArray)
        {
            foreach (uint item in fibonacciArray)
            {
                ListBox.Items.Add(item.ToString());
            }
        }
    }
}