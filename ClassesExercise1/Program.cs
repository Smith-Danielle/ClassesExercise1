using System;

namespace ClassesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dot Notation
            Car myCar = new Car();

            myCar.Make = "Subaru";  
            myCar.Model = "BRZ";
            myCar.Year = 2018;

            Console.WriteLine($"Being that {myCar.Make} is a good brand, in {myCar.Year}, I decided to purchase a new {myCar.Model}.");

            //Or Object Initialization
            var husbandCar = new Car()
            {
                Make = "Mercedes",
                Model = "C350",
                Year = 2008
            };

            Console.WriteLine($"However, my husband likes {husbandCar.Make}. He drives a {husbandCar.Model} made in {husbandCar.Year}.");

            //Or Object Initializer Syntax
            Car oldCar = new Car() { Make = "Chevy", Model = "Camero", Year = 2011 };

            Console.WriteLine($"I love {oldCar.Make} as well. My last car was a {oldCar.Year} {oldCar.Model}.");

            //Constructor
            Car modelCar = new Car("Ford", "Mustang", 2021);

            Console.WriteLine($"Another good brand is {modelCar.Make}. My favorite model is the {modelCar.Model}. The {modelCar.Year} model is very nice."); 
        }
    }
}
