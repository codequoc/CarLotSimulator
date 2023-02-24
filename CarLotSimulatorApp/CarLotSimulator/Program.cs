using System;
using System.Collections.Generic;
using System.Runtime.Versioning;

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
            var lot = new CarLot();

            var Camry = new Car();
            Camry.Make = "Toyota";
            Camry.Model = "Camry";
            Camry.Year = 2019;
            Camry.EngineNoise = "vroom";
            Camry.HonkNoise = "honk";
            Camry.IsDrivable = true;

            lot.cars.Add(Camry);

            var dadCar = new Car()
            {
                Make = "Toyota",
                Model = "Corolla",
                Year = 2009,
                EngineNoise = "room",
                HonkNoise = "boop",
                IsDrivable = false
            };

            lot.cars.Add(dadCar);

            var dreamCar = new Car(2017, "Tesla", "Model 3", "zoom", "bang", true);

            Camry.MakeEngineNoise(Camry.EngineNoise);
            dadCar.MakeEngineNoise(dadCar.EngineNoise);
            dreamCar.MakeHonkNoise(dreamCar.HonkNoise);

            lot.cars.Add(dreamCar);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var car in lot.cars)
            {
                Console.WriteLine($"Year: {car.Year} Model: {car.Model} Make: {car.Make}");
            }
            Console.WriteLine(CarLot.numberOfCars);
            var lot2 = new CarLot();
            lot2.cars.Add(dreamCar);
            Console.WriteLine(CarLot.numberOfCars);
            
        }
    }
}
