using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komponent
{
    public partial class MainApp : Form, IMainApp
    {
        private import_datas imp_dat;
        private export_to_file exp_dat;
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
            imp_dat = new import_datas(dgvDataSetMainApp);
            exp_dat = new export_to_file();
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

            imp_dat.ImportData();

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

        private void button1_Click(object sender, EventArgs e)
        {
            exp_dat.ExportDataCreate(dgvDataSetMainApp);
        }
    }
}
