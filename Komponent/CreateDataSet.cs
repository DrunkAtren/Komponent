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
    public partial class CreateDataSet : Form
    {
        public CreateDataSet()
        {
            InitializeComponent();
        }

        private void btnAddToDataSet_Click(object sender, EventArgs e)
        {
            string wordToAdd = tbAddToDataSet.Text;
            
            if (string.IsNullOrEmpty(wordToAdd))
            {
                MessageBox.Show("Wprowadź słowo do słownika", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgvDataSet.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(wordToAdd, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("To słowo już istnieje w słowniku danych.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            dgvDataSet.Rows.Add(wordToAdd);
        }

        private void btnSaveDataSet_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Save Data Set",
                DefaultExt = "txt"
            };

            // Show the dialog and check if the user clicked OK
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Open a StreamWriter to write to the file
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Iterate through the rows of the DataGridView
                        foreach (DataGridViewRow row in dgvDataSet.Rows)
                        {
                            // Write the word to the file if the cell is not null
                            if (row.Cells[0].Value != null)
                            {
                                writer.WriteLine(row.Cells[0].Value.ToString());
                            }
                        }
                    }

                    // Notify the user that the file was saved successfully
                    MessageBox.Show("Słownik został zapisany", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Notify the user if there was an error saving the file
                    MessageBox.Show($"An error occurred while saving the data set: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
