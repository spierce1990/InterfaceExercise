using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            List<IVehicle> thelist = new List<IVehicle>();

            Car dodge = new Car() { LoudEngine = true, HasBackUpCamera = true, LuxuryOrNot = false};
            Truck ford = new Truck() { LoudEngine = true, ColorSpecifications = "black",  LuxuryOrNot = true};   
            SUV bmw  = new SUV()  { CountryOfOrigin = "Europe", LuxuryOrNot = true };

            

            thelist.Add(dodge);
            thelist.Add(ford);
            thelist.Add(bmw);
           
            foreach (var item in thelist)
            {
                Console.WriteLine($" { item.LoudEngine}, { item.ColorSpecifications}, { item.HasBackUpCamera}, " );
               
                
            }
            ;/* ublic int NumberOfWheels { get; set; }
        public bool LoudEngine { get; set; }
        public bool HasBackUpCamera { get; set; }
        public string ColorSpecifications { get; set; }

        public string CountryOfOrigin { get; set; }
        public bool LuxuryOrNot { get; set; }
            
*/
        }

    }
}
