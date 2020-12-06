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
    public partial class FormDistribution : Form
    {
        List<Car> carList = new List<Car>();
        public FormDistribution(List<Car> cars)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            int filtered = (from n in carList
                            where n.Make == comboBox1.SelectedItem.ToString()
                            select n).Count();
            chart1.Series["Series1"].Points.AddXY(comboBox1.SelectedItem.ToString(), filtered);
            chart1.Series["Series1"].Points.AddXY("Egyéb", carList.Count - filtered);
            labelFiltered.Text = comboBox1.SelectedItem.ToString() + ": "+filtered.ToString();
            labelOthers.Text = "Egyéb: "+(carList.Count - filtered).ToString();
        }
    }
}
