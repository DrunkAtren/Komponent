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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSetMainApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxColumnHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataSetMainApp
            // 
            this.dgvDataSetMainApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSetMainApp.Location = new System.Drawing.Point(12, 111);
            this.dgvDataSetMainApp.Name = "dgvDataSetMainApp";
            this.dgvDataSetMainApp.RowHeadersWidth = 51;
            this.dgvDataSetMainApp.Size = new System.Drawing.Size(756, 368);
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
            this.btnGoToEditColumn.Location = new System.Drawing.Point(612, 71);
            this.btnGoToEditColumn.Name = "btnGoToEditColumn";
            this.btnGoToEditColumn.Size = new System.Drawing.Size(120, 23);
            this.btnGoToEditColumn.TabIndex = 4;
            this.btnGoToEditColumn.Text = "Edytowanie Kolumny >";
            this.btnGoToEditColumn.UseVisualStyleBackColor = true;
            this.btnGoToEditColumn.Click += new System.EventHandler(this.btnGoToEditColumn_Click);
            // 
            // btnGoToHistogram
            // 
            this.btnGoToHistogram.Location = new System.Drawing.Point(508, 21);
            this.btnGoToHistogram.Name = "btnGoToHistogram";
            this.btnGoToHistogram.Size = new System.Drawing.Size(72, 23);
            this.btnGoToHistogram.TabIndex = 5;
            this.btnGoToHistogram.Text = "Histogram >";
            this.btnGoToHistogram.UseVisualStyleBackColor = true;
            this.btnGoToHistogram.Click += new System.EventHandler(this.btnGoToHistogram_Click);
            // 
            // btnGoToCreateDataSet
            // 
            this.btnGoToCreateDataSet.Location = new System.Drawing.Point(395, 20);
            this.btnGoToCreateDataSet.Name = "btnGoToCreateDataSet";
            this.btnGoToCreateDataSet.Size = new System.Drawing.Size(107, 23);
            this.btnGoToCreateDataSet.TabIndex = 6;
            this.btnGoToCreateDataSet.Text = "Stwórz Słownik >";
            this.btnGoToCreateDataSet.UseVisualStyleBackColor = true;
            this.btnGoToCreateDataSet.Click += new System.EventHandler(this.btnAnotherDataSet_Click);
            // 
            // btnAddDataSet
            // 
            this.btnAddDataSet.Location = new System.Drawing.Point(289, 20);
            this.btnAddDataSet.Name = "btnAddDataSet";
            this.btnAddDataSet.Size = new System.Drawing.Size(100, 23);
            this.btnAddDataSet.TabIndex = 8;
            this.btnAddDataSet.Text = "Dodaj Słownik";
            this.btnAddDataSet.UseVisualStyleBackColor = true;
            this.btnAddDataSet.Click += new System.EventHandler(this.btnAddDataSet_Click);
            // 
            // btnDefaultDataSet
            // 
            this.btnDefaultDataSet.Location = new System.Drawing.Point(586, 20);
            this.btnDefaultDataSet.Name = "btnDefaultDataSet";
            this.btnDefaultDataSet.Size = new System.Drawing.Size(146, 23);
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
            this.btnClearTable.Location = new System.Drawing.Point(436, 72);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(157, 23);
            this.btnClearTable.TabIndex = 14;
            this.btnClearTable.Text = "Wyczyść Tabele";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
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
            this.fileType.Location = new System.Drawing.Point(804, 72);
            this.fileType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(92, 21);
            this.fileType.TabIndex = 18;
            this.fileType.Text = "json";
            this.fileType.SelectedIndexChanged += new System.EventHandler(this.fileType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Typ pliku";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(938, 74);
            this.fileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(164, 20);
            this.fileName.TabIndex = 22;
            this.fileName.Text = "default_data";
            this.fileName.TextChanged += new System.EventHandler(this.fileName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(936, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nazwa pliku";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(227, 72);
            this.addDataButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(186, 23);
            this.addDataButton.TabIndex = 24;
            this.addDataButton.Text = "Wgraj dane";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(936, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nazwa pliku";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(938, 173);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "exported_data_set";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(804, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Typ pliku";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "text",
            "csv",
            "json"});
            this.comboBox1.Location = new System.Drawing.Point(803, 173);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Text = "text";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(797, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Importowanie";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(801, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Eksportowanie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(805, 215);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Generowanie danych";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(805, 314);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Modyfikowanie danych";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(804, 412);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Histogram";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(800, 459);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown1.TabIndex = 37;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(791, 443);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Elementy w rzędzie";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(936, 459);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown2.TabIndex = 39;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(933, 443);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Progi procentowe";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1052, 443);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Grubość kolumn";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(1055, 459);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown3.TabIndex = 42;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1212, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(19, 20);
            this.button5.TabIndex = 44;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1212, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 20);
            this.button2.TabIndex = 45;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1212, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(19, 20);
            this.button3.TabIndex = 46;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(808, 367);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "AutoImport";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(910, 364);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 20);
            this.textBox2.TabIndex = 48;
            this.textBox2.Text = "src/dictionares/kraje.txt";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1187, 459);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(19, 20);
            this.button4.TabIndex = 49;
            this.button4.Text = "R";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1187, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(19, 20);
            this.button6.TabIndex = 50;
            this.button6.Text = "R";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1187, 75);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(19, 20);
            this.button7.TabIndex = 51;
            this.button7.Text = "R";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1187, 363);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(19, 20);
            this.button8.TabIndex = 52;
            this.button8.Text = "R";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1212, 363);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(19, 20);
            this.button9.TabIndex = 53;
            this.button9.Text = ">";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1187, 271);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(19, 20);
            this.button10.TabIndex = 54;
            this.button10.Text = "R";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1212, 271);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(19, 20);
            this.button11.TabIndex = 55;
            this.button11.Text = ">";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(804, 271);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown5.TabIndex = 57;
            this.numericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown5.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(804, 255);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Grubość ramek";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(950, 349);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 13);
            this.label17.TabIndex = 61;
            this.label17.Text = "Ścieżka do słownika";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(921, 270);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 62;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(1044, 270);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(92, 21);
            this.comboBox3.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(933, 255);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 64;
            this.label15.Text = "Kolor tabelki";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1052, 255);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 65;
            this.label18.Text = "Kolor tekstu";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 509);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
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
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSetMainApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxColumnHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
    }
}