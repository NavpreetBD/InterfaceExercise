using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }

        public bool IsCoup { get; set; } = false;

        public int NumberOfWheels { get ; set ; }

        public int NumberOfDoors { get ; set ; }

        public string EngineType { get ; set ; }

        public bool IsConvertible { get ; set ; }

        public string Logo { get ; set ; }

        public string Slogan { get ; set ; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Has Trunk :{HasTrunk}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine($"Slogan: {Slogan}");

        }

    }
}
