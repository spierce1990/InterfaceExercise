using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany

    {
        public int NumberOfWheels { get; set; }
        public bool LoudEngine { get; set; }
        public bool HasBackUpCamera { get; set; }
        public string ColorSpecifications { get; set; }

        public string CountryOfOrigin { get; set; }
        public bool LuxuryOrNot { get; set; }

        public void CanDrive()
        {
            Console.WriteLine(  "This car can drive and reverse");
        
        }

        public void CanReverse()
        {
            if (HasBackUpCamera== true)
            {
                CanDrive();
            }
        }

        public void GreatBenefits()
       { Console.WriteLine("Offering Great Added Benefits" ); }
    }
}
