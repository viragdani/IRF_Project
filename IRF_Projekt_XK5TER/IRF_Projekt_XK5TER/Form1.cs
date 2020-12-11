using IRF_Projekt_XK5TER.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Projekt_XK5TER
{
    public partial class Form1 : Form
    {
        public List<Car> carList = new List<Car>();
        public List<string> Makes = new List<string>();
        Form activeForm = null;
        public Form1()
        {
            InitializeComponent();
            GetCars();
            GetManufacturers();
            Text = "CarMarketAnalyser";
        }


        public void GetCars()
        {

            using (StreamReader sr = new StreamReader("Files/cars.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {

                    var line = sr.ReadLine().Split(';');
                    carList.Add(new Car()
                    {
                        Make = line[0],
                        Price = double.Parse(line[1]),
                        Body = line[2],
                        Mileage = int.Parse(line[3]),
                        EngV = decimal.Parse(line[4]),
                        Fuel = line[5],
                        Year = int.Parse(line[6]),
                        Model = line[7].ToString(),
                        Drive = (Drivetrain)Enum.Parse(typeof(Drivetrain), line[8]),
                    });

                }
            }
        }
        public void GetManufacturers()
        {

            using (StreamReader sr = new StreamReader("Files/ListOfManufacturers.csv", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {

                    var line = sr.ReadLine().Split(';');
                    Makes.Add(line[0]);

                }
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (panelDropDown.Visible == true)
            {
                panelDropDown.Visible = false;
            }
            else
            {
              panelDropDown.Visible = true;      
            }
            
        }

        private void btnDistribution_Click(object sender, EventArgs e)
        {
            if (activeForm != null) { activeForm.Hide(); }
            panelMain.Controls.Clear();
            FormDistribution fd = new FormDistribution(carList, Makes);
            panelMain.Controls.Add(fd);
            activeForm = fd;
            activeForm.Show();
        }

        private void btnCorrelation_Click(object sender, EventArgs e)
        {
            if (activeForm != null) { activeForm.Hide(); }
            panelMain.Controls.Clear();

            FormCorrelation fc = new FormCorrelation(carList);
            panelMain.Controls.Add(fc);
            activeForm = fc;
            activeForm.Show();

        }


        private void btnCalculator_Click(object sender, EventArgs e)
        {
            if (activeForm != null) { activeForm.Hide(); }
            panelMain.Controls.Clear();

            FormCalculator fc2 = new FormCalculator(carList);
            panelMain.Controls.Add(fc2);
            activeForm = fc2;
            activeForm.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (activeForm != null) { activeForm.Hide(); }
            panelMain.Controls.Clear();

            FormHelp fh = new FormHelp();
            panelMain.Controls.Add(fh);
            activeForm = fh;
            activeForm.Show();
        }
    }
}

