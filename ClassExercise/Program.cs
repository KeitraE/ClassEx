using System;
using System.Collections.Generic;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2015;

            var chevy = new Car()
            {
                Make = "Chevy",
                Model = "Impala",
                Year = 2016
            };

            var dodge = new Car("Dodge", "Ram", 2003);

            var carList = new List<Car>() { myCar, chevy, dodge };

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
