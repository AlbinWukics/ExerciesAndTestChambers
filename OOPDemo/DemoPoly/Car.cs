using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoly
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        //Förändring av ett beteende definierat i en förälderklass
        public override void MakeSound()
        {
            Console.WriteLine("Car goes *BRRRR*");
        }

        // Implementation av en abstrakt metod som är definierad i en förlälderklass
        public override void PrintInfo()
        {
            Console.WriteLine($"Car has {NumberOfDoors} doors");
        }
    }
}
