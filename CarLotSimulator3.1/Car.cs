using System;
using System.Collections.Generic;
namespace CarLotSimulator3._1
{
    public class Car
    {
        public Car()
        {
        }
        //Constructor to set properties during initialization
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        ////Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }
        //Method Overload that will write the associated noise
        public void MakeEngineNoise()
        {
            Console.WriteLine("Let's look under the hood!");
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine("Get out of the way!!");
            Console.WriteLine(HonkNoise);
        }
        //Method to check if car is drivable
        public void ReadyToDrive()
        {
            if (IsDriveable == true)
            {
                Console.WriteLine($"Your {Model} is in good condition. Lets go for a ride!");
            }
            else
            {
                Console.WriteLine($"Hmm..... This {Model} is not too safe to drive.");
            }
        }

    }
}
