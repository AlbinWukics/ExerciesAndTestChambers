namespace OOPDemo
{
    public class Player
    {
        //deklarerar ett privat fält som bara kan användas i denna klassen, använder property för att exponera dess värde.
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private int _level;
        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }

        private bool _alive;
        public bool Alive
        {
            get
            {
                return _alive;
            }
            set
            {
                _alive = value;
            }
        }

        public void PrintName(List<string> apa)
        {
        }

        public void PrintName(string name)
        {

            Console.WriteLine(Name);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Level: {Level}, Alive: {Alive}";
        }
    }
}






//namespace OOPDemo
//{
//    internal class Car
//    {
//        private string _brand;
//        private string _color;

//        public string Brand
//        {
//            get
//            { 
//                return _brand.ToUpper(); 
//            }
//            set 
//            { 
//                _brand = value; 
//            }
//        }

//        public string Color
//        {
//            get
//            {
//                return _color;
//            }
//            set
//            {
//                _color = value.ToUpper();
//            }
//        }

//        public void PrintCarInfo()
//        {
//            Console.WriteLine($"This is a {Color} {Brand}.");
//        }

//        public static void PrintInfo()
//        {
//            Console.WriteLine("Detta är en static method.");
//        }

//        //public override string ToString()
//        //{
//        //    return $"Brand: {Brand}, color: {Color}.";
//        //}
//    }
//}
