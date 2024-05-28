﻿namespace Komponent
{
    partial class EditColumns
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
            this.cbColumnForEdit = new System.Windows.Forms.ComboBox();
            this.btnSliceLeft = new System.Windows.Forms.Button();
            this.LeftSlice = new System.Windows.Forms.NumericUpDown();
            this.btnSliceRight = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnMirror = new System.Windows.Forms.Button();
            this.btnAddNewColumn = new System.Windows.Forms.Button();
            this.cbFirstColumn = new System.Windows.Forms.ComboBox();
            this.cbSecondColumn = new System.Windows.Forms.ComboBox();
            this.tbNewColumn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNewItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNumber = new System.Windows.Forms.Button();
            this.btnRandomAge = new System.Windows.Forms.Button();
            this.minAge = new System.Windows.Forms.NumericUpDown();
            this.maxAge = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSend0 = new System.Windows.Forms.Button();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNewItemEnd = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeftSlice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAge)).BeginInit();
            this.SuspendLayout();
            // 
            // cbColumnForEdit
            // 
            this.cbColumnForEdit.FormattingEnabled = true;
            this.cbColumnForEdit.Location = new System.Drawing.Point(16, 34);
            this.cbColumnForEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbColumnForEdit.Name = "cbColumnForEdit";
            this.cbColumnForEdit.Size = new System.Drawing.Size(160, 24);
            this.cbColumnForEdit.TabIndex = 0;
            // 
            // btnSliceLeft
            // 
            this.btnSliceLeft.Location = new System.Drawing.Point(85, 107);
            this.btnSliceLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSliceLeft.Name = "btnSliceLeft";
            this.btnSliceLeft.Size = new System.Drawing.Size(127, 28);
            this.btnSliceLeft.TabIndex = 1;
            this.btnSliceLeft.Text = "Utnij lewo";
            this.btnSliceLeft.UseVisualStyleBackColor = true;
            this.btnSliceLeft.Click += new System.EventHandler(this.btnSliceLeft_Click);
            // 
            // LeftSlice
            // 
            this.LeftSlice.Location = new System.Drawing.Point(17, 107);
            this.LeftSlice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeftSlice.Name = "LeftSlice";
            this.LeftSlice.Size = new System.Drawing.Size(56, 22);
            this.LeftSlice.TabIndex = 2;
            // 
            // btnSliceRight
            // 
            this.btnSliceRight.Location = new System.Drawing.Point(220, 103);
            this.btnSliceRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSliceRight.Name = "btnSliceRight";
            this.btnSliceRight.Size = new System.Drawing.Size(127, 28);
            this.btnSliceRight.TabIndex = 3;
            this.btnSliceRight.Text = "Utnij Prawo";
            this.btnSliceRight.UseVisualStyleBackColor = true;
            this.btnSliceRight.Click += new System.EventHandler(this.btnSliceRight_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(13, 68);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(164, 28);
            this.btnShuffle.TabIndex = 5;
            this.btnShuffle.Text = "Przetasuj";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnMirror
            // 
            this.btnMirror.Location = new System.Drawing.Point(188, 68);
            this.btnMirror.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMirror.Name = "btnMirror";
            this.btnMirror.Size = new System.Drawing.Size(164, 28);
            this.btnMirror.TabIndex = 6;
            this.btnMirror.Text = "Lustro";
            this.btnMirror.UseVisualStyleBackColor = true;
            this.btnMirror.Click += new System.EventHandler(this.btnMirror_Click);
            // 
            // btnAddNewColumn
            // 
            this.btnAddNewColumn.Location = new System.Drawing.Point(53, 361);
            this.btnAddNewColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNewColumn.Name = "btnAddNewColumn";
            this.btnAddNewColumn.Size = new System.Drawing.Size(132, 28);
            this.btnAddNewColumn.TabIndex = 7;
            this.btnAddNewColumn.Text = "Dodaj Kolumne";
            this.btnAddNewColumn.UseVisualStyleBackColor = true;
            this.btnAddNewColumn.Click += new System.EventHandler(this.btnAddNewColumn_Click);
            // 
            // cbFirstColumn
            // 
            this.cbFirstColumn.FormattingEnabled = true;
            this.cbFirstColumn.Location = new System.Drawing.Point(24, 225);
            this.cbFirstColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFirstColumn.Name = "cbFirstColumn";
            this.cbFirstColumn.Size = new System.Drawing.Size(160, 24);
            this.cbFirstColumn.TabIndex = 8;
            // 
            // cbSecondColumn
            // 
            this.cbSecondColumn.FormattingEnabled = true;
            this.cbSecondColumn.Location = new System.Drawing.Point(196, 225);
            this.cbSecondColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSecondColumn.Name = "cbSecondColumn";
            this.cbSecondColumn.Size = new System.Drawing.Size(160, 24);
            this.cbSecondColumn.TabIndex = 9;
            // 
            // tbNewColumn
            // 
            this.tbNewColumn.Location = new System.Drawing.Point(28, 329);
            this.tbNewColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewColumn.Name = "tbNewColumn";
            this.tbNewColumn.Size = new System.Drawing.Size(160, 22);
            this.tbNewColumn.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pierwsza Kolumna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Druga Kolumna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nowa Kolumna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kolumna do Edycji";
            // 
            // tbNewItem
            // 
            this.tbNewItem.Location = new System.Drawing.Point(24, 274);
            this.tbNewItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewItem.Name = "tbNewItem";
            this.tbNewItem.Size = new System.Drawing.Size(160, 22);
            this.tbNewItem.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dodatek pomiedzy ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(436, 374);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnNumber
            // 
            this.btnNumber.Location = new System.Drawing.Point(220, 159);
            this.btnNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(80, 28);
            this.btnNumber.TabIndex = 16;
            this.btnNumber.Text = "Telefon";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnRandomAge
            // 
            this.btnRandomAge.Location = new System.Drawing.Point(149, 155);
            this.btnRandomAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRandomAge.Name = "btnRandomAge";
            this.btnRandomAge.Size = new System.Drawing.Size(63, 28);
            this.btnRandomAge.TabIndex = 19;
            this.btnRandomAge.Text = "Wiek";
            this.btnRandomAge.UseVisualStyleBackColor = true;
            this.btnRandomAge.Click += new System.EventHandler(this.btnRandomAge_Click);
            // 
            // minAge
            // 
            this.minAge.Location = new System.Drawing.Point(17, 159);
            this.minAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minAge.Name = "minAge";
            this.minAge.Size = new System.Drawing.Size(56, 22);
            this.minAge.TabIndex = 20;
            // 
            // maxAge
            // 
            this.maxAge.Location = new System.Drawing.Point(85, 159);
            this.maxAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxAge.Name = "maxAge";
            this.maxAge.Size = new System.Drawing.Size(56, 22);
            this.maxAge.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Max";
            // 
            // btnSend0
            // 
            this.btnSend0.Location = new System.Drawing.Point(188, 32);
            this.btnSend0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend0.Name = "btnSend0";
            this.btnSend0.Size = new System.Drawing.Size(171, 28);
            this.btnSend0.TabIndex = 25;
            this.btnSend0.Text = "Przekaż";
            this.btnSend0.UseVisualStyleBackColor = true;
            this.btnSend0.Click += new System.EventHandler(this.btnSend0_Click);
            // 
            // btnSend1
            // 
            this.btnSend1.Location = new System.Drawing.Point(195, 361);
            this.btnSend1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(83, 28);
            this.btnSend1.TabIndex = 26;
            this.btnSend1.Text = "Przekaż";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Dodatek koniec";
            // 
            // tbNewItemEnd
            // 
            this.tbNewItemEnd.Location = new System.Drawing.Point(197, 274);
            this.tbNewItemEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewItemEnd.Name = "tbNewItemEnd";
            this.tbNewItemEnd.Size = new System.Drawing.Size(160, 22);
            this.tbNewItemEnd.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(220, 329);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 28);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInc
            // 
            this.btnInc.Location = new System.Drawing.Point(309, 159);
            this.btnInc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(79, 28);
            this.btnInc.TabIndex = 30;
            this.btnInc.Text = "Serial";
            this.btnInc.UseVisualStyleBackColor = true;
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);
            // 
            // EditColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 407);
            this.Controls.Add(this.btnInc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbNewItemEnd);
            this.Controls.Add(this.btnSend1);
            this.Controls.Add(this.btnSend0);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxAge);
            this.Controls.Add(this.minAge);
            this.Controls.Add(this.btnRandomAge);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.tbNewItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNewColumn);
            this.Controls.Add(this.cbSecondColumn);
            this.Controls.Add(this.cbFirstColumn);
            this.Controls.Add(this.btnAddNewColumn);
            this.Controls.Add(this.btnMirror);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnSliceRight);
            this.Controls.Add(this.LeftSlice);
            this.Controls.Add(this.btnSliceLeft);
            this.Controls.Add(this.cbColumnForEdit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditColumns";
            this.Text = "EditColumns";
            this.Load += new System.EventHandler(this.EditColumns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeftSlice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColumnForEdit;
        private System.Windows.Forms.Button btnSliceLeft;
        private System.Windows.Forms.NumericUpDown LeftSlice;
        private System.Windows.Forms.Button btnSliceRight;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnMirror;
        private System.Windows.Forms.Button btnAddNewColumn;
        private System.Windows.Forms.ComboBox cbFirstColumn;
        private System.Windows.Forms.ComboBox cbSecondColumn;
        private System.Windows.Forms.TextBox tbNewColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNewItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.Button btnRandomAge;
        private System.Windows.Forms.NumericUpDown minAge;
        private System.Windows.Forms.NumericUpDown maxAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSend0;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNewItemEnd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInc;
    }
}