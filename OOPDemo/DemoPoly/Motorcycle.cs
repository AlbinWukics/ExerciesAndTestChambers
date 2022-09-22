using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoly
{
    public class Motorcycle : Vehicle
    {
        public string HandlebarStyle { get; set; }

        //Förändring av ett beteende definierat i en förälderklass
        public override void MakeSound()
        {
            Console.WriteLine("Motorcycle goes *BLUBBLUB*");
        }

        // Implementation av en abstrakt metod som är definierad i en förlälderklass
        public override void PrintInfo()
        {
            Console.WriteLine($"Motorcycle has a {HandlebarStyle} handlebar");
        }
    }
}
