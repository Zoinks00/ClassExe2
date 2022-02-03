using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        public Car()
        {
            CarLot.numOfCars++;
        }

        public Car(string make, string model, int year, string enginenoise, string honknoise, bool isdrivable)
            {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDriveable = isdrivable;
            }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


           public void MakeEngineNoise(string eNoise)
           {
             Console.WriteLine(eNoise);
           }

        public void MakeHonkNoise(string eHonk)
        {
            Console.WriteLine(eHonk);
        }
    }
   
}
