using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komponent
{
    public partial class EditColumns : Form
    {
        private MainApp mainAppForm;
        private List<string> editedDataList;
        private List<string> newDataList;
        public EditColumns(MainApp mainApp)
        {
            InitializeComponent();
            mainAppForm = mainApp;
            editedDataList = new List<string>();
            newDataList = new List<string>();
            PopulateColumnNamesFromMainApp();
        }
        private void PopulateColumnNamesFromMainApp()
        {
            if (mainAppForm != null)
            {
                List<string> columnNames = mainAppForm.GetColumnNames();
                foreach (string columnName in columnNames)
                {
                    cbColumnForEdit.Items.Add(columnName);
                    cbFirstColumn.Items.Add(columnName);
                    cbSecondColumn.Items.Add(columnName);
                }
            }
        }
        private void btnSliceLeft_Click(object sender, EventArgs e)
        {
            // Pobierz nazwę wybranej kolumny
            string selectedColumnName = cbColumnForEdit.SelectedItem?.ToString();

            // Sprawdź, czy wybrano kolumnę
            if (string.IsNullOrEmpty(selectedColumnName))
            {
                MessageBox.Show("Proszę wybrać kolumnę do przetworzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz liczbe znaków do wycięcia z lewej strony
            int leftSlice = (int)LeftSlice.Value;

            // Pobierz dane z wybranej kolumny z formularza MainApp
            List<string> columnData = new List<string>();
            if (mainAppForm != null)
            {
                // Wywołaj metodę MainApp, aby pobrać dane z wybranej kolumny
                columnData = mainAppForm.GetColumnData(selectedColumnName);
            }

            // Ucinamy dane z lewej strony
            editedDataList = columnData.Select(data =>
            data.Length > leftSlice ? data.Substring(leftSlice) : "").ToList();
            ShowNewDataList();
        }

        private void btnSliceRight_Click(object sender, EventArgs e)
        {
            // Pobierz nazwę wybranej kolumny
            string selectedColumnName = cbColumnForEdit.SelectedItem?.ToString();

            // Sprawdź, czy wybrano kolumnę
            if (string.IsNullOrEmpty(selectedColumnName))
            {
                MessageBox.Show("Proszę wybrać kolumnę do przetworzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz liczbe znaków do wycięcia z prawej strony
            int rightSlice = (int)LeftSlice.Value;

            // Pobierz dane z wybranej kolumny z formularza MainApp
            List<string> columnData = new List<string>();
            if (mainAppForm != null)
            {
                // Wywołaj metodę MainApp, aby pobrać dane z wybranej kolumny
                columnData = mainAppForm.GetColumnData(selectedColumnName);
            }

            // Ucinamy dane z prawej strony
            editedDataList = columnData.Select(data =>
                data.Length > rightSlice ? data.Substring(0, data.Length - rightSlice) : "").ToList();
            ShowNewDataList();
        }

        private void btnMirror_Click(object sender, EventArgs e)
        {
            // Pobierz nazwę wybranej kolumny
            string selectedColumnName = cbColumnForEdit.SelectedItem?.ToString();

            // Sprawdź, czy wybrano kolumnę
            if (string.IsNullOrEmpty(selectedColumnName))
            {
                MessageBox.Show("Proszę wybrać kolumnę do przetworzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz dane z wybranej kolumny z formularza MainApp
            List<string> columnData = new List<string>();
            if (mainAppForm != null)
            {
                // Wywołaj metodę MainApp, aby pobrać dane z wybranej kolumny
                columnData = mainAppForm.GetColumnData(selectedColumnName);
            }

            // Zmirrorujemy dane
            editedDataList = columnData.Select(data =>
                new string(data.Reverse().ToArray())).ToList();
            ShowNewDataList();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            // Pobierz nazwę wybranej kolumny
            string selectedColumnName = cbColumnForEdit.SelectedItem?.ToString();

            // Sprawdź, czy wybrano kolumnę
            if (string.IsNullOrEmpty(selectedColumnName))
            {
                MessageBox.Show("Proszę wybrać kolumnę do przetworzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz dane z wybranej kolumny z formularza MainApp
            List<string> columnData = new List<string>();
            if (mainAppForm != null)
            {
                // Wywołaj metodę MainApp, aby pobrać dane z wybranej kolumny
                columnData = mainAppForm.GetColumnData(selectedColumnName);
            }

            // Przetasuj litery w każdym ciągu
            editedDataList = columnData.Select(data => ShuffleString(data)).ToList();
            ShowNewDataList();
        }

        // Funkcja do przetasowania ciągu znaków
        private string ShuffleString(string input)
        {
            char[] characters = input.ToCharArray();
            Random rng = new Random();
            int n = characters.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = characters[k];
                characters[k] = characters[n];
                characters[n] = value;
            }
            return new string(characters);
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            // Pobierz nazwę wybranej kolumny
            string selectedColumnName = cbColumnForEdit.SelectedItem?.ToString();
            Random rng = new Random();
            // Sprawdź, czy wybrano kolumnę
            if (string.IsNullOrEmpty(selectedColumnName))
            {
                MessageBox.Show("Proszę wybrać kolumnę do przetworzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz dane z wybranej kolumny z formularza MainApp
            List<string> columnData = new List<string>();
            if (mainAppForm != null)
            {
                // Wywołaj metodę MainApp, aby pobrać dane z wybranej kolumny
                columnData = mainAppForm.GetColumnData(selectedColumnName);
            }

            // Pobierz obecną liczbę wierszy w kolumnie
            int rowCount = columnData.Count;

            // Jeśli liczba wierszy w kolumnie jest większa niż liczba elementów w editedDataList, dodaj nowe numery telefonów na końcu
            while (editedDataList.Count < rowCount)
            {
                string phoneNumber = GeneratePhoneNumber(rng);
                editedDataList.Add(phoneNumber);
            }

            // Jeśli liczba wierszy w kolumnie jest mniejsza lub równa liczbie elementów w editedDataList, podmień numery telefonów w istniejących danych
            for (int i = 0; i < rowCount; i++)
            {
                string phoneNumber = GeneratePhoneNumber(rng);
                editedDataList[i] = phoneNumber;
            }

            ShowNewDataList();
        }

        private string GeneratePhoneNumber(Random rng)
        {
            StringBuilder phoneNumber = new StringBuilder();
            phoneNumber.Append("+48 "); // Dodaj kod kraju, np. Polska
            for (int i = 0; i < 9; i++)
            {
                phoneNumber.Append(rng.Next(0, 10));
            }
            return phoneNumber.ToString();
        }

        private void ShowNewDataList()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("Slowo", "Slowo");
            // Dodaj przetworzone dane do dataGridView1
            foreach (string item in editedDataList)
            {
                dataGridView1.Rows.Add(item);
            }
        }

        private void btnRandomAge_Click(object sender, EventArgs e)
        {
            // Pobierz nazwę wybranej kolumny
            string selectedColumnName = cbColumnForEdit.SelectedItem?.ToString();
            // Sprawdź, czy wybrano kolumnę
            if (string.IsNullOrEmpty(selectedColumnName))
            {
                MessageBox.Show("Proszę wybrać kolumnę do przetworzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz dane z wybranej kolumny z formularza MainApp
            List<string> columnData = new List<string>();
            if (mainAppForm != null)
            {
                // Wywołaj metodę MainApp, aby pobrać dane z wybranej kolumny
                columnData = mainAppForm.GetColumnData(selectedColumnName);
            }

            // Pobierz obecną liczbę wierszy w kolumnie
            int rowCount = columnData.Count;

            // Sprawdź, czy minimalny wiek jest mniejszy niż maksymalny
            int miAge = (int)minAge.Value;
            int maAge = (int)maxAge.Value;
            if (miAge >= maAge)
            {
                MessageBox.Show("Minimalny wiek musi być mniejszy niż maksymalny wiek.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Zainicjalizuj listę edytowanych danych odpowiednią liczbą pustych ciągów
            editedDataList = new List<string>(new string[rowCount]);

            Random rng = new Random();
            // Wygeneruj losowy wiek dla każdego wiersza w edytowanych danych
            for (int i = 0; i < rowCount; i++)
            {
                int randomAge = rng.Next(miAge, maAge + 1); // losowy wiek z przedziału [minAge, maxAge]
                editedDataList[i] = randomAge.ToString(); // Zastąp istniejący wiek wygenerowanym wiekiem
            }

            // Wywołaj funkcję ShowNewDataList, aby zaktualizować DataGridView
            ShowNewDataList();
        }

        private void btnAddNewColumn_Click(object sender, EventArgs e)
        {
            // Pobierz nazwy wybranych kolumn z ComboBoxów
            string firstSelectedColumnName = cbFirstColumn.SelectedItem?.ToString();
            string secondSelectedColumnName = cbSecondColumn.SelectedItem?.ToString();

            // Sprawdź, czy obie nazwy kolumn zostały wybrane
            if (string.IsNullOrEmpty(firstSelectedColumnName) || string.IsNullOrEmpty(secondSelectedColumnName))
            {
                MessageBox.Show("Proszę wybrać dwie kolumny do przetworzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz dane z wybranych kolumn z formularza MainApp
            List<string> firstColumnData = new List<string>();
            List<string> secondColumnData = new List<string>();
            if (mainAppForm != null)
            {
                firstColumnData = mainAppForm.GetColumnData(firstSelectedColumnName);
                secondColumnData = mainAppForm.GetColumnData(secondSelectedColumnName);
            }

            // Pobierz nazwę nowej kolumny z TextBoxa
            string newColumnName = tbNewColumn.Text.Trim();

            // Sprawdź, czy podano nazwę nowej kolumny
            if (string.IsNullOrEmpty(newColumnName))
            {
                MessageBox.Show("Proszę podać nazwę nowej kolumny.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz wartość z tbNewItemEnd
            string newItemEndValue = tbNewItemEnd.Text.Trim();
            string newItem = tbNewItem.Text.Trim();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // Dodaj nową kolumnę do DataGridView
            dataGridView1.Columns.Add(newColumnName, newColumnName);

            // Dodaj odpowiednią liczbę wierszy do DataGridView przed dodaniem wartości do nowej kolumny
            for (int i = 0; i < firstColumnData.Count; i++)
            {
                dataGridView1.Rows.Add();
            }
            for (int i = 0; i < firstColumnData.Count; i++)
            {
                string concatenatedData = $"{firstColumnData[i]}{newItem}{secondColumnData[i]}{newItemEndValue}";
                newDataList.Add(concatenatedData);
            }
            // Dodaj rekordy do nowej kolumny na podstawie danych z wybranych kolumn i wartości z tbNewItemEnd
            for (int i = 0; i < firstColumnData.Count; i++)
            {
                string concatenatedData = $"{firstColumnData[i]}{newItem}{secondColumnData[i]}{newItemEndValue}";
                dataGridView1.Rows[i].Cells[newColumnName].Value = concatenatedData;
            }
        }


        private void EditColumns_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
        }

        private void btnSend0_Click(object sender, EventArgs e)
        {
            List<string> dataToAdd = editedDataList.ToList();
            string selectedColumnName = cbColumnForEdit.SelectedItem?.ToString();
            if (selectedColumnName != null)
            {
                MainApp mainApp = (MainApp)this.MdiParent; 
                mainAppForm.AddDataToColumn(selectedColumnName, dataToAdd);
            }
            else
            {
                MessageBox.Show("Selected column is null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend1_Click(object sender, EventArgs e)
        {
            List<string> dataToAdd = newDataList.ToList();
            string newColumnName = tbNewColumn.Text.Trim();
            if (!string.IsNullOrEmpty(newColumnName) && dataToAdd.Count > 0)
            {
                MainApp mainApp = (MainApp)this.MdiParent;
                mainAppForm.AddDataToColumn(newColumnName, dataToAdd);
                // Tutaj możesz dodać kod do aktualizacji interfejsu użytkownika lub innych działań po dodaniu danych do kolumny
            }
            else
            {
                MessageBox.Show("Selected column, new column name, or data to add is null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnInc_Click(object sender, EventArgs e)
        {
            // Pobierz nazwę wybranej kolumny
            string selectedColumnName = cbColumnForEdit.SelectedItem?.ToString();

            // Sprawdź, czy wybrano kolumnę
            if (string.IsNullOrEmpty(selectedColumnName))
            {
                MessageBox.Show("Proszę wybrać kolumnę do przetworzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz dane z wybranej kolumny z formularza MainApp
            List<string> columnData = new List<string>();
            if (mainAppForm != null)
            {
                // Wywołaj metodę MainApp, aby pobrać dane z wybranej kolumny
                columnData = mainAppForm.GetColumnData(selectedColumnName);
            }
            int Temp = 1;
            // Inkrementuj pozostałe elementy o 1, jeśli są liczbami
            for (int i = 1; i < columnData.Count; i++)
            {
                editedDataList.Add(Temp.ToString());
                Temp += 1;
            }

            // Wywołaj funkcję ShowNewDataList, aby zaktualizować DataGridView
            ShowNewDataList();
        }

    }
}

