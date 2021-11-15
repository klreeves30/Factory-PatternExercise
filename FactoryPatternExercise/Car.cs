using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("building a new car");
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public void Drive()
        {
            Console.WriteLine("The car is driving.");
        }


    }
}
