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
        string filterX;
        string filterY;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void comboBoxX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDiagram();
        }

        private void comboBoxY_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDiagram();
        }

        private void ShowDiagram()
        {
            if (comboBoxX.SelectedItem!=null && comboBoxY.SelectedItem!=null)
            {
                chart1.Series["Series1"].Points.Clear();

                filterX = comboBoxX.SelectedItem.ToString();
                filterY = comboBoxY.SelectedItem.ToString();
                if (filterX=="Mileage"&&filterY=="Price")
                {
                    carList.Sort((x, y) => x.Mileage.CompareTo(y.Mileage));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Mileage, car.Price);
                    }
                }
                if (filterX == "Mileage" && filterY == "EngV")
                {
                    carList.Sort((x, y) => x.Mileage.CompareTo(y.Mileage));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Mileage, car.EngV);
                    }
                }
                if (filterX == "Mileage" && filterY == "Year")
                {
                    carList.Sort((x, y) => x.Mileage.CompareTo(y.Mileage));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Mileage, car.Year);
                    }
                }
                if (filterX == "Price" && filterY == "Year")
                {
                    carList.Sort((x, y) => x.Price.CompareTo(y.Price));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Price, car.Year);
                    }
                }
                if (filterX == "Price" && filterY == "Mileage")
                {
                    carList.Sort((x, y) => x.Price.CompareTo(y.Price));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Price, car.Mileage);
                    }
                }
                if (filterX == "Price" && filterY == "EngV")
                {
                    carList.Sort((x, y) => x.Price.CompareTo(y.Price));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Price, car.EngV);
                    }
                }
                if (filterX == "Year" && filterY == "EngV")
                {
                    carList.Sort((x, y) => x.Year.CompareTo(y.Year));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Year, car.EngV);
                    }
                }
                if (filterX == "Year" && filterY == "Mileage")
                {
                    carList.Sort((x, y) => x.Year.CompareTo(y.Year));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Year, car.Mileage);
                    }
                }
                if (filterX == "Year" && filterY == "Price")
                {
                    carList.Sort((x, y) => x.Year.CompareTo(y.Year));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.Year, car.Price);
                    }
                }
                if (filterX == "EngV" && filterY == "Price")
                {
                    carList.Sort((x, y) => x.EngV.CompareTo(y.EngV));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.EngV, car.Price);
                    }
                }
                if (filterX == "EngV" && filterY == "Year")
                {
                    carList.Sort((x, y) => x.EngV.CompareTo(y.EngV));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.EngV, car.Year);
                    }
                }
                if (filterX == "EngV" && filterY == "Mileage")
                {
                    carList.Sort((x, y) => x.EngV.CompareTo(y.EngV));
                    foreach (var car in carList)
                    {
                        chart1.Series["Series1"].Points.AddXY(car.EngV, car.Mileage);
                    }
                }
                
            }
            FormatDiagram();
        }
        private void FormatDiagram()
        {
            if (filterX == "Milage")
            {
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = 1000;
                chart1.ChartAreas[0].AxisX.Interval = 50;
            }
            if (filterX == "Price")
            {
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
            if (filterY =="Price")
            {
                chart1.ChartAreas[0].AxisY.Maximum = 300000;
                chart1.ChartAreas[0].AxisY.Interval = 50000;
            }
            if (filterY =="Mileage")
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
        }
    }
}
