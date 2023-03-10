using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace tp_04_listas_ejercicio_01
{
    public partial class Form1 : Form
    {
        private DataTable dt = new DataTable();
        private MyList myList = new MyList();

        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
            InitializeDataGridView();
        }

        /********** Events *********/
        private void ButtonAddPatient_Click(object sender, EventArgs e)
        {
            MyNode newNode = new MyNode(TextBoxName.Text, TextBoxSurname.Text, TextBoxAddress.Text, TextBoxTel.Text);
            myList.AddNodeEnd(newNode);
            RefreshDataGridView();
        }

        private void ButtomRemoveSelectedPatient_Click(object sender, EventArgs e)
        {
            int selectedRow = DataGridViewPatient.SelectedRows[0].Index;
            myList.RemoveSelectedNode(selectedRow);
            RefreshDataGridView();
        }

        private void ButtonUpdatePatient_Click(object sender, EventArgs e)
        {
            int selectedRow = DataGridViewPatient.SelectedRows[0].Index;
            Debug.WriteLine(selectedRow.ToString());
            MyNode updatedNode = new MyNode(TextBoxName.Text, TextBoxSurname.Text, TextBoxAddress.Text, TextBoxTel.Text);
            myList.UpdateNode(selectedRow, updatedNode);
            RefreshDataGridView();
        }

        private void ButtonShowList_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void ButtonAddAfter_Click(object sender, EventArgs e)
        {
            int selectedRow = DataGridViewPatient.SelectedRows[0].Index;
            MyNode newNode = new MyNode(TextBoxName.Text, TextBoxSurname.Text, TextBoxAddress.Text, TextBoxTel.Text);
            myList.AddNodeAfter(selectedRow, newNode);
            RefreshDataGridView();
        }

        private void ButtonDummyLoad_Click(object sender, EventArgs e)
        {
            DummyData();
        }

        /********** Methods **********/
        private void InitializeDataTable()
        {
            dt.Columns.Add("Nombres", typeof(string));
            dt.Columns.Add("Apellidos", typeof(string));
            dt.Columns.Add("Dirección", typeof(string));
            dt.Columns.Add("Teléfono", typeof(string));
        }

        private void InitializeDataGridView()
        {
            DataGridViewPatient.DataSource = dt;

            DataGridViewPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewPatient.MultiSelect = false;
            DataGridViewPatient.ReadOnly = true;
            DataGridViewPatient.RowHeadersVisible = true;

        }

        private void DummyData()
        {
            for (int i = 0; i <= 10; i++)
            {
                MyNode newNode = new MyNode(i.ToString(), i.ToString(), i.ToString(), i.ToString());
                myList.AddNodeEnd(newNode);
            }
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dt.Clear();
            for (int i = 0; i < myList.Count; i++)
            {
                MyNode selectedNode = myList.GetNode(i);
                DataRow dr = dt.NewRow();

                dr["Nombres"] = selectedNode.Name;
                dr["Apellidos"] = selectedNode.Surname;
                dr["Dirección"] = selectedNode.Address;
                dr["Teléfono"] = selectedNode.Tel;

                dt.Rows.Add(dr);
            }
        }
    }
}