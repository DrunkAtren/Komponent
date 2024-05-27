using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komponent
{
    public partial class AddDataSet : Form
    {
        private MainApp mainAppForm;

        public AddDataSet(MainApp mainApp)
        {
            InitializeComponent();
            mainAppForm = mainApp;
            PopulateColumnNamesFromMainApp();
        }

        private void PopulateColumnNamesFromMainApp()
        {
            if (mainAppForm != null)
            {
                List<string> columnNames = mainAppForm.GetColumnNames();
                foreach (string columnName in columnNames)
                {
                    cbSelectColumnFromMainApp.Items.Add(columnName);
                }
            }
        }

        private void btnSelectDataSet_Click(object sender, EventArgs e)
        {
            // Open File Dialog to select a .txt file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Select a Text File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    LoadDataFromFile(filePath);
                }
            }
        }

        private void LoadDataFromFile(string filePath)
        {
            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length > 0)
                {
                    // Clear the existing columns and rows
                    dgvSelectedDataSet.Columns.Clear();
                    dgvSelectedDataSet.Rows.Clear();

                    // Add the fixed columns "Slowo" and "wystepowanie"
                    dgvSelectedDataSet.Columns.Add("Slowo", "Slowo");
                    dgvSelectedDataSet.Columns.Add("wystepowanie", "wystepowanie [%]");

                    // Add rows to DataGridView, assuming each line in the file is a single word
                    foreach (string line in lines)
                    {
                        dgvSelectedDataSet.Rows.Add(line, null); // Set "wystepowanie" as null/empty
                    }
                }
                else
                {
                    MessageBox.Show("The file is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddToDVG_Click(object sender, EventArgs e)
        {
            var sum = dgvSelectedDataSet.Rows.Cast<DataGridViewRow>()
                .Where(row => !string.IsNullOrEmpty(row.Cells[1].Value?.ToString()))
                .Sum(row => int.Parse(row.Cells[1].Value.ToString()));

            // Check if the sum is greater than 100
            if (sum > 100)
            {
                MessageBox.Show("The sum of the percentages in column 2 exceeds 100. Please adjust the values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the sum is greater than 100
            }

            Random random = new Random();
            string selectedColumn = cbSelectColumnFromMainApp.SelectedItem?.ToString();
            int size = dgvSelectedDataSet.Rows.Count; //Rozmiar
            int NewSize = mainAppForm.GetRowCount();
            string[] tabela = new string[NewSize]; //Pusta Tabela
            List<int> indexes = RandomIndexes(NewSize);
            int integ = 0; //Iteracja
            var sortedData = dgvSelectedDataSet.Rows.Cast<DataGridViewRow>()
                        .Where(row => !string.IsNullOrEmpty(row.Cells[1].Value?.ToString()) && row.Cells[1].Value?.ToString() != "") // Filtrowanie wierszy, które nie są puste
                        .OrderBy(row => row.Cells[1].Value?.ToString());
            var remaining_elements = dgvSelectedDataSet.Rows.Cast<DataGridViewRow>()
                        .Where(row => string.IsNullOrEmpty(row.Cells[1].Value?.ToString()) && row.Cells[0].Value?.ToString() != null); // Zwraca rekordy, gdzie występuje pusta wartość

            List<DataGridViewRow> remainingList = remaining_elements.ToList();
            List<string> wordsList = new List<string>();
            foreach (var row in remainingList)
            {
                string cellValue = row.Cells[0].Value?.ToString();
                wordsList.Add(cellValue);
            }

            foreach (var row in sortedData)
            {
                // Pobieranie wartości z poszczególnych komórek w danym wierszu
                string firstCellValue = row.Cells[0].Value?.ToString();
                string secondCellValue = row.Cells[1].Value?.ToString();
                Console.WriteLine($"First Cell Value: {firstCellValue}, Second Cell Value: {secondCellValue}");

                int liczba_wypelnien = (int.Parse(secondCellValue) * NewSize) / 100;
                for (int j = 0; j < liczba_wypelnien; j++)
                {
                    int element = indexes[integ];
                    tabela[element] = firstCellValue;
                    integ += 1;
                }
            }
            if (wordsList.Count <= 0 && sum < 100)
            {
                for (int j = 0; j < NewSize; j++)
                {
                    if (tabela[j] == null)
                    {
                        tabela[j] = "";
                    }
                }
            }
            if (wordsList.Count <= 0 && sum == 100)
            {

            }
            else
            {
                for (int j = 0; j < NewSize; j++)
                {
                    if (tabela[j] == null)
                    {
                        int randomIndex = random.Next(0, wordsList.Count);

                        // Wyświetl wylosowane słowo
                        tabela[j] = wordsList[randomIndex];
                    }
                }
            }

            List<string> dataToAdd = tabela.ToList();
            if (selectedColumn != null)
            {
                MainApp mainApp = (MainApp)this.MdiParent; // Adjust this as needed if MainApp is not the MdiParent
                mainAppForm.AddDataToColumn(selectedColumn, dataToAdd);
            }
            else
            {
                MessageBox.Show("Selected column is null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<int> RandomIndexes(int size)
        {
            List<int> indexes = new List<int>();

            // Dodawanie indeksów do listy
            for (int i = 0; i < size; i++)
            {
                indexes.Add(i);
            }

            // Mieszanie indeksów
            Random rng = new Random();
            int n = indexes.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = indexes[k];
                indexes[k] = indexes[n];
                indexes[n] = value;
            }

            return indexes;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddDataSet_Load(object sender, EventArgs e)
        {

        }
    }
}
