using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komponent
{
    public partial class MainApp : Form, IMainApp
    {
        public DataGridViewRowCollection GetRows()
        {
            return dgvDataSetMainApp.Rows;
        }
        public DataGridViewColumnCollection GetColumns()
        {
            return dgvDataSetMainApp.Columns;
        }
        public DataGridViewRow GetRowById(int Index)
        {
            return dgvDataSetMainApp.Rows[Index];
        }
        public DataGridViewColumn GetColumnById(int Index)
        {
            return dgvDataSetMainApp.Columns[Index];
        }
        public int GetRowCount()
        {
            return dgvDataSetMainApp.Rows.Count;
        }
        public int GetColumnCount()
        {
            return dgvDataSetMainApp.Columns.Count;
        }
        public List<string> GetColumnNames()
        {
            List<string> columnNames = new List<string>();
            foreach (DataGridViewColumn column in dgvDataSetMainApp.Columns)
            {
                columnNames.Add(column.HeaderText);
            }
            return columnNames;
        }
        public void AddDataToColumn(string columnName, List<string> data)
        {
            if (!dgvDataSetMainApp.Columns.Contains(columnName))
            {
                // Jeśli kolumna nie istnieje, dodaj ją do DataGridView
                dgvDataSetMainApp.Columns.Add(columnName, columnName);
            }
            // Find the index of the column
            int columnIndex = dgvDataSetMainApp.Columns[columnName].Index;

            // Ensure the number of rows in the DataGridView is at least equal to the length of the data array
            while (dgvDataSetMainApp.Rows.Count < data.Count)
            {
                dgvDataSetMainApp.Rows.Add(); // Add new rows to match the length of the data array
            }

            // Update the column with new data
            for (int i = 0; i < data.Count; i++)
            {
                dgvDataSetMainApp.Rows[i].Cells[columnIndex].Value = data[i];
            }

            // Clear the remaining rows if there are more rows in the DataGridView than elements in the data array
            for (int i = data.Count; i < dgvDataSetMainApp.Rows.Count; i++)
            {
                dgvDataSetMainApp.Rows[i].Cells[columnIndex].Value = null;
            }
        }
        public MainApp()
        {
            InitializeComponent();
        }

        public List<string> GetColumnData(string columnName)
        {
            List<string> columnData = new List<string>();
            foreach (DataGridViewRow row in dgvDataSetMainApp.Rows)
            {
                string cellValue = row.Cells[columnName].Value?.ToString() ?? "";
                columnData.Add(cellValue);
            }
            return columnData;
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            string columnName = tbColumnName.Text;

            // Sprawdź, czy nazwa kolumny jest pusta
            if (string.IsNullOrWhiteSpace(columnName))
            {
                MessageBox.Show("Nazwa kolumny nie może być pusta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdź, czy nazwa kolumny już istnieje
            if (dgvDataSetMainApp.Columns.Contains(columnName))
            {
                MessageBox.Show("Kolumna o tej nazwie już istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dgvDataSetMainApp.Columns.Add(columnName, columnName);
            }

            tbColumnName.Clear();
            tbColumnName.Focus();
        }

        private void btnAnotherDataSet_Click(object sender, EventArgs e)
        {
            var myForm = new CreateDataSet();
            myForm.Show();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
  
        }

        private void btnAddDataSet_Click(object sender, EventArgs e)
        {
            var myForm = new AddDataSet(this);
            myForm.Show();
        }

        private void btnDefaultDataSet_Click(object sender, EventArgs e)
        {
            ClearTable();
            // Dodaj przykładowe kolumny
            dgvDataSetMainApp.Columns.Add("ID", "ID");
            dgvDataSetMainApp.Columns.Add("Name", "Name");
            dgvDataSetMainApp.Columns.Add("Age", "Age");

            // Dodaj przykładowe dane
            dgvDataSetMainApp.Rows.Add("1", "John", "30");
            dgvDataSetMainApp.Rows.Add("2", "Alice", "25");
            dgvDataSetMainApp.Rows.Add("3", "Bob", "40");
            dgvDataSetMainApp.Rows.Add("4", "Emily", "35");
            dgvDataSetMainApp.Rows.Add("5", "Michael", "45");
            dgvDataSetMainApp.Rows.Add("6", "Sarah", "28");
            dgvDataSetMainApp.Rows.Add("7", "David", "33");
            dgvDataSetMainApp.Rows.Add("8", "Emma", "22");
            dgvDataSetMainApp.Rows.Add("9", "James", "50");
            dgvDataSetMainApp.Rows.Add("10", "Olivia", "27");
            dgvDataSetMainApp.Rows.Add("11", "William", "38");
            dgvDataSetMainApp.Rows.Add("12", "Sophia", "42");
            dgvDataSetMainApp.Rows.Add("13", "Benjamin", "29");
            dgvDataSetMainApp.Rows.Add("14", "Charlotte", "32");
            dgvDataSetMainApp.Rows.Add("15", "Daniel", "37");
            dgvDataSetMainApp.Rows.Add("16", "Ava", "24");
            dgvDataSetMainApp.Rows.Add("17", "Matthew", "31");
            dgvDataSetMainApp.Rows.Add("18", "Grace", "26");
            dgvDataSetMainApp.Rows.Add("19", "Ethan", "41");
            dgvDataSetMainApp.Rows.Add("20", "Lily", "34");
        }

        private void btnGoToEditColumn_Click(object sender, EventArgs e)
        {
            var myForm = new EditColumns(this);
            myForm.Show();
        }
        private void ClearTable()
        {
            dgvDataSetMainApp.Columns.Clear();
            dgvDataSetMainApp.Rows.Clear();
        }
        private void btnSetMaxRek_Click(object sender, EventArgs e)
        {
            int maxRowCountValue = (int)maxColumnHeight.Value; // Pobierz wartość z kontrolki NumericUpDown

            // Iteruj przez każdy wiersz w DataGridView
            for (int i = 0; i < maxRowCountValue; i++)
            {
                // Jeśli liczba wierszy w DataGridView jest mniejsza niż maxRowCountValue, dodaj nowy wiersz
                if (i >= dgvDataSetMainApp.Rows.Count)
                {
                    dgvDataSetMainApp.Rows.Add();
                }

                // Iteruj przez każdą komórkę w danym wierszu
                foreach (DataGridViewCell cell in dgvDataSetMainApp.Rows[i].Cells)
                {
                    // Ustaw wartość komórki na pusty łańcuch
                    cell.Value = "";
                }
            }

            MessageBox.Show($"Wypełniono wszystkie obecne kolumny pustymi wartościami do rekordu {maxRowCountValue}.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {

            ClearTable();
        }

        private void btnGoToHistogram_Click(object sender, EventArgs e)
        {
                var myForm = new Histogram(this);
                myForm.Show();

        }

        /*public DataTable GetDataTableFromDataGridView()
        {
            DataTable dataTable = new DataTable();

            foreach (DataGridViewColumn column in dgvDataSetMainApp.Columns)
            {
                dataTable.Columns.Add(column.HeaderText, typeof(string));
            }

            foreach (DataGridViewRow row in dgvDataSetMainApp.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value?.ToString() ?? string.Empty;
                }
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }*/

        private void columnChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
