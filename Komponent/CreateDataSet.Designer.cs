namespace Komponent
{
    partial class CreateDataSet
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
            this.btnSaveDataSet = new System.Windows.Forms.Button();
            this.tbAddToDataSet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddToDataSet = new System.Windows.Forms.Button();
            this.dgvDataSet = new System.Windows.Forms.DataGridView();
            this.DataSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveDataSet
            // 
            this.btnSaveDataSet.Location = new System.Drawing.Point(276, 25);
            this.btnSaveDataSet.Name = "btnSaveDataSet";
            this.btnSaveDataSet.Size = new System.Drawing.Size(95, 23);
            this.btnSaveDataSet.TabIndex = 0;
            this.btnSaveDataSet.Text = "Zapisz słownik danych";
            this.btnSaveDataSet.UseVisualStyleBackColor = true;
            this.btnSaveDataSet.Click += new System.EventHandler(this.btnSaveDataSet_Click);
            // 
            // tbAddToDataSet
            // 
            this.tbAddToDataSet.Location = new System.Drawing.Point(12, 28);
            this.tbAddToDataSet.Name = "tbAddToDataSet";
            this.tbAddToDataSet.Size = new System.Drawing.Size(157, 20);
            this.tbAddToDataSet.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Podaj słowo do słownika";
            // 
            // btnAddToDataSet
            // 
            this.btnAddToDataSet.Location = new System.Drawing.Point(175, 26);
            this.btnAddToDataSet.Name = "btnAddToDataSet";
            this.btnAddToDataSet.Size = new System.Drawing.Size(95, 23);
            this.btnAddToDataSet.TabIndex = 5;
            this.btnAddToDataSet.Text = "Dodaj słowo";
            this.btnAddToDataSet.UseVisualStyleBackColor = true;
            this.btnAddToDataSet.Click += new System.EventHandler(this.btnAddToDataSet_Click);
            // 
            // dgvDataSet
            // 
            this.dgvDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataSet});
            this.dgvDataSet.Location = new System.Drawing.Point(12, 55);
            this.dgvDataSet.Name = "dgvDataSet";
            this.dgvDataSet.Size = new System.Drawing.Size(360, 383);
            this.dgvDataSet.TabIndex = 6;
            // 
            // DataSet
            // 
            this.DataSet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataSet.HeaderText = "Słownik";
            this.DataSet.Name = "DataSet";
            // 
            // CreateDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.dgvDataSet);
            this.Controls.Add(this.btnAddToDataSet);
            this.Controls.Add(this.tbAddToDataSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveDataSet);
            this.Name = "CreateDataSet";
            this.Text = "CreateDataSet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveDataSet;
        private System.Windows.Forms.TextBox tbAddToDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddToDataSet;
        private System.Windows.Forms.DataGridView dgvDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSet;
    }
}