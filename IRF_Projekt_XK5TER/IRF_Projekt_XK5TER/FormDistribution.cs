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
using System.Windows.Forms.DataVisualization.Charting;

namespace IRF_Projekt_XK5TER
{
    public partial class FormDistribution : Form
    {
        List<Car> carList = new List<Car>();
        List<string> Makes = new List<string>();
        CustomButton cb = new CustomButton();
        public FormDistribution(List<Car> cars, List<string> makes)
        {
            InitializeComponent();
            Formdesign();
            carList = cars;
            Makes = makes;
            
        }
        private void Formdesign()
        {

            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(232, 238, 242);
            chart1.ChartAreas[0].BackColor = Color.FromArgb(232, 238, 242);
            chart1.BackColor=Color.FromArgb(232, 238, 242);
            panel1.Controls.Add(cb);
            cb.MouseClick += Cb_MouseClick;
        }

        private void Cb_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxFiltertype.SelectedItem = null;
            comboBoxFilter.SelectedItem = null;
            chart1.Series["Series1"].Points.Clear();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedItem!=null)
            {
            labelFiltered.Visible = true;
                        labelOthers.Visible = true;
                        if (comboBoxFiltertype.SelectedIndex==0) {ShowFilteredMake();}
                        if (comboBoxFiltertype.SelectedIndex == 1) { ShowFilteredBody(); }
                        if (comboBoxFiltertype.SelectedIndex == 2) { ShowFilteredFuel(); }
                        if (comboBoxFiltertype.SelectedIndex == 3) { ShowFilteredDrivetrain(); }
                        chart1.Series["Series1"].Label = "#PERCENT";
                        chart1.Series["Series1"].Points[0].LegendText = comboBoxFilter.SelectedItem.ToString();
                        chart1.Series["Series1"].Points[1].LegendText = "Egyéb";
                chart1.Series["Series1"].Points[0].Color = Color.FromArgb(119, 182, 234);
                chart1.Series["Series1"].Points[1].Color = Color.FromArgb(199, 211, 221);
            }
            
        }


        private void comboBoxFiltertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFilter.DataSource = null;
            comboBoxFilter.SelectedItem = null;
            if (comboBoxFiltertype.SelectedIndex==0)
            {
                comboBoxFilter.Items.Clear();
                comboBoxFilter.DataSource = Makes;
            }
            if (comboBoxFiltertype.SelectedIndex == 1)
            {
                comboBoxFilter.Items.Clear();
                comboBoxFilter.Items.Add("crossover");
                comboBoxFilter.Items.Add("sedan");
                comboBoxFilter.Items.Add("hatch");
                comboBoxFilter.Items.Add("vagon");
                comboBoxFilter.Items.Add("van");
                comboBoxFilter.Items.Add("other");
            }
            if (comboBoxFiltertype.SelectedIndex == 2)
            {
                comboBoxFilter.Items.Clear();
                comboBoxFilter.Items.Add("Petrol");
                comboBoxFilter.Items.Add("Gas");
                comboBoxFilter.Items.Add("Diesel");
            }
            if (comboBoxFiltertype.SelectedIndex == 3)
            {
                comboBoxFilter.Items.Clear();
                comboBoxFilter.Items.Add("FWD");
                comboBoxFilter.Items.Add("RWD");
                comboBoxFilter.Items.Add("AWD");
            }
        }
        
        private void ShowFilteredMake()
        {
            if (comboBoxFilter.SelectedItem != null)
            {


                chart1.Series["Series1"].Points.Clear();
                int filtered = (from n in carList
                                where n.Make == comboBoxFilter.SelectedItem.ToString()
                                select n).Count();
                chart1.Series["Series1"].Points.AddXY(comboBoxFilter.SelectedItem.ToString(), filtered);
                chart1.Series["Series1"].Points.AddXY("Egyéb", carList.Count - filtered);
                labelFiltered.Text = comboBoxFilter.SelectedItem.ToString() + ": " + filtered.ToString();
                labelOthers.Text = "Egyéb: " + (carList.Count - filtered).ToString();
            }
        }

        private void ShowFilteredBody()
        {

            if (comboBoxFilter.SelectedItem != null)
            {
                chart1.Series["Series1"].Points.Clear();
                int filtered = (from n in carList
                                where n.Body == comboBoxFilter.SelectedItem.ToString()
                                select n).Count();
                chart1.Series["Series1"].Points.AddXY(comboBoxFilter.SelectedItem.ToString(), filtered);
                chart1.Series["Series1"].Points.AddXY("Egyéb", carList.Count - filtered);
                labelFiltered.Text = comboBoxFilter.SelectedItem.ToString() + ": " + filtered.ToString();
                labelOthers.Text = "Egyéb: " + (carList.Count - filtered).ToString();
            }
        }

        private void ShowFilteredFuel()
        {

            if (comboBoxFilter.SelectedItem != null)
            {
                chart1.Series["Series1"].Points.Clear();
                int filtered = (from n in carList
                                where n.Fuel == comboBoxFilter.SelectedItem.ToString()
                                select n).Count();
                chart1.Series["Series1"].Points.AddXY(comboBoxFilter.SelectedItem.ToString(), filtered);
                chart1.Series["Series1"].Points.AddXY("Egyéb", carList.Count - filtered);
                labelFiltered.Text = comboBoxFilter.SelectedItem.ToString() + ": " + filtered.ToString();
                labelOthers.Text = "Egyéb: " + (carList.Count - filtered).ToString();
            }
        }

        private void ShowFilteredDrivetrain()
        {

            if (comboBoxFilter.SelectedItem != null)
            {
                chart1.Series["Series1"].Points.Clear();
                int filtered = (from n in carList
                                where n.Drive == (Drivetrain)Enum.Parse(typeof(Drivetrain), comboBoxFilter.SelectedItem.ToString())
                                select n).Count();
                chart1.Series["Series1"].Points.AddXY(comboBoxFilter.SelectedItem.ToString(), filtered);
                chart1.Series["Series1"].Points.AddXY("Egyéb", carList.Count - filtered);
                labelFiltered.Text = comboBoxFilter.SelectedItem.ToString() + ": " + filtered.ToString();
                labelOthers.Text = "Egyéb: " + (carList.Count - filtered).ToString();
            }
        }
        
    }
}
