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
            this.components = new System.ComponentModel.Container();
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
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSetMainApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxColumnHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataSetMainApp
            // 
            this.dgvDataSetMainApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSetMainApp.Location = new System.Drawing.Point(16, 126);
            this.dgvDataSetMainApp.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDataSetMainApp.Name = "dgvDataSetMainApp";
            this.dgvDataSetMainApp.RowHeadersWidth = 51;
            this.dgvDataSetMainApp.Size = new System.Drawing.Size(1803, 469);
            this.dgvDataSetMainApp.TabIndex = 0;
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(156, 28);
            this.btnAddColumn.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(33, 28);
            this.btnAddColumn.Size = new System.Drawing.Size(25, 25);
            this.btnAddColumn.TabIndex = 1;
            this.btnAddColumn.Text = ">";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodaj Kolumne";
            // 
            // tbColumnName
            // 
            this.tbColumnName.Location = new System.Drawing.Point(16, 28);
            this.tbColumnName.Margin = new System.Windows.Forms.Padding(4);
            this.tbColumnName.Name = "tbColumnName";
            this.tbColumnName.Size = new System.Drawing.Size(132, 22);
            this.tbColumnName.TabIndex = 3;
            // 
            // btnGoToEditColumn
            // 
            this.btnGoToEditColumn.Location = new System.Drawing.Point(1173, 26);
            this.btnGoToEditColumn.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoToEditColumn.Name = "btnGoToEditColumn";
            this.btnGoToEditColumn.Size = new System.Drawing.Size(169, 28);
            this.btnGoToEditColumn.TabIndex = 4;
            this.btnGoToEditColumn.Text = "Edytowanie Kolumny >";
            this.btnGoToEditColumn.UseVisualStyleBackColor = true;
            this.btnGoToEditColumn.Click += new System.EventHandler(this.btnGoToEditColumn_Click);
            // 
            // btnGoToHistogram
            // 
            this.btnGoToHistogram.Location = new System.Drawing.Point(852, 26);
            this.btnGoToHistogram.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoToHistogram.Name = "btnGoToHistogram";
            this.btnGoToHistogram.Size = new System.Drawing.Size(96, 28);
            this.btnGoToHistogram.TabIndex = 5;
            this.btnGoToHistogram.Text = "Histogram >";
            this.btnGoToHistogram.UseVisualStyleBackColor = true;
            this.btnGoToHistogram.Click += new System.EventHandler(this.btnGoToHistogram_Click);
            // 
            // btnGoToCreateDataSet
            // 
            this.btnGoToCreateDataSet.Location = new System.Drawing.Point(512, 25);
            this.btnGoToCreateDataSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoToCreateDataSet.Location = new System.Drawing.Point(701, 26);
            this.btnGoToCreateDataSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoToCreateDataSet.Name = "btnGoToCreateDataSet";
            this.btnGoToCreateDataSet.Size = new System.Drawing.Size(143, 28);
            this.btnGoToCreateDataSet.TabIndex = 6;
            this.btnGoToCreateDataSet.Text = "Stwórz Słownik >";
            this.btnGoToCreateDataSet.UseVisualStyleBackColor = true;
            this.btnGoToCreateDataSet.Click += new System.EventHandler(this.btnAnotherDataSet_Click);
            // 
            // btnAddDataSet
            // 
            this.btnAddDataSet.Location = new System.Drawing.Point(560, 26);
            this.btnAddDataSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDataSet.Name = "btnAddDataSet";
            this.btnAddDataSet.Size = new System.Drawing.Size(133, 28);
            this.btnAddDataSet.TabIndex = 8;
            this.btnAddDataSet.Text = "Dodaj Słownik";
            this.btnAddDataSet.UseVisualStyleBackColor = true;
            this.btnAddDataSet.Click += new System.EventHandler(this.btnAddDataSet_Click);
            // 
            // btnDefaultDataSet
            // 
            this.btnDefaultDataSet.Location = new System.Drawing.Point(956, 26);
            this.btnDefaultDataSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnDefaultDataSet.Name = "btnDefaultDataSet";
            this.btnDefaultDataSet.Size = new System.Drawing.Size(209, 28);
            this.btnDefaultDataSet.TabIndex = 9;
            this.btnDefaultDataSet.Text = "Wgraj Deafultowe Dane";
            this.btnDefaultDataSet.UseVisualStyleBackColor = true;
            this.btnDefaultDataSet.Click += new System.EventHandler(this.btnDefaultDataSet_Click);
            // 
            // btnSetMaxRek
            // 
            this.btnSetMaxRek.Location = new System.Drawing.Point(352, 28);
            this.btnSetMaxRek.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetMaxRek.Name = "btnSetMaxRek";
            this.btnSetMaxRek.Size = new System.Drawing.Size(25, 25);
            this.btnSetMaxRek.TabIndex = 11;
            this.btnSetMaxRek.Text = ">";
            this.btnSetMaxRek.UseVisualStyleBackColor = true;
            this.btnSetMaxRek.Click += new System.EventHandler(this.btnSetMaxRek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ustaw Max Rekord";
            // 
            // maxColumnHeight
            // 
            this.maxColumnHeight.Location = new System.Drawing.Point(215, 28);
            this.maxColumnHeight.Margin = new System.Windows.Forms.Padding(4);
            this.maxColumnHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxColumnHeight.Name = "maxColumnHeight";
            this.maxColumnHeight.Size = new System.Drawing.Size(129, 22);
            this.maxColumnHeight.TabIndex = 13;
            // 
            // btnClearTable
            // 
            this.btnClearTable.Location = new System.Drawing.Point(1350, 26);
            this.btnClearTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(209, 28);
            this.btnClearTable.TabIndex = 14;
            this.btnClearTable.Text = "Wyczyść Tabele";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Eksportuj tabele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileType
            // 
            this.fileType.FormattingEnabled = true;
            this.fileType.Location = new System.Drawing.Point(16, 91);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(121, 24);
            this.fileType.TabIndex = 18;
            this.fileType.Text = "text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Typ pliku";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(156, 93);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 22);
            this.fileName.TabIndex = 22;
            this.fileName.Text = "deafult_text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nazwa pliku";
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(956, 72);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(209, 23);
            this.addDataButton.TabIndex = 24;
            this.addDataButton.Text = "Wgraj dane";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1838, 626);
            this.Controls.Add(this.addDataButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileType);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox fileType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addDataButton;
    }
}