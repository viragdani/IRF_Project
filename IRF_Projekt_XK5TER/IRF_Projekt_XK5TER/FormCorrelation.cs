using IRF_Projekt_XK5TER.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IRF_Projekt_XK5TER
{
    public partial class FormCorrelation : Form
    {
        List<Car> carList = new List<Car>();
        List<double> values1 = new List<double>();
        List<double> values2 = new List<double>();
        string filterX;
        string filterY;
        CustomButton cb = new CustomButton();
        public FormCorrelation(List<Car> cars)
        {
            InitializeComponent();
            Formdesign();
            carList = cars;
        }
        private void Formdesign()
        {

            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(232, 238, 242);
            chart1.ChartAreas[0].BackColor = Color.FromArgb(232, 238, 242);
            chart1.BackColor = Color.FromArgb(232, 238, 242);
            panel1.Controls.Add(cb);
            cb.MouseClick += Cb_MouseClick;
        }

        private void Cb_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxX.SelectedItem = null;
            comboBoxY.SelectedItem = null;
            labelCorr.Text = null;
            labelTxtResult.Text = null;
            chart1.Series["Series1"].Points.Clear();
        }

        private void comboBoxX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDiagram();
            FormatDiagram();
        }

        private void comboBoxY_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDiagram();
            FormatDiagram();
        }

        private void ShowDiagram()
        {
            if (comboBoxX.SelectedItem!=null && comboBoxY.SelectedItem!=null)
            {
                chart1.Series["Series1"].Points.Clear();
                values1.Clear();
                values2.Clear();

                filterX = comboBoxX.SelectedItem.ToString();
                filterY = comboBoxY.SelectedItem.ToString();
                if (filterX=="Mileage"&&filterY=="Price")
                {
                    carList.Sort((x, y) => x.Mileage.CompareTo(y.Mileage));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Mileage, car.Price);
                        
                       values1.Add(car.Mileage);
                       values2.Add(car.Price);
                    }
                }
                if (filterX == "Mileage" && filterY == "EngV")
                {
                    carList.Sort((x, y) => x.Mileage.CompareTo(y.Mileage));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Mileage, car.EngV);

                        values1.Add(car.Mileage);
                        values2.Add(decimal.ToDouble(car.EngV));
                    }
                }
                if (filterX == "Mileage" && filterY == "Year")
                {
                    carList.Sort((x, y) => x.Mileage.CompareTo(y.Mileage));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Mileage, car.Year);

                        values1.Add(car.Mileage);
                        values2.Add(car.Year);
                    }
                }
                if (filterX == "Price" && filterY == "Year")
                {
                    carList.Sort((x, y) => x.Price.CompareTo(y.Price));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Price, car.Year);

                        values1.Add(car.Price);
                        values2.Add(car.Year);
                    }
                }
                if (filterX == "Price" && filterY == "Mileage")
                {
                    carList.Sort((x, y) => x.Price.CompareTo(y.Price));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Price, car.Mileage);

                        values1.Add(car.Price);
                        values2.Add(car.Mileage);
                    }
                }
                if (filterX == "Price" && filterY == "EngV")
                {
                    carList.Sort((x, y) => x.Price.CompareTo(y.Price));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Price, car.EngV);

                        values1.Add(car.Price);
                        values2.Add(decimal.ToDouble(car.EngV));
                    }
                }
                if (filterX == "Year" && filterY == "EngV")
                {
                    carList.Sort((x, y) => x.Year.CompareTo(y.Year));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Year, car.EngV);

                        values1.Add(car.Year);
                        values2.Add(decimal.ToDouble(car.EngV));
                    }
                }
                if (filterX == "Year" && filterY == "Mileage")
                {
                    carList.Sort((x, y) => x.Year.CompareTo(y.Year));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Year, car.Mileage);

                        values1.Add(car.Year);
                        values2.Add(car.Mileage);
                    }
                }
                if (filterX == "Year" && filterY == "Price")
                {
                    carList.Sort((x, y) => x.Year.CompareTo(y.Year));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Year, car.Price);

                        values1.Add(car.Year);
                        values2.Add(car.Price);
                    }
                }
                if (filterX == "EngV" && filterY == "Price")
                {
                    carList.Sort((x, y) => x.EngV.CompareTo(y.EngV));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.EngV, car.Price);

                        values1.Add(decimal.ToDouble(car.EngV));
                        values2.Add(car.Price);
                    }
                }
                if (filterX == "EngV" && filterY == "Year")
                {
                    carList.Sort((x, y) => x.EngV.CompareTo(y.EngV));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.EngV, car.Year);

                        values1.Add(decimal.ToDouble(car.EngV));
                        values2.Add(car.Year);
                    }
                }
                if (filterX == "EngV" && filterY == "Mileage")
                {
                    carList.Sort((x, y) => x.EngV.CompareTo(y.EngV));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.EngV, car.Mileage);

                        values1.Add(decimal.ToDouble(car.EngV));
                        values2.Add(car.Mileage);
                    }
                }

                CalculateCorrelation();
                
            }

        }
        private void FormatDiagram()
        {
            if (comboBoxX.SelectedItem!=comboBoxY.SelectedItem)
            {
                if (filterX == "Mileage")
                {
                    chart1.ChartAreas[0].AxisX.Minimum = 0;
                    chart1.ChartAreas[0].AxisX.Maximum = 1000;
                    chart1.ChartAreas[0].AxisX.Interval = 50;
                }
                if (filterX == "Price")
                {
                    chart1.ChartAreas[0].AxisX.Minimum = 0;
                    chart1.ChartAreas[0].AxisX.Maximum = 300000;
                    chart1.ChartAreas[0].AxisX.Interval = 50000;
                }
                if (filterX == "EngV")
                {
                    chart1.ChartAreas[0].AxisX.Minimum = 0;
                    chart1.ChartAreas[0].AxisX.Maximum = 10;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                }
                if (filterX == "Year")
                {
                    chart1.ChartAreas[0].AxisX.Minimum = 1960;
                    chart1.ChartAreas[0].AxisX.Maximum = 2020;
                    chart1.ChartAreas[0].AxisX.Interval = 5;
                }
                if (filterY == "Price")
                {
                    chart1.ChartAreas[0].AxisY.Minimum = 0;
                    chart1.ChartAreas[0].AxisY.Maximum = 300000;
                    chart1.ChartAreas[0].AxisY.Interval = 50000;
                }
                if (filterY == "Mileage")
                {
                    chart1.ChartAreas[0].AxisY.Minimum = 0;
                    chart1.ChartAreas[0].AxisY.Maximum = 1000;
                    chart1.ChartAreas[0].AxisY.Interval = 50;
                }
                if (filterY == "EngV")
                {
                    chart1.ChartAreas[0].AxisY.Minimum = 0;
                    chart1.ChartAreas[0].AxisY.Maximum = 10;
                    chart1.ChartAreas[0].AxisY.Interval = 1;
                }
                if (filterY == "Year")
                {
                    chart1.ChartAreas[0].AxisY.Minimum = 1960;
                    chart1.ChartAreas[0].AxisY.Maximum = 2020;
                    chart1.ChartAreas[0].AxisY.Interval = 5;
                }
                chart1.Series["Series1"].Color = Color.FromArgb(119, 182, 234);
            }
            
        }

        private void CalculateCorrelation()
        {
            if (comboBoxX.SelectedItem!=comboBoxY.SelectedItem)
            {
                var avg1 = values1.Average();
                var avg2 = values2.Average();

                var sum1 = values1.Zip(values2, (x1, y1) => (x1 - avg1) * (y1 - avg2)).Sum();

                var sumSqr1 = values1.Sum(x => Math.Pow((x - avg1), 2.0));
                var sumSqr2 = values2.Sum(y => Math.Pow((y - avg2), 2.0));

                var result = sum1 / Math.Sqrt(sumSqr1 * sumSqr2);

                labelCorr.Text = "P-érték= "+Math.Round(result,4).ToString();
                if (Math.Abs(result) >= 0 && Math.Abs(result)<=0.29)
                {
                    labelTxtResult.Text = "Gyenge korreláció";
                }
                if (Math.Abs(result) >= 0.3 && Math.Abs(result) <= 0.49)
                {
                    labelTxtResult.Text = "Közepes korreláció";
                }
                if (Math.Abs(result) >= 0.5 && Math.Abs(result) <= 1)
                {
                    labelTxtResult.Text = "Erős korreláció";
                }
            }
            else 
            { 
                labelCorr.Text = null;
                labelTxtResult.Text = null;
            }
            
        }
    }
}
