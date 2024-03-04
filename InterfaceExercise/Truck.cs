using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool HasTrailer { get; set; }

        public bool IsCommercial { get; set; }

        public int NumberOfWheels { get ; set ; }

        public int NumberOfDoors { get ; set ; }

        public string EngineType { get ; set ; }

        public bool IsConvertible { get ; set ; }

        public string Logo { get ; set ; }

        public string Slogan { get ; set ; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Has Trailer :{HasTrailer}");
            Console.WriteLine($"Number of Wheels :{NumberOfWheels}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine($"Slogan: {Slogan}");

        }

    }
}
