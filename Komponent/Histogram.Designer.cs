namespace Komponent
{
    partial class Histogram
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
            this.btnMainAppHistogram = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_3D = new System.Windows.Forms.RadioButton();
            this.radioButton_2D = new System.Windows.Forms.RadioButton();
            this.histogramPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.columnChooser = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainAppHistogram
            // 
            this.btnMainAppHistogram.Location = new System.Drawing.Point(16, 15);
            this.btnMainAppHistogram.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainAppHistogram.Name = "btnMainAppHistogram";
            this.btnMainAppHistogram.Size = new System.Drawing.Size(31, 28);
            this.btnMainAppHistogram.TabIndex = 0;
            this.btnMainAppHistogram.Text = "<";
            this.btnMainAppHistogram.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_3D);
            this.groupBox1.Controls.Add(this.radioButton_2D);
            this.groupBox1.Location = new System.Drawing.Point(16, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz model";
            // 
            // radioButton_3D
            // 
            this.radioButton_3D.AutoSize = true;
            this.radioButton_3D.Location = new System.Drawing.Point(7, 49);
            this.radioButton_3D.Name = "radioButton_3D";
            this.radioButton_3D.Size = new System.Drawing.Size(45, 20);
            this.radioButton_3D.TabIndex = 1;
            this.radioButton_3D.TabStop = true;
            this.radioButton_3D.Text = "3D";
            this.radioButton_3D.UseVisualStyleBackColor = true;
            this.radioButton_3D.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton_2D
            // 
            this.radioButton_2D.AutoSize = true;
            this.radioButton_2D.Location = new System.Drawing.Point(7, 22);
            this.radioButton_2D.Name = "radioButton_2D";
            this.radioButton_2D.Size = new System.Drawing.Size(45, 20);
            this.radioButton_2D.TabIndex = 0;
            this.radioButton_2D.TabStop = true;
            this.radioButton_2D.Text = "2D";
            this.radioButton_2D.UseVisualStyleBackColor = true;
            this.radioButton_2D.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // histogramPanel
            // 
            this.histogramPanel.Location = new System.Drawing.Point(145, 50);
            this.histogramPanel.Name = "histogramPanel";
            this.histogramPanel.Size = new System.Drawing.Size(1158, 506);
            this.histogramPanel.TabIndex = 4;
            this.histogramPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.histogramPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz kolumne";
            // 
            // columnChooser
            // 
            this.columnChooser.FormattingEnabled = true;
            this.columnChooser.Location = new System.Drawing.Point(18, 164);
            this.columnChooser.Name = "columnChooser";
            this.columnChooser.Size = new System.Drawing.Size(121, 24);
            this.columnChooser.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.columnChooser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.histogramPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMainAppHistogram);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Histogram";
            this.Text = "Histogram";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainAppHistogram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_3D;
        private System.Windows.Forms.RadioButton radioButton_2D;
        private System.Windows.Forms.Panel histogramPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox columnChooser;
        private System.Windows.Forms.Button button1;
    }
}