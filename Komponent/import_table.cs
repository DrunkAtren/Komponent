using System;
using System.IO;
using System.Windows.Forms;

namespace Komponent
{
    public class import_datas : IDisposable
    {
        private string import_file = "default";
        private string import_extension = "json";
        private string import_directory = "/src/";

        public string getImportFilename()
        {
            return import_file;
        }

        public string getImportDirectory()
        {
            return import_directory;
        }

        public string getImportExtension()
        {
            return import_file;
        }

        public void setImportFilename(string name)
        {
            import_file = name;
        }

        public void setImportDirectory(string directory)
        {
            import_directory = directory;
        }

        public void setImportExtension(string extension)
        {
            import_extension = extension;
        }

        private DataGridView _dataGridView;

        public import_datas(DataGridView dataGridView)
        {
            _dataGridView = dataGridView ?? throw new ArgumentNullException(nameof(dataGridView));
        }

        public void ImportData()
        {
            string filePath = Path.Combine(import_directory, import_file + "." + import_extension);

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (import_extension.Equals("csv", StringComparison.OrdinalIgnoreCase))
                        {
                            string[] data = line.Split(',');
                            _dataGridView.Rows.Add(data);
                        }
                        else if (import_extension.Equals("txt", StringComparison.OrdinalIgnoreCase))
                        {
                            _dataGridView.Rows.Add(line);
                        }
                    }
                }

                MessageBox.Show("Dane zostały zaimportowane pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas importowania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Dispose()
        {
            _dataGridView = null;
        }
    }
}
