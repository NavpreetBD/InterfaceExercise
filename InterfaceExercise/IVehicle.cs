using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string EngineType { get; set; }
        public bool IsConvertible { get; set; }

        public void DisplayDetails(); // stubbed out method
    }
}
