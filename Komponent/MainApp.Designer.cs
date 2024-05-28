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
            this.dgvDataSetMainApp.Location = new System.Drawing.Point(12, 111);
            this.dgvDataSetMainApp.Name = "dgvDataSetMainApp";
            this.dgvDataSetMainApp.RowHeadersWidth = 51;
            this.dgvDataSetMainApp.Size = new System.Drawing.Size(1352, 368);
            this.dgvDataSetMainApp.TabIndex = 0;
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(117, 23);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(19, 20);
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
            this.btnGoToEditColumn.Location = new System.Drawing.Point(880, 21);
            this.btnGoToEditColumn.Name = "btnGoToEditColumn";
            this.btnGoToEditColumn.Size = new System.Drawing.Size(127, 23);
            this.btnGoToEditColumn.TabIndex = 4;
            this.btnGoToEditColumn.Text = "Edytowanie Kolumny >";
            this.btnGoToEditColumn.UseVisualStyleBackColor = true;
            this.btnGoToEditColumn.Click += new System.EventHandler(this.btnGoToEditColumn_Click);
            // 
            // btnGoToHistogram
            // 
            this.btnGoToHistogram.Location = new System.Drawing.Point(639, 21);
            this.btnGoToHistogram.Name = "btnGoToHistogram";
            this.btnGoToHistogram.Size = new System.Drawing.Size(72, 23);
            this.btnGoToHistogram.TabIndex = 5;
            this.btnGoToHistogram.Text = "Histogram >";
            this.btnGoToHistogram.UseVisualStyleBackColor = true;
            this.btnGoToHistogram.Click += new System.EventHandler(this.btnGoToHistogram_Click);
            // 
            // btnGoToCreateDataSet
            // 
            this.btnGoToCreateDataSet.Location = new System.Drawing.Point(526, 21);
            this.btnGoToCreateDataSet.Name = "btnGoToCreateDataSet";
            this.btnGoToCreateDataSet.Size = new System.Drawing.Size(107, 23);
            this.btnGoToCreateDataSet.TabIndex = 6;
            this.btnGoToCreateDataSet.Text = "Stwórz Słownik >";
            this.btnGoToCreateDataSet.UseVisualStyleBackColor = true;
            this.btnGoToCreateDataSet.Click += new System.EventHandler(this.btnAnotherDataSet_Click);
            // 
            // btnAddDataSet
            // 
            this.btnAddDataSet.Location = new System.Drawing.Point(420, 21);
            this.btnAddDataSet.Name = "btnAddDataSet";
            this.btnAddDataSet.Size = new System.Drawing.Size(100, 23);
            this.btnAddDataSet.TabIndex = 8;
            this.btnAddDataSet.Text = "Dodaj Słownik";
            this.btnAddDataSet.UseVisualStyleBackColor = true;
            this.btnAddDataSet.Click += new System.EventHandler(this.btnAddDataSet_Click);
            // 
            // btnDefaultDataSet
            // 
            this.btnDefaultDataSet.Location = new System.Drawing.Point(717, 21);
            this.btnDefaultDataSet.Name = "btnDefaultDataSet";
            this.btnDefaultDataSet.Size = new System.Drawing.Size(157, 23);
            this.btnDefaultDataSet.TabIndex = 9;
            this.btnDefaultDataSet.Text = "Wgraj Deafultowe Dane";
            this.btnDefaultDataSet.UseVisualStyleBackColor = true;
            this.btnDefaultDataSet.Click += new System.EventHandler(this.btnDefaultDataSet_Click);
            // 
            // btnSetMaxRek
            // 
            this.btnSetMaxRek.Location = new System.Drawing.Point(264, 23);
            this.btnSetMaxRek.Name = "btnSetMaxRek";
            this.btnSetMaxRek.Size = new System.Drawing.Size(19, 20);
            this.btnSetMaxRek.TabIndex = 11;
            this.btnSetMaxRek.Text = ">";
            this.btnSetMaxRek.UseVisualStyleBackColor = true;
            this.btnSetMaxRek.Click += new System.EventHandler(this.btnSetMaxRek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ustaw Max Rekord";
            // 
            // maxColumnHeight
            // 
            this.maxColumnHeight.Location = new System.Drawing.Point(161, 23);
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
            this.btnClearTable.Location = new System.Drawing.Point(1012, 21);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(157, 23);
            this.btnClearTable.TabIndex = 14;
            this.btnClearTable.Text = "Wyczyść Tabele";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
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
            this.fileType.Location = new System.Drawing.Point(12, 74);
            this.fileType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(92, 21);
            this.fileType.TabIndex = 18;
            this.fileType.Text = "text";
            this.fileType.SelectedIndexChanged += new System.EventHandler(this.fileType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Typ pliku";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(117, 76);
            this.fileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(76, 20);
            this.fileName.TabIndex = 22;
            this.fileName.Text = "deafult_text";
            this.fileName.TextChanged += new System.EventHandler(this.fileName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nazwa pliku";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(717, 58);
            this.addDataButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(157, 19);
            this.addDataButton.TabIndex = 24;
            this.addDataButton.Text = "Wgraj dane";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 509);
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