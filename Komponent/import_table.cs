using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq; // Dodaj referencję do Newtonsoft.Json

namespace Komponent
{
    public class import_datas : IDisposable
    {
        private string import_file = "default_data";
        private string import_extension = "json";
        private string import_directory = "src";

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
            return import_extension; // Poprawiono błąd
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
            // Zakładamy, że katalog projektu jest jeden poziom wyżej niż katalog bin
            string projectDirectory1 = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName;
            string projectDirectory = Directory.GetParent(projectDirectory1).Parent.FullName;
            string filePath = Path.Combine(projectDirectory + "/Komponent/" + import_directory, import_file + "." + import_extension);

            try
            {
                // Dodaj kolumny do DataGridView, jeśli jeszcze ich nie ma
                if (_dataGridView.Columns.Count == 0)
                {
                    _dataGridView.Columns.Add("imie", "Imię");
                    _dataGridView.Columns.Add("nazwisko", "Nazwisko");
                    _dataGridView.Columns.Add("ulica", "Ulica");
                    _dataGridView.Columns.Add("miejsce_zamieszkania", "Miejsce Zamieszkania");
                }

                if (import_extension.Equals("json", StringComparison.OrdinalIgnoreCase))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string jsonContent = sr.ReadToEnd();
                        JArray jsonArray = JArray.Parse(jsonContent);
                        foreach (var item in jsonArray)
                        {
                            string imie = item["imie"]?.ToString();
                            string nazwisko = item["nazwisko"]?.ToString();
                            string ulica = item["ulica"]?.ToString();
                            string miejsce_zamieszkania = item["miejsce_zamieszkania"]?.ToString();
                            _dataGridView.Rows.Add(imie, nazwisko, ulica, miejsce_zamieszkania);
                        }
                    }
                }
                else if (import_extension.Equals("csv", StringComparison.OrdinalIgnoreCase))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split(',');
                            _dataGridView.Rows.Add(data);
                        }
                    }
                }
                else if (import_extension.Equals("txt", StringComparison.OrdinalIgnoreCase))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
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
