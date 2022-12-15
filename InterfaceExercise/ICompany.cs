using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface ICompany
    {
        public string CountryOfOrigin { get; set; }
        public bool LuxuryOrNot { get; set; }

        public void GreatBenefits();
    }
}
