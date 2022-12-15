using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public bool LoudEngine { get; set; }
        public bool HasBackUpCamera { get; set; }
        public string ColorSpecifications { get; set; }

        public void CanDrive();

        public void CanReverse();
    }
}
