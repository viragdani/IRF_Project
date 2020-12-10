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
    public partial class FormCalculator : Form
    {
        List<Car> carList = new List<Car>();
        List<string> Makes = new List<string>();
        List<Car> FilteredByMake = new List<Car>();
        List<string> Models = new List<string>();
        List<Car> FilteredByModel = new List<Car>();
        List<string> Years = new List<string>();
        List<Car> FilteredByYear = new List<Car>();
        List<string> Fuels = new List<string>();
        List<Car> FilteredByFuel = new List<Car>();
        List<string> Engines = new List<string>();

        public FormCalculator(List<Car> cars)
        {
            InitializeComponent();
            Formdesign();
            carList = cars;
            GetMakes();
            
        }

        private void Formdesign()
        {

            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;

        }
        private void GetMakes()
        {

            Makes.Clear();
            
            foreach (var car in carList)
            {
                if (Makes.Contains(car.Make)==false)
                {
                    Makes.Add(car.Make);
                }
            }
            comboBoxMake.DataSource = Makes;
        }

        private void comboBoxMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            FillModel();

        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillYear();
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillFuel();
        }

        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillEngV();
        }

        private void FillModel()
        {
            comboBoxModel.DataSource = null;
            comboBoxModel.Items.Clear();
            Models.Clear();
            FilteredByMake = (from n in carList
                              where n.Make == comboBoxMake.SelectedItem.ToString()
                              select n).ToList();

            foreach (var car in FilteredByMake)
            {
                if (Models.Contains(car.Model) == false)
                {
                    Models.Add(car.Model);
                }
            }
            comboBoxModel.DataSource = Models;
        }
        private void FillYear()
        {
            comboBoxYear.DataSource = null;
            comboBoxYear.Items.Clear();
            Years.Clear();
            if (comboBoxModel.SelectedItem!=null)
            {
                FilteredByModel = (from n in carList
                                   where n.Model == comboBoxModel.SelectedItem.ToString()
                                   where n.Make == comboBoxMake.SelectedItem.ToString()
                                   select n).ToList();
            }
            

            foreach (var car in FilteredByModel)
            {
                if (Years.Contains(car.Year.ToString()) == false)
                {
                    Years.Add(car.Year.ToString());
                }
            }
            comboBoxYear.DataSource = Years;
        }
        private void FillFuel()
        {
            comboBoxFuel.DataSource = null;
            comboBoxFuel.Items.Clear();
            Fuels.Clear();
            if (comboBoxModel.SelectedItem != null && comboBoxYear.SelectedItem!=null)
            {
                FilteredByYear = (from n in carList
                                   where n.Model == comboBoxModel.SelectedItem.ToString()
                                   where n.Make == comboBoxMake.SelectedItem.ToString()
                                   where n.Year == int.Parse(comboBoxYear.SelectedItem.ToString())
                                   select n).ToList();
            }


            foreach (var car in FilteredByYear)
            {
                if (Fuels.Contains(car.Fuel.ToString()) == false)
                {
                    Fuels.Add(car.Fuel.ToString());
                }
            }
            comboBoxFuel.DataSource = Fuels;
        }
        private void FillEngV()
        {
            comboBoxEngV.DataSource = null;
            comboBoxEngV.Items.Clear();
            Engines.Clear();
            if (comboBoxModel.SelectedItem != null && comboBoxYear.SelectedItem != null && comboBoxFuel.SelectedItem!=null)
            {
                FilteredByFuel = (from n in carList
                                  where n.Model == comboBoxModel.SelectedItem.ToString()
                                  where n.Make == comboBoxMake.SelectedItem.ToString()
                                  where n.Year == int.Parse(comboBoxYear.SelectedItem.ToString())
                                  where n.Fuel==comboBoxFuel.SelectedItem.ToString()
                                  select n).ToList();
            }


            foreach (var car in FilteredByFuel)
            {
                if (Engines.Contains(car.EngV.ToString()) == false)
                {
                    Engines.Add(car.EngV.ToString());
                }
            }
            comboBoxEngV.DataSource = Engines;
        }

    }

}
