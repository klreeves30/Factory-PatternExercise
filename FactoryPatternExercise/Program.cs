using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does your vehicle have");
            string numberOfWheels = Console.ReadLine();
            
            IVehicle vehicle = VehicleFactory.GetVehicle(numberOfWheels);

            vehicle.Drive();

            var myCar = new Car() { Color = "Black", Year = 2022, Make = "Honda", Model = "Accord" };
            var myMotorcycle = new Motorcycle() { Color = "Red", Year = 2017, Make = "Harley-Davidson", Model = "Red Wing" };
            
            if (numberOfWheels == "4")
            {
                Console.WriteLine($"My new car is an {myCar.Make} {myCar.Model}");
            }
            else if(numberOfWheels != "4")
            {
                Console.WriteLine("Your vehicle is not a car\n");
                Console.WriteLine("You are building a motorcycle\n");
            }
            else if (numberOfWheels == "2")
            {
                Console.WriteLine($"My new motorcycle is an {myMotorcycle.Make} {myMotorcycle.Model}");
            }

           

           





        }
       
    }
}
