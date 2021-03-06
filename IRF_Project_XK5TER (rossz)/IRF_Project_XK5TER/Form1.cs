﻿using IRF_Project_XK5TER.Entities;
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

namespace IRF_Project_XK5TER
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            GetCars();
            
        }

        public List<Car> GetCars ()
        {
            List<Car> carList = new List<Car>();

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
                    }) ;

                }
            }
            return carList;
            
        }
    }
}
