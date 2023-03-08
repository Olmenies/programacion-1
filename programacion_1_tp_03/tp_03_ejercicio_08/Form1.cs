namespace tp_03_ejercicio_08
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            LabelResult.Text = random.Next(1, 7).ToString();
        }
    }
}