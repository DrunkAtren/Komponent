namespace Komponent
{
    partial class AddDataSet
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
            this.dgvSelectedDataSet = new System.Windows.Forms.DataGridView();
            this.btnSelectDataSet = new System.Windows.Forms.Button();
            this.cbSelectColumnFromMainApp = new System.Windows.Forms.ComboBox();
            this.btnAddToDVG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectedDataSet
            // 
            this.dgvSelectedDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedDataSet.Location = new System.Drawing.Point(12, 68);
            this.dgvSelectedDataSet.Name = "dgvSelectedDataSet";
            this.dgvSelectedDataSet.Size = new System.Drawing.Size(321, 370);
            this.dgvSelectedDataSet.TabIndex = 0;
            // 
            // btnSelectDataSet
            // 
            this.btnSelectDataSet.Location = new System.Drawing.Point(12, 25);
            this.btnSelectDataSet.Name = "btnSelectDataSet";
            this.btnSelectDataSet.Size = new System.Drawing.Size(101, 23);
            this.btnSelectDataSet.TabIndex = 1;
            this.btnSelectDataSet.Text = "Wybierz Słownik";
            this.btnSelectDataSet.UseVisualStyleBackColor = true;
            this.btnSelectDataSet.Click += new System.EventHandler(this.btnSelectDataSet_Click);
            // 
            // cbSelectColumnFromMainApp
            // 
            this.cbSelectColumnFromMainApp.FormattingEnabled = true;
            this.cbSelectColumnFromMainApp.Location = new System.Drawing.Point(119, 25);
            this.cbSelectColumnFromMainApp.Name = "cbSelectColumnFromMainApp";
            this.cbSelectColumnFromMainApp.Size = new System.Drawing.Size(115, 21);
            this.cbSelectColumnFromMainApp.TabIndex = 2;
            // 
            // btnAddToDVG
            // 
            this.btnAddToDVG.Location = new System.Drawing.Point(240, 25);
            this.btnAddToDVG.Name = "btnAddToDVG";
            this.btnAddToDVG.Size = new System.Drawing.Size(93, 23);
            this.btnAddToDVG.TabIndex = 3;
            this.btnAddToDVG.Text = "Dodaj";
            this.btnAddToDVG.UseVisualStyleBackColor = true;
            this.btnAddToDVG.Click += new System.EventHandler(this.btnAddToDVG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wybierz kolumne";
            // 
            // AddDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddToDVG);
            this.Controls.Add(this.cbSelectColumnFromMainApp);
            this.Controls.Add(this.btnSelectDataSet);
            this.Controls.Add(this.dgvSelectedDataSet);
            this.Name = "AddDataSet";
            this.Text = "S";
            this.Load += new System.EventHandler(this.AddDataSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectedDataSet;
        private System.Windows.Forms.Button btnSelectDataSet;
        private System.Windows.Forms.ComboBox cbSelectColumnFromMainApp;
        private System.Windows.Forms.Button btnAddToDVG;
        private System.Windows.Forms.Label label1;
    }
}