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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelMake = new System.Windows.Forms.Label();
            this.labelFiltered = new System.Windows.Forms.Label();
            this.labelOthers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(129, 80);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(285, 236);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Acura",
            "Alfa Romeo",
            "Aro",
            "Aston Martin",
            "Audi",
            "Bentley",
            "BMW",
            "Bogdan",
            "Buick",
            "BYD",
            "Cadillac",
            "Chery",
            "Chevrolet",
            "Chrysler",
            "Citroen",
            "Dacia",
            "Dadi",
            "Daewoo",
            "Daihatsu",
            "Dodge",
            "UAZ",
            "FAW",
            "Ferrari",
            "Fiat",
            "Ford",
            "GAZ",
            "Geely",
            "GMC",
            "Great Wall",
            "Groz",
            "Hafei",
            "Honda",
            "Huanghai",
            "Hummer",
            "Hyundai",
            "Infiniti",
            "Isuzu",
            "JAC",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lamborghini",
            "Lancia",
            "Land Rover",
            "Lexus",
            "Lifan",
            "Lincoln",
            "Maserati",
            "Mazda",
            "Mercedes-Benz",
            "Mercury",
            "MG",
            "MINI",
            "Mitsubishi",
            "Moskvich-AZLK",
            "Moskvich-Izh",
            "Nissan",
            "Opel",
            "Peugeot",
            "Porsche",
            "Renault",
            "Rolls-Royce",
            "Rover",
            "Saab",
            "Samand",
            "Samsung",
            "Seat",
            "Skoda",
            "SMA",
            "Smart",
            "SsangYong",
            "Subaru",
            "Suzuki",
            "TATA",
            "Tesla",
            "Toyota",
            "VAZ",
            "Volkswagen",
            "Volvo",
            "Wartburg"});
            this.comboBox1.Location = new System.Drawing.Point(129, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Location = new System.Drawing.Point(76, 26);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(40, 13);
            this.labelMake.TabIndex = 5;
            this.labelMake.Text = "Márka:";
            // 
            // labelFiltered
            // 
            this.labelFiltered.AutoSize = true;
            this.labelFiltered.Location = new System.Drawing.Point(13, 80);
            this.labelFiltered.Name = "labelFiltered";
            this.labelFiltered.Size = new System.Drawing.Size(35, 13);
            this.labelFiltered.TabIndex = 6;
            this.labelFiltered.Text = "label1";
            // 
            // labelOthers
            // 
            this.labelOthers.AutoSize = true;
            this.labelOthers.Location = new System.Drawing.Point(13, 106);
            this.labelOthers.Name = "labelOthers";
            this.labelOthers.Size = new System.Drawing.Size(35, 13);
            this.labelOthers.TabIndex = 7;
            this.labelOthers.Text = "label2";
            // 
            // FormDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOthers);
            this.Controls.Add(this.labelFiltered);
            this.Controls.Add(this.labelMake);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Name = "FormDistribution";
            this.Text = "FormDistribution";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label labelFiltered;
        private System.Windows.Forms.Label labelOthers;
    }
}