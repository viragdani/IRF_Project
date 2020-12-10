namespace IRF_Projekt_XK5TER
{
    partial class FormDistribution
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.labelFiltered = new System.Windows.Forms.Label();
            this.labelOthers = new System.Windows.Forms.Label();
            this.comboBoxFiltertype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Tomato,
        System.Drawing.Color.WhiteSmoke};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(523, 333);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(129, 32);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilter.TabIndex = 4;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // labelFiltered
            // 
            this.labelFiltered.AutoSize = true;
            this.labelFiltered.Location = new System.Drawing.Point(13, 80);
            this.labelFiltered.Name = "labelFiltered";
            this.labelFiltered.Size = new System.Drawing.Size(35, 13);
            this.labelFiltered.TabIndex = 6;
            this.labelFiltered.Text = "label1";
            this.labelFiltered.Visible = false;
            // 
            // labelOthers
            // 
            this.labelOthers.AutoSize = true;
            this.labelOthers.Location = new System.Drawing.Point(13, 106);
            this.labelOthers.Name = "labelOthers";
            this.labelOthers.Size = new System.Drawing.Size(35, 13);
            this.labelOthers.TabIndex = 7;
            this.labelOthers.Text = "label2";
            this.labelOthers.Visible = false;
            // 
            // comboBoxFiltertype
            // 
            this.comboBoxFiltertype.FormattingEnabled = true;
            this.comboBoxFiltertype.Items.AddRange(new object[] {
            "Márka",
            "Kivitel",
            "Üzemanyag",
            "Hajtás"});
            this.comboBoxFiltertype.Location = new System.Drawing.Point(32, 32);
            this.comboBoxFiltertype.Name = "comboBoxFiltertype";
            this.comboBoxFiltertype.Size = new System.Drawing.Size(78, 21);
            this.comboBoxFiltertype.TabIndex = 8;
            this.comboBoxFiltertype.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltertype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Szűrő típusa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Feltétel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(129, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 333);
            this.panel1.TabIndex = 11;
            // 
            // FormDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFiltertype);
            this.Controls.Add(this.labelOthers);
            this.Controls.Add(this.labelFiltered);
            this.Controls.Add(this.comboBoxFilter);
            this.Name = "FormDistribution";
            this.Text = "FormDistribution";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label labelFiltered;
        private System.Windows.Forms.Label labelOthers;
        private System.Windows.Forms.ComboBox comboBoxFiltertype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}