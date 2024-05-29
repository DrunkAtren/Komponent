using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Komponent
{
    public partial class Histogram : Form
    {
        private MainApp mainAppForm;
        private HistogramComponent histogram;
        private bool is3D = false;
        private bool histogramGenerated = false;

        private int scaleStepValue = 20;
        private int barWidthValue = 20;
        private int legendItemsPerRow = 4;

        public int getScaleStepValue()
        {
            return scaleStepValue;
        }

        public int getBarWidthValue()
        {
            return barWidthValue;
        }

        public int getLegendItemsPerRow()
        {
            return legendItemsPerRow;
        }

        public void setScaleStepValue(int step_value)
        {
            scaleStepValue = step_value;
        }

        public void setBarWidthValue(int bar_value)
        {
            barWidthValue = bar_value;
        }

        public void setLegendItemsPerRow(int items_pew_row)
        {
            legendItemsPerRow = items_pew_row;
        }

        private void setValues()
        {
            histogram.setLegendItemsPerRow(legendItemsPerRow);
            histogram.setBarWidthValue(barWidthValue);
            histogram.setScaleStepValue(scaleStepValue);
        }

        public Histogram(MainApp mainApp)
        {
            InitializeComponent();
            mainAppForm = mainApp;
            LoadDataForHistogram();
        }

        private void LoadDataForHistogram()
        {
            if (mainAppForm == null)
            {
                MessageBox.Show("Aplikacja nie odpowiada.");
                return;
            }

            List<string> columnNames = mainAppForm.GetColumnNames();
            if (columnNames.Count == 0)
            {
                MessageBox.Show("Brak kolumn do generowania.");
                return;
            }

            

            foreach (string columnName in columnNames)
            {
                columnChooser.Items.Add(columnName);
            }

            // Opcjonalnie ustaw domyślny wybór
            if (columnChooser.Items.Count > 0)
            {
                columnChooser.SelectedIndex = 0; // Wybierz pierwszy element domyślnie
            }
        }

        private void ColumnChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (columnChooser.SelectedItem != null)
            {
                string selectedColumnName = columnChooser.SelectedItem.ToString();
                LoadHistogram(selectedColumnName);
            }
        }

        private void LoadHistogram(string columnName)
        {
            DataTable dataTable = GetDataFromSelectedColumn(columnName);
            histogram = new HistogramComponent(columnName);
            setValues();
            histogram.LoadData(dataTable);
            histogramGenerated = true; // Ustawienie flagi, że histogram został wygenerowany
            histogramPanel.Invalidate(); // Odśwież panel
        }

        private DataTable GetDataFromSelectedColumn(string columnName)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(columnName, typeof(string));

            foreach (DataGridViewRow row in mainAppForm.GetRows())
            {
                if (row.Cells[columnName].Value != null)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[columnName] = row.Cells[columnName].Value.ToString();
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (columnChooser.SelectedItem != null)
            {
                string selectedColumnName = columnChooser.SelectedItem.ToString();
                histogramPanel.Controls.Clear();
                if (!is3D)
                {
                    LoadHistogram(selectedColumnName);
                }
                else
                {
                    HistogramComponent histogram = new HistogramComponent(selectedColumnName);
                    histogram.LoadData(GetDataFromSelectedColumn(selectedColumnName)); // Wczytaj dane
                    histogram.GenerateHistogram3D(histogramPanel);
                }
                
            }
            else
            {
                MessageBox.Show("Wybierz kolumnę przed generowaniem histogramu.");
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton_2D.Checked)
            {
                is3D = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_3D.Checked)
            {
                is3D = true;
            }
        }

        private void histogramPanel_Paint(object sender, PaintEventArgs e)
        {
            if (histogramGenerated) // Sprawdź, czy histogram został już wygenerowany
            {
                if (histogram != null)
                {
                    histogram.GenerateHistogram(histogramPanel);
                }
            }
        }

        private void Histogram_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
