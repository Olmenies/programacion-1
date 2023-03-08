using Microsoft.VisualBasic.Logging;
using System.Diagnostics;

namespace tp_03_ejercicio_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /********** Events **********/
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            ListBox.Items.Clear();
            bool isInputValid = ValidateInput();
            if (isInputValid)
            {
                int[] primesArray = LookForPrimes(int.Parse(TextBoxMin.Text), int.Parse(TextBoxMax.Text));
                PrintToListBox(primesArray);
            }
        }

        /********** Methods **********/
        /// <summary>
        /// Validates if the input values are parseable to int
        /// </summary>
        /// <returns>True if values are parseable to int or false if not</returns>
        public bool ValidateInput()
        {
            foreach (Control control in GroupBoxInput.Controls)
            {
                if (control is TextBox)
                {
                    bool success = int.TryParse(control.Text, out _);
                    if (!success)
                    {
                        MessageBox.Show("Input is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if a provided number is prime
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool CheckIfPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                //if ((i == 1) || (i == 0)) { continue; }
                if ((num % i == 0)) { return false; }
            }
            return true;
        }

        /// <summary>
        /// Iterates between min and max values looking for primes numbers
        /// </summary>
        /// <param name="min">Minimum value</param>
        /// <param name="max">Maximum value</param>
        /// <returns>An array containing all prime numbers between the limits provided</returns>
        public static int[] LookForPrimes(int min, int max)
        {
            int[] ints = new int[0];
            for (int i = min; i < max; i++)
            {
                if ((i == 0) || (i == 1))
                {
                    continue;
                }
                else
                {
                    bool success = CheckIfPrime(i);
                    //if (success) { ListBox.Items.Add(i.ToString()); }
                    if (success)
                    {
                        Array.Resize(ref ints, ints.Length + 1);
                        ints[ints.Length - 1] = i;
                    }
                }
            }

            return ints;
        }

        /// <summary>
        /// Prints an array to a ListBox
        /// </summary>
        /// <param name="primesArray"></param>
        public void PrintToListBox(int[] primesArray)
        {
            foreach (int i in primesArray)
            {
                ListBox.Items.Add(i.ToString());
            }
        }
    }
}