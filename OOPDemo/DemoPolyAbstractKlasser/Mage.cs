using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolyAbstractKlasser
{
    public class Mage : Class
    {
        public override void Warcry()
        {
            Console.WriteLine("MY FROSTBOLT WILL FIND YOU");
        }

        public override void PrintClassInfo()
        {
            Console.WriteLine($"The {ClassName} has {Strength} strength, {Intelligence} intelligence and wields the {SpecialWeapon}!");
        }
    }
}
