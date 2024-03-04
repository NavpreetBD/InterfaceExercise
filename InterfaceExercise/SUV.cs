using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class  SUV : IVehicle, ICompany
    {
        public bool HasThirdRowSeats { get; set; }

        public bool HasCargoDoors { get; set; }

        public int NumberOfWheels { get ; set ; }

        public int NumberOfDoors { get ; set ; }

        public string EngineType { get ; set ; }

        public bool IsConvertible { get ; set ; }

        public string Logo { get ; set ; }

        public string Slogan { get ; set ; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Has Third row seats: {HasThirdRowSeats}");
            Console.WriteLine($"Number of Wheels :{NumberOfWheels}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine($"Slogan: {Slogan}");

        }

    }
}
