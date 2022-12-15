using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; } 
        public bool LoudEngine { get; set; } = true;
        public bool HasBackUpCamera { get; set; }  = false;
        public string ColorSpecifications { get; set; } = "black";

        public string CountryOfOrigin { get; set; } 
        public bool LuxuryOrNot { get; set; }

        public void CanDrive()
        {
            Console.WriteLine("Pretty awesome SUV");
        }

        public void CanReverse()
        {
            Console.WriteLine("Greatly can reverse SUV");
        }
        public void GreatBenefits()
        {
         Console.WriteLine( "Benefits in SUV are awesome");
        }
    }
}
