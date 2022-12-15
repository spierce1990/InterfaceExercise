using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public bool LoudEngine { get; set; }
        public bool HasBackUpCamera { get; set; }
        public string ColorSpecifications { get; set; }

        public string CountryOfOrigin { get; set; }
        public bool LuxuryOrNot { get; set; }

        public void CanDrive()
        {
            Console.WriteLine("Can definitely drive");
            if (LoudEngine == true)
            {
                Console.WriteLine("This truck is extremely loud");
            }
            
        }

        public void CanReverse()
        {
            Console.WriteLine("Can definitely reverse");
        }
        public void GreatBenefits()
        {
            if (LuxuryOrNot == true) 
            {
                Console.WriteLine("Most definitely have great benefits and added insurance");
            }
            else { Console.WriteLine("Not so great insurance nor benefits"); }
        }
    }
}
