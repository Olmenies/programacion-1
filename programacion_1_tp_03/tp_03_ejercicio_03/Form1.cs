using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_03_ejercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /********** Events **********/
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Check if input is valid
            bool isInputValid = ValidateInput(textBoxInput.Text);
            if (!isInputValid)
            {
                MessageBox.Show("Input is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                listBoxValues.Items.Add(textBoxInput.Text);
                textBoxInput.Clear();
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            float result = Add();
            labelResult.Text = $"Result: {result.ToString()}";
        }
        /********** Methods **********/
        /// <summary>
        /// This functions adds all the items in the listBox
        /// </summary>
        /// <returns>The result of adding all the values in the listBox</returns>
        public float Add()
        {
            float result = 0;
            foreach (string item in listBoxValues.Items)
            {
                result += float.Parse(item);
            }
            return result;
        }

        /// <summary>
        /// This function validates if the input is parsable to float
        /// </summary>
        /// <param name="input">Element to be tried to parse to float</param>
        /// <returns>true if the input is parseable to float or false if not</returns>
        public bool ValidateInput(string input)
        {
            return float.TryParse(input, out _);
        }
    }
}
