using System;
using System.Collections.Generic;

namespace CarLotSimulator3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //1. I originally Forked this assignment but I could not run it on my PC because it required .NET Core 2.1.
            //2. So I created a new Console Application on my PC and pushed this one to GitHub.

            //Create a seperate class file called Car - Complete
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - Complete
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - Complete
            //The methods should take one string parameter: the respective noise property - Complete
            //See Car for the first three steps

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. - Complete
            CarLot theDealership = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars - Complete
            //Set the properties for each of the cars - Complete

            //Dot Notation
            Car oldCar = new Car();
            oldCar.Year = 1965;
            oldCar.Make = "Ford";
            oldCar.Model = "F150";
            oldCar.EngineNoise = "Knock";
            oldCar.HonkNoise = "Toot";
            oldCar.IsDriveable = false;

            theDealership.CarList.Add(oldCar);

            //Object Initialization
            Car newCar = new Car()
            {
                Year = 2021,
                Make = "Chevy",
                Model = "Corvette",
                EngineNoise = "Thunder",
                HonkNoise = "Beep",
                IsDriveable = true
            };

            theDealership.CarList.Add(newCar);

            //Object Initializer Syntax
            Car usedCar = new Car() { Year = 2015, Make = "Mazda", Model = "Miata", EngineNoise = "Vroom", HonkNoise = "Bing", IsDriveable = true };

            theDealership.CarList.Add(usedCar);

            //Constructor
            Car myCar = new Car(2018, "Subaru", "BRZ", "Zoom", "Ding", true);

            theDealership.CarList.Add(myCar);

            //Call each of the methods for each car - Complete

            //Method with parameters
            Console.WriteLine("---------------- Engine Sounds!! ------------");
            oldCar.MakeEngineNoise(oldCar.EngineNoise);
            newCar.MakeEngineNoise(newCar.EngineNoise);
            usedCar.MakeEngineNoise(usedCar.EngineNoise);
            myCar.MakeEngineNoise(myCar.EngineNoise);
            Console.WriteLine("---------------- Horn Sounds!! --------------");
            oldCar.MakeHonkNoise(oldCar.HonkNoise);
            newCar.MakeHonkNoise(newCar.HonkNoise);
            usedCar.MakeHonkNoise(usedCar.HonkNoise);
            myCar.MakeHonkNoise(myCar.HonkNoise);

            //Method without parameters
            Console.WriteLine("---------------- Engines Custom -------------");
            oldCar.MakeEngineNoise();
            newCar.MakeEngineNoise();
            usedCar.MakeEngineNoise();
            myCar.MakeEngineNoise();
            Console.WriteLine("--------------- Horns Custom ----------------");
            oldCar.MakeHonkNoise();
            newCar.MakeHonkNoise();
            usedCar.MakeHonkNoise();
            myCar.MakeHonkNoise();

            //Method to test Driveablity
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Now let's check driveablity");
            Console.WriteLine("----------------------------------------------------------");
            oldCar.ReadyToDrive();
            newCar.ReadyToDrive();
            usedCar.ReadyToDrive();
            myCar.ReadyToDrive();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car -Complete

            //*************BONUS X 2*************//

            //Create a CarLot class - Complete
            //It should have at least one property: a List of cars - Complete
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. - Complete Above
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console - Complete

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Here are some specs for each car on the lot.");
            Console.WriteLine("----------------------------------------------------------");
            foreach (var types in theDealership.CarList)
            {
                Console.WriteLine($"Year : {types.Year}, Make: {types.Make}, Model : {types.Model}");
               
            }
        }
    }
}