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
        private import_datas imp_dat;
        private export_to_file exp_dat;
        private Histogram hist;
        private AddDataSet  addData;
        private int sc_value;
        private int brd_value;
        private int row_ite;
        private Boolean tr_val;
        private string dictPath;
        private void sethistvalues()
        {
            hist.setScaleStepValue(sc_value);
            hist.setLegendItemsPerRow(row_ite);
            hist.setBarWidthValue(brd_value);
        }
        private void setaddvalues()
        {
            addData.setDefaultDictPath(dictPath);
            addData.setAutoImportDict(tr_val);
            Console.WriteLine(tr_val);
        }

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
            setComboBox();
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
                addData = new AddDataSet(this, tr_val, dictPath );
                addData.Show();
            setaddvalues();
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            ClearTable();

            imp_dat.ImportCustomData();
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

        private void setComboBox()
        {

            fileType.Items.Add("text");
            fileType.Items.Add("csv");
            fileType.Items.Add("json");
            comboBox2.Items.AddRange(Enum.GetNames(typeof(KnownColor)));
            comboBox3.Items.AddRange(Enum.GetNames(typeof(KnownColor)));


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void btnGoToHistogram_Click(object sender, EventArgs e)
        {
                hist = new Histogram(this);
                sethistvalues();
                hist.Show();

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

        private void fileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fileType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            fileType.SelectedIndex = 2;
            fileName.Text = "default_data";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            imp_dat.setImportExtension(fileType.Text);
            imp_dat.setImportFilename(fileName.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            fileName.Text = "exported_data_set";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exp_dat.setFormat(comboBox1.Text);
            exp_dat.setFilename(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numericUpDown3.Value = 20;
            numericUpDown2.Value = 20;
            numericUpDown1.Value = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sc_value = (int)numericUpDown2.Value;
            row_ite = (int)numericUpDown1.Value;
            brd_value = (int)numericUpDown3.Value;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            textBox2.Text = "src/dictionares/kraje.txt";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dictPath =  textBox2.Text;
            tr_val = checkBox1.Checked;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int borderThickness = (int)numericUpDown5.Value;

            // Set the border thickness for all cells in the DataGridView
            dgvDataSetMainApp.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;

            // Update the border thickness
            dgvDataSetMainApp.AdvancedCellBorderStyle.Top = (DataGridViewAdvancedCellBorderStyle)borderThickness;
            dgvDataSetMainApp.AdvancedCellBorderStyle.Bottom = (DataGridViewAdvancedCellBorderStyle)borderThickness;
            dgvDataSetMainApp.AdvancedCellBorderStyle.Left = (DataGridViewAdvancedCellBorderStyle)borderThickness;
            dgvDataSetMainApp.AdvancedCellBorderStyle.Right = (DataGridViewAdvancedCellBorderStyle)borderThickness;
        }

        

        private void button11_Click(object sender, EventArgs e)
        {

            int borderThickness = (int)numericUpDown5.Value;

            // Set the cell border style to Single
            dgvDataSetMainApp.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // Set the desired border width
            dgvDataSetMainApp.AdvancedCellBorderStyle.Top = (DataGridViewAdvancedCellBorderStyle)borderThickness;
            dgvDataSetMainApp.AdvancedCellBorderStyle.Bottom = (DataGridViewAdvancedCellBorderStyle)borderThickness;
            dgvDataSetMainApp.AdvancedCellBorderStyle.Left = (DataGridViewAdvancedCellBorderStyle)borderThickness;
            dgvDataSetMainApp.AdvancedCellBorderStyle.Right = (DataGridViewAdvancedCellBorderStyle)borderThickness;


            if (comboBox2.SelectedIndex != -1)
            {
                Color selectedColor = Color.FromName(comboBox2.SelectedItem.ToString());

                // Loop through each cell in the DataGridView
                foreach (DataGridViewRow row in dgvDataSetMainApp.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Set the background color of the cell
                        cell.Style.BackColor = selectedColor;
                    }
                }
            }


            if (comboBox3.SelectedIndex != -1)
            {
                Color selectedColor2 = Color.FromName(comboBox3.SelectedItem.ToString());
                foreach (DataGridViewRow row in dgvDataSetMainApp.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.ForeColor = selectedColor2; // Możesz zmienić na dowolny inny kolor
                    }
                }
            }


        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }

}
