using System;

namespace InterfaceExercise
{
    class Program
    {
        public static string V8 { get; private set; }

        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            // using object initilizer syntex and also setting values
            Car car = new Car()
            {
                HasTrunk = true,
                IsConvertible = true,
                IsCoup = true,
                Logo = "Roundel",
                Slogan = "BMW - the ultimate driving machine",
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                EngineType = "V8"

            };

            Truck truck = new Truck()
            {
                HasTrailer = true,
                IsConvertible = false,
                IsCommercial = true,
                Logo = "Chevy",
                Slogan = "find new roads",
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                EngineType = "V8"
            };

            SUV sUV = new SUV()
            {
                HasThirdRowSeats = true,
                IsConvertible = false,
                HasCargoDoors = true,
                Logo = "Mercedes",
                Slogan = "the best or nothing",
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                EngineType = "V8"
            };

            // calling methods for each vehivel-- instance.methodname
            car.DisplayDetails();
            Console.WriteLine(); // just to make a free line in answers

            truck.DisplayDetails();
            Console.WriteLine();

            sUV.DisplayDetails();
            Console.WriteLine();


            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.---- bonus point needs to be done
            //call the method for each vehicle
        }
    }
}
