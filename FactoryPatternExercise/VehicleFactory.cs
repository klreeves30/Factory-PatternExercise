using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string wheels)
        {
            switch (wheels.ToLower())
            {
                case "4":
                case "four":
                    return new Car();
                case "2":
                case "two":
                    return  new Motorcycle();
                default:
                    return new Car();

            }

            
            
        }

        public static IVehicle GetVehicleType(string type)
        {
            switch (type.ToLower())
            {
                case "Toyota":
                case "toyota":
                        return new Car();
                case "Honda":
                case "honda":
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }


    }
}
