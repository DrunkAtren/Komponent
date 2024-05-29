using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Komponent
{
    public class VerticalLabel : Label
    {
        
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.Width, 0);
            e.Graphics.RotateTransform(90);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new RectangleF(0, 0, this.Height, this.Width), format);
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, height, width, specified);
        }
    }

    public class HistogramComponent
    {
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

        private Dictionary<string, int> _dataFrequencies;
        private List<Color> _barColors;
        private string _dataColumnName;
        private int _barSpacing;
        private int _maxScaleValue;
        private bool _is3D;

        public HistogramComponent(string dataColumnName)
        {
            _dataColumnName = dataColumnName;
            _dataFrequencies = new Dictionary<string, int>();
            barWidthValue = 20;
            _barSpacing = 20;
            _maxScaleValue = 100;
            _is3D = false;
            _barColors = new List<Color>();
        }

        public Dictionary<string, int> DataFrequencies => _dataFrequencies;

        public int BarWidth
        {
            get => barWidthValue;
            set => barWidthValue = value;
        }

        public int BarSpacing
        {
            get => _barSpacing;
            set => _barSpacing = value;
        }

        public int ScaleStep
        {
            get => scaleStepValue;
            set => scaleStepValue = value;
        }

        public int MaxScaleValue
        {
            get => _maxScaleValue;
            set => _maxScaleValue = value;
        }

        public bool Is3D
        {
            get => _is3D;
            set => _is3D = value;
        }

        public void LoadData(DataTable dataTable)
        {
            if (dataTable.Columns.Contains(_dataColumnName))
            {
                _dataFrequencies.Clear();
                int totalCount = dataTable.Rows.Count;

                foreach (DataRow row in dataTable.Rows)
                {
                    string value = row[_dataColumnName].ToString();
                    if (_dataFrequencies.ContainsKey(value))
                    {
                        _dataFrequencies[value]++;
                    }
                    else
                    {
                        _dataFrequencies[value] = 1;
                    }
                }

                List<string> keys = _dataFrequencies.Keys.ToList();
                foreach (string key in keys)
                {
                    _dataFrequencies[key] = (_dataFrequencies[key] * 100) / totalCount;
                }
            }
            else
            {
                throw new ArgumentException($"Kolumna '{_dataColumnName}' nie istnieje w dostarczonej tabeli.");
            }
        }

        public void GenerateHistogram(Control container)
        {
            container.Controls.Clear();

            if (_dataFrequencies.Count == 0)
            {
                throw new InvalidOperationException("Brak danych do wygenerowania histogramu. Upewnij się, że dane zostały załadowane.");
            }

            int maxHeight = container.Height - 100; // Adjusted to provide more space for labels
            int maxWidth = container.Width;
            int legendHeight = 50;

            int scaleHeight = maxHeight - 70; // Increased to provide more space for labels
            int scaleInterval = 100 / scaleStepValue;
            int scaleStepHeight = scaleHeight / scaleInterval;
            int scaleValueStep = 100 / scaleInterval;

            for (int i = 0; i <= scaleInterval; i++)
            {
                int y = maxHeight - 50 - i * scaleStepHeight;
                Label scaleLabel = new Label
                {
                    Text = (i * scaleValueStep).ToString() + "%",
                    AutoSize = true,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                };

                Size textSize = TextRenderer.MeasureText(scaleLabel.Text, scaleLabel.Font);
                int labelHeight = textSize.Height;

                scaleLabel.Location = new Point(0, y - labelHeight / 2);
                container.Controls.Add(scaleLabel);
                container.CreateGraphics().DrawLine(Pens.Black, 30, y, maxWidth, y);
            }

            Random rand = new Random();
            _barColors.Clear();

            int xPosition = 50;
            foreach (var item in _dataFrequencies)
            {
                int barHeight = (int)((item.Value / 100.0) * scaleHeight);
                Color barColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                _barColors.Add(barColor);

                if (_is3D)
                {
                    Draw3DBar(container, xPosition, maxHeight - 50, barHeight, barColor);
                }
                else
                {
                    Panel barPanel = new Panel
                    {
                        BackColor = barColor,
                        Width = barWidthValue,
                        Height = barHeight,
                        Left = xPosition,
                        Top = maxHeight - 50 - barHeight
                    };

                    container.Controls.Add(barPanel);
                }

                xPosition += barWidthValue + _barSpacing;
            }

            GenerateLegend(container, maxHeight, legendHeight);
        }

        private void Draw3DBar(Control container, int x, int yBase, int height, Color barColor)
        {
            Graphics g = container.CreateGraphics();
            int depth = barWidthValue / 2;

            Point[] frontFace = {
                new Point(x, yBase - height),
                new Point(x + barWidthValue, yBase - height),
                new Point(x + barWidthValue, yBase),
                new Point(x, yBase)
            };

            Point[] topFace = {
                new Point(x, yBase - height),
                new Point(x + depth, yBase - height - depth),
                new Point(x + barWidthValue + depth, yBase - height - depth),
                new Point(x + barWidthValue, yBase - height)
            };

            Point[] sideFace = {
                new Point(x + barWidthValue, yBase - height),
                new Point(x + barWidthValue + depth, yBase - height - depth),
                new Point(x + barWidthValue + depth, yBase - depth),
                new Point(x + barWidthValue, yBase)
            };

            g.FillPolygon(new SolidBrush(barColor), frontFace);
            g.FillPolygon(new SolidBrush(Color.FromArgb(barColor.R / 2, barColor.G / 2, barColor.B / 2)), topFace);
            g.FillPolygon(new SolidBrush(Color.FromArgb(barColor.R / 3, barColor.G / 3, barColor.B / 3)), sideFace);
            g.DrawPolygon(Pens.Black, frontFace);
            g.DrawPolygon(Pens.Black, topFace);
            g.DrawPolygon(Pens.Black, sideFace);
        }

        private void GenerateLegend(Control container, int maxHeight, int legendHeight)
        {
            int legendYPosition = maxHeight + 20;
            int legendXPosition = 50;
            int legendSpacing = 10;
            int legendItemHeight = 10;
            int legendItemWidth = 30;
            int currentItem = 0;

            foreach (var item in _dataFrequencies)
            {
                Color barColor = _barColors[_dataFrequencies.Keys.ToList().IndexOf(item.Key)];

                Panel legendColorPanel = new Panel
                {
                    BackColor = barColor,
                    Width = legendItemWidth,
                    Height = legendItemHeight,
                    Left = legendXPosition + (currentItem % legendItemsPerRow) * (legendItemWidth + 100),
                    Top = legendYPosition + (currentItem / legendItemsPerRow) * (legendItemHeight + legendSpacing)
                };

                container.Controls.Add(legendColorPanel);

                Label legendLabel = new Label
                {
                    Text = item.Key,
                    AutoSize = true,
                    Left = legendColorPanel.Right + legendSpacing,
                    Top = legendColorPanel.Top + (legendItemHeight / 2) - 10
                };

                container.Controls.Add(legendLabel);

                currentItem++;
            }
        }

        public void GenerateHistogram3D(Control container)
        {
            _is3D = true; // Ustaw tryb 3D

            GenerateHistogram(container); // Wywołaj istniejącą metodę generowania histogramu

            _is3D = false; // Przywróć tryb 2D na wypadek, gdyby była wywoływana ponownie metoda GenerateHistogram z zewnątrz
        }
    }
}
