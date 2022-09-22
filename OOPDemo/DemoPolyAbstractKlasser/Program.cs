using DemoPolyAbstractKlasser;

var albzin = new Paladin();
var magesos = new Mage();

albzin.ClassName = "Paladin";
albzin.Strength = 20;
albzin.Intelligence = 15;
albzin.SpecialWeapon = "Ashbringer";

magesos.ClassName = "Mage";
magesos.Strength = 8;
magesos.Intelligence = 38;
magesos.SpecialWeapon = "Dragonwrath, Tarecgosa's Rest";

var classes = new List<Class>();
classes.Add(albzin);
classes.Add(magesos);

int j = 0;
foreach (var i in classes)
{
    i.PrintClassInfo();
    i.Warcry();

    if (j == 0)
    {
        Console.WriteLine();
    }
    j++;
}