using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Projekt_XK5TER.Entities
{
    public class Car
    {
        public string Make { get; set; }
        public double Price { get; set; }
        public string Body { get; set; }
        public int Mileage { get; set; }
        public decimal EngV { get; set; }
        public string Fuel { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public Drivetrain Drive { get; set; }
    }
}
