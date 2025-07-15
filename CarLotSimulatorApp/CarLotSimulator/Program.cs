using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var carOne = new Car();
            carOne.Make = "BMW";
            carOne.Model = "Slow";
            carOne.Year = 2000;
            carOne.IsDriveable = true;
            
            carOne.MakeEngineNoise("Sputter");
            carOne.MakeHonkNoise("WAHOOO");
            
            carLotOne.ParkingLot.Add(carOne);
            
            var carTwo = new Car()
            {
                Make = "Chevy", 
                Model = "Clunker",
                Year = 2002, 
                IsDriveable = true
            };
            
            carTwo.MakeEngineNoise("Sputter");
            carTwo.MakeHonkNoise("Sighhhh");
            
            carLotOne.ParkingLot.Add(carTwo);

            var carThree = new Car("Ford", "Mustang", 2025, true);
            
            carThree.MakeEngineNoise("ROARRR");
            carThree.MakeHonkNoise("KaBOOOOM");
            
            carLotOne.ParkingLot.Add(carThree);


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of Cars created: {CarLot.numberOfCars}");
            
            carLotOne.CheckCars();
        }
    }
}
