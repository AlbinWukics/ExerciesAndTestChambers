//Skapa en en klass som har en property “red” och en property “blue”.
//Båda ska vara en float och kunna ha ett värde mellan 0.0 och 100.0 men
//de ska vara “sammankopplade” på så vis att värdena tillsammans alltid är 100.0 d.v.s
//om man t.ex. sätter “blue” till 8.5 och sedan läser av “red” så ska den returnera 91.5


public class Color
{

	private float _blue;

	public float Blue
	{
		get { return _blue; }
        set
        {
            if (value > 100 || value < 0)
            {
                return;
            }

            _blue = value;
            _red = 100 - _blue;
        }
	}

	private float _red;

	public float Red
	{
		get { return _red; }

        set
        {
            if (value > 100 || value < 0)
            {
                return;
            }
            _red = value;
            _blue = 100 - _red;

        }
    }

}






























//namespace Uppgift_27;

//public class Color
//{
//	private float _red = 50;

//	public float Red
//	{
//		get { return _red; }
//        set
//        {
//            if (value < 0.0 && value > 100.0)
//            {
//                return;
//            }
//            _red = value;
//            _blue = 100 - _red;
//        }
//	}

//	private float _blue = 50;

//	public float Blue
//	{
//		get { return _blue; }
//        set
//        {
//            if (value < 0.0 && value > 100.0)
//            {
//                return;
//            }
//            _blue = value;
//            _red = 100 - _blue;

//        }
//    }

//}