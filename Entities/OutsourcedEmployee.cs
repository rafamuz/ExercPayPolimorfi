using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercPayPolimorfi.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHours, double aditionalCharge) 
            : base(name, hours, valuePerHours)
        {
            AditionalCharge = aditionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (AditionalCharge * 1.10);            
        }
    }
}
