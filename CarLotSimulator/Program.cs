using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot carYard = new CarLot();
            var Ford = new Car();
            carYard.CarInv.Add(Ford);
            {
                Ford.Make = "Ford";
                Ford.Model = "Ranger";
                Ford.Year = 2005;
                Ford.EngineNoise = "Chug Chug Chug";
                Ford.HonkNoise = "Meep Meep\n";
                Ford.IsDriveable = true;

                
            }
          
            //Method calling 
            Ford.MakeEngineNoise(Ford.EngineNoise);
            Ford.MakeHonkNoise(Ford.HonkNoise);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX-7",
                Year = 2010,
                EngineNoise = "Tink Tink",
                HonkNoise = "Hoooonk\n",
                IsDriveable = true,

                
                 };
            carYard.CarInv.Add(mazda);

           
            mazda.MakeEngineNoise(mazda.EngineNoise);
            mazda.MakeHonkNoise(mazda.HonkNoise);

            var Jeep = new Car("Jeep", "Grand Cherokee", 1993, "clank", "EEP EEP\n", false);
            
            carYard.CarInv.Add(Jeep);
           
            Jeep.MakeEngineNoise(Jeep.EngineNoise);
            Jeep.MakeHonkNoise(Jeep.HonkNoise);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        Console.WriteLine("--------\n\n");
        foreach(var item in carYard.CarInv)
            {
                
                Console.WriteLine($" Car Make: {item.Make}\n Car Model: {item.Model}\n Car Year: {item.Year}\n");
            }
        }
             
    }
}
