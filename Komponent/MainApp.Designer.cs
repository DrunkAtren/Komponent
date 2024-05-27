namespace Komponent
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDataSetMainApp = new System.Windows.Forms.DataGridView();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbColumnName = new System.Windows.Forms.TextBox();
            this.btnGoToEditColumn = new System.Windows.Forms.Button();
            this.btnGoToHistogram = new System.Windows.Forms.Button();
            this.btnGoToCreateDataSet = new System.Windows.Forms.Button();
            this.btnAddDataSet = new System.Windows.Forms.Button();
            this.btnDefaultDataSet = new System.Windows.Forms.Button();
            this.btnSetMaxRek = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maxColumnHeight = new System.Windows.Forms.NumericUpDown();
            this.btnClearTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSetMainApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxColumnHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataSetMainApp
            // 
            this.dgvDataSetMainApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSetMainApp.Location = new System.Drawing.Point(12, 49);
            this.dgvDataSetMainApp.Name = "dgvDataSetMainApp";
            this.dgvDataSetMainApp.Size = new System.Drawing.Size(1352, 381);
            this.dgvDataSetMainApp.TabIndex = 0;
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(110, 22);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(25, 23);
            this.btnAddColumn.TabIndex = 1;
            this.btnAddColumn.Text = ">";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodaj Kolumne";
            // 
            // tbColumnName
            // 
            this.tbColumnName.Location = new System.Drawing.Point(12, 23);
            this.tbColumnName.Name = "tbColumnName";
            this.tbColumnName.Size = new System.Drawing.Size(100, 20);
            this.tbColumnName.TabIndex = 3;
            // 
            // btnGoToEditColumn
            // 
            this.btnGoToEditColumn.Location = new System.Drawing.Point(497, 19);
            this.btnGoToEditColumn.Name = "btnGoToEditColumn";
            this.btnGoToEditColumn.Size = new System.Drawing.Size(127, 23);
            this.btnGoToEditColumn.TabIndex = 4;
            this.btnGoToEditColumn.Text = "Edytowanie Kolumny >";
            this.btnGoToEditColumn.UseVisualStyleBackColor = true;
            this.btnGoToEditColumn.Click += new System.EventHandler(this.btnGoToEditColumn_Click);
            // 
            // btnGoToHistogram
            // 
            this.btnGoToHistogram.Location = new System.Drawing.Point(630, 20);
            this.btnGoToHistogram.Name = "btnGoToHistogram";
            this.btnGoToHistogram.Size = new System.Drawing.Size(72, 23);
            this.btnGoToHistogram.TabIndex = 5;
            this.btnGoToHistogram.Text = "Histogram >";
            this.btnGoToHistogram.UseVisualStyleBackColor = true;
            // 
            // btnGoToCreateDataSet
            // 
            this.btnGoToCreateDataSet.Location = new System.Drawing.Point(384, 20);
            this.btnGoToCreateDataSet.Name = "btnGoToCreateDataSet";
            this.btnGoToCreateDataSet.Size = new System.Drawing.Size(107, 23);
            this.btnGoToCreateDataSet.TabIndex = 6;
            this.btnGoToCreateDataSet.Text = "Stwórz Słownik >";
            this.btnGoToCreateDataSet.UseVisualStyleBackColor = true;
            this.btnGoToCreateDataSet.Click += new System.EventHandler(this.btnAnotherDataSet_Click);
            // 
            // btnAddDataSet
            // 
            this.btnAddDataSet.Location = new System.Drawing.Point(278, 19);
            this.btnAddDataSet.Name = "btnAddDataSet";
            this.btnAddDataSet.Size = new System.Drawing.Size(100, 23);
            this.btnAddDataSet.TabIndex = 8;
            this.btnAddDataSet.Text = "Dodaj Słownik";
            this.btnAddDataSet.UseVisualStyleBackColor = true;
            this.btnAddDataSet.Click += new System.EventHandler(this.btnAddDataSet_Click);
            // 
            // btnDefaultDataSet
            // 
            this.btnDefaultDataSet.Location = new System.Drawing.Point(708, 19);
            this.btnDefaultDataSet.Name = "btnDefaultDataSet";
            this.btnDefaultDataSet.Size = new System.Drawing.Size(157, 23);
            this.btnDefaultDataSet.TabIndex = 9;
            this.btnDefaultDataSet.Text = "Wgraj Podstawoe Dane";
            this.btnDefaultDataSet.UseVisualStyleBackColor = true;
            this.btnDefaultDataSet.Click += new System.EventHandler(this.btnDefaultDataSet_Click);
            // 
            // btnSetMaxRek
            // 
            this.btnSetMaxRek.Location = new System.Drawing.Point(244, 23);
            this.btnSetMaxRek.Name = "btnSetMaxRek";
            this.btnSetMaxRek.Size = new System.Drawing.Size(25, 23);
            this.btnSetMaxRek.TabIndex = 11;
            this.btnSetMaxRek.Text = ">";
            this.btnSetMaxRek.UseVisualStyleBackColor = true;
            this.btnSetMaxRek.Click += new System.EventHandler(this.btnSetMaxRek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ustaw Max Rekord";
            // 
            // maxColumnHeight
            // 
            this.maxColumnHeight.Location = new System.Drawing.Point(141, 25);
            this.maxColumnHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxColumnHeight.Name = "maxColumnHeight";
            this.maxColumnHeight.Size = new System.Drawing.Size(97, 20);
            this.maxColumnHeight.TabIndex = 13;
            // 
            // btnClearTable
            // 
            this.btnClearTable.Location = new System.Drawing.Point(871, 20);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(157, 23);
            this.btnClearTable.TabIndex = 14;
            this.btnClearTable.Text = "Wyczyść Tabele";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 443);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.maxColumnHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSetMaxRek);
            this.Controls.Add(this.btnDefaultDataSet);
            this.Controls.Add(this.btnAddDataSet);
            this.Controls.Add(this.btnGoToCreateDataSet);
            this.Controls.Add(this.btnGoToHistogram);
            this.Controls.Add(this.btnGoToEditColumn);
            this.Controls.Add(this.tbColumnName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddColumn);
            this.Controls.Add(this.dgvDataSetMainApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainApp";
            this.Text = "MainApp";
            this.Load += new System.EventHandler(this.MainApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSetMainApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxColumnHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataSetMainApp;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbColumnName;
        private System.Windows.Forms.Button btnGoToEditColumn;
        private System.Windows.Forms.Button btnGoToHistogram;
        private System.Windows.Forms.Button btnGoToCreateDataSet;
        private System.Windows.Forms.Button btnAddDataSet;
        private System.Windows.Forms.Button btnDefaultDataSet;
        private System.Windows.Forms.Button btnSetMaxRek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxColumnHeight;
        private System.Windows.Forms.Button btnClearTable;
    }
}