﻿using System;
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
        public FormCorrelation()
        {
            InitializeComponent();
            Formdesign();
        }
        private void Formdesign()
        {

            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;

        }
    }
}