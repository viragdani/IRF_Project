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

        public FormCalculator(List<Car> cars, List<string> makes)
        {
            InitializeComponent();
            Formdesign();
            carList = cars;
            Makes = makes;
            FillMakes();
            
        }

        private void Formdesign()
        {

            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(232, 238, 242);
            buttonCalc.BackColor = Color.FromArgb(199, 211, 221);
            buttonCalc.FlatAppearance.BorderColor = Color.FromArgb(119, 182, 234);
            MessageBox.Show("Kérjük, vegye figyelembe, hogy a becslés a 2019-ben hirdetett hasonló paraméterű autók alapján számítódik!"+Environment.NewLine+ Environment.NewLine + "A valós érték eltérhet többek közt az idő, felszereltség, kondíció és futásteljesítmény függvényében.");

        }
        private void FillMakes()
        {
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

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            revealLabels();
            var darabszam = (from n in carList
                             where n.Make == comboBoxMake.SelectedItem.ToString()
                             where n.Model == comboBoxModel.SelectedItem.ToString()
                             where n.Year == int.Parse(comboBoxYear.SelectedItem.ToString())
                             where n.Fuel == comboBoxFuel.SelectedItem.ToString()
                             where n.EngV == decimal.Parse(comboBoxEngV.SelectedItem.ToString())
                             select n).Count();

           var atlag = (from n in carList
                               where n.Make == comboBoxMake.SelectedItem.ToString()
                               where n.Model == comboBoxModel.SelectedItem.ToString()
                               where n.Year == int.Parse(comboBoxYear.SelectedItem.ToString())
                               where n.Fuel == comboBoxFuel.SelectedItem.ToString()
                               where n.EngV == decimal.Parse(comboBoxEngV.SelectedItem.ToString())
                               select n.Price).Average();
            labelCount.Text = darabszam.ToString() + " db";
            labelValueUSD.Text = atlag.ToString("### ### ### ###") + " USD";
            labelValueFT.Text = (atlag * 300).ToString("### ### ### ###") + " HUF";

            
        }
        private void revealLabels()
        {
            label2.Visible = true;
            label3.Visible = true;
            labelCount.Visible = true;
            labelValueUSD.Visible = true;
            labelValueFT.Visible = true;
        }
    }

}
