using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("Building a Motorcycle");
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public void Drive()
        {
            Console.WriteLine("The motorcycle is driving");
        }

    }
}
