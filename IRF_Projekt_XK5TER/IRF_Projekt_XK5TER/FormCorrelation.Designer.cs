namespace IRF_Projekt_XK5TER
{
    partial class FormCorrelation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelX = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxX = new System.Windows.Forms.ComboBox();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.labelY = new System.Windows.Forms.Label();
            this.labelCorr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTxtResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(47, 23);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 13);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(-5, 63);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(673, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // comboBoxX
            // 
            this.comboBoxX.FormattingEnabled = true;
            this.comboBoxX.Items.AddRange(new object[] {
            "Mileage",
            "Price",
            "EngV",
            "Year"});
            this.comboBoxX.Location = new System.Drawing.Point(70, 20);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(121, 21);
            this.comboBoxX.TabIndex = 3;
            this.comboBoxX.SelectedIndexChanged += new System.EventHandler(this.comboBoxX_SelectedIndexChanged);
            // 
            // comboBoxY
            // 
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Items.AddRange(new object[] {
            "Mileage",
            "Price",
            "EngV",
            "Year"});
            this.comboBoxY.Location = new System.Drawing.Point(253, 20);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(121, 21);
            this.comboBoxY.TabIndex = 4;
            this.comboBoxY.SelectedIndexChanged += new System.EventHandler(this.comboBoxY_SelectedIndexChanged);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(230, 23);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 13);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "Y:";
            // 
            // labelCorr
            // 
            this.labelCorr.AutoSize = true;
            this.labelCorr.Location = new System.Drawing.Point(526, 28);
            this.labelCorr.Name = "labelCorr";
            this.labelCorr.Size = new System.Drawing.Size(0, 13);
            this.labelCorr.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Korreláció mértéke:";
            // 
            // labelTxtResult
            // 
            this.labelTxtResult.AutoSize = true;
            this.labelTxtResult.Location = new System.Drawing.Point(517, 47);
            this.labelTxtResult.Name = "labelTxtResult";
            this.labelTxtResult.Size = new System.Drawing.Size(0, 13);
            this.labelTxtResult.TabIndex = 8;
            // 
            // FormCorrelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTxtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCorr);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.comboBoxY);
            this.Controls.Add(this.comboBoxX);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelX);
            this.Name = "FormCorrelation";
            this.Text = "FormCorrelation";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBoxX;
        private System.Windows.Forms.ComboBox comboBoxY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelCorr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTxtResult;
    }
}