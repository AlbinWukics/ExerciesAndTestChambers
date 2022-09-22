using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DemoPolyAbstractKlasser
{
    public class Paladin : Class
    {
        public override void Warcry()
        {
            Console.WriteLine("FOR THE LIGHT");
        }

        public override void PrintClassInfo()
        {
            Console.WriteLine($"The {ClassName} has {Strength} strength, {Intelligence} intelligence and wields the {SpecialWeapon}!");
        }
    }
}
