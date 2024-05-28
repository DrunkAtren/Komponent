using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Komponent
{
    public class export_to_file : IDisposable
    {

        private string exported_format = "TEXT";
        private string export_file_name = "dataset1";
        private string export_destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private TextBox fileName;
        private ComboBox fileType;

        public export_to_file(TextBox fileName, ComboBox fileType)
        {
            this.fileName = fileName;
            this.fileType = fileType;
            //this.fileDestination = fileDestination;
        }

        private void setValues()
        {
            exported_format = fileType.Text;
            export_file_name = fileName.Text;
            //export_destination = fileDestination.Text;
        }

        public string getFilename()
        {
            return export_file_name;
        }

        public string getFormat()
        {
            return exported_format;
        }

        public string getDestination()
        {
            return export_destination;
        }

        public void setFilename(string Name)
        {
            export_file_name = Name;
        }

        public void setFormat(string Format)
        {
            exported_format = Format;
        }

        public void setDestination(string Destination)
        {
            export_destination = Destination;
        }

        public enum ExportFormat
        {
            CSV,
            JSON,
            TEXT
        }

        private static void ExportToJSON(DataGridView dataGridView, string fileName)
        {
            var jsonArray = new JArray();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var jsonObject = new JObject();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        jsonObject[cell.OwningColumn.HeaderText] = cell.Value?.ToString() ?? string.Empty;
                    }
                    jsonArray.Add(jsonObject);
                }
            }
            string json = jsonArray.ToString();
            File.WriteAllText(fileName, json);
        }

        private static void ExportToCSV(DataGridView dataGridView, string fileName)
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                sb.Append(column.HeaderText).Append(",");
            }
            sb.AppendLine();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sb.Append(cell.Value?.ToString() ?? string.Empty).Append(",");
                    }
                    sb.AppendLine();
                }
            }

            File.WriteAllText(fileName, sb.ToString());
        }

        private static void ExportToText(DataGridView dataGridView, string fileName, char delimiter = '\t')
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                sb.Append(column.HeaderText).Append(delimiter);
            }
            sb.AppendLine();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sb.Append(cell.Value?.ToString() ?? string.Empty).Append(delimiter);
                    }
                    sb.AppendLine();
                }
            }

            File.WriteAllText(fileName, sb.ToString());
        }

        public void ExportDataCreate(DataGridView dataGridView)
        {
            setValues();

            string fileName = Path.Combine(export_destination, export_file_name);
            ExportFormat format = ExportFormat.CSV;
            if (exported_format == "json") format = ExportFormat.JSON;
            if (exported_format == "text") format = ExportFormat.TEXT;

            ExportData(dataGridView, fileName, format);
            MessageBox.Show("Dane zosta³y pomyœlnie wyeksportowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void ExportData(DataGridView dataGridView, string fileName, ExportFormat format)
        {
            switch (format)
            {
                case ExportFormat.CSV:
                    fileName += ".csv";
                    ExportToCSV(dataGridView, fileName);
                    break;
                case ExportFormat.JSON:
                    fileName += ".json";
                    ExportToJSON(dataGridView, fileName);
                    break;
                case ExportFormat.TEXT:
                    fileName += ".txt";
                    ExportToText(dataGridView, fileName);
                    break;
                default:
                    throw new ArgumentException("Unsupported export format");
            }
        }

        public void Dispose()
        {
            // Implement your disposal logic here, if needed
        }
    }
}
