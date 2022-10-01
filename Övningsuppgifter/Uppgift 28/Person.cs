//Skapa klassen “Person”, med properties “FirstName”, “LastName” och “Name”.
//Om man ändrar någon av dem, så ska man få ut rätt värden när man läser av de andra.
//Använd en konstruktor som tar parametrar “firstName” och “lastName” när man instansierar objekten.
//(I en första enklare version så kan Name vara read-only).
//Ex1. Person p = new Person(“Anna”, “Berg”);
// => p.Name == “Anna Berg”
//Ex2. p.Name = “Per Lind”;
// => p.FirstName == “Per”, p.LastName == “Lind”


public class Person
{
	private string _firstName;

	public string FirstName
	{
		get { return _firstName; }
		set { _firstName = value; }
	}

	private string _lastName;

	public string LastName
	{
		get { return _lastName; }
		set { _lastName = value; }
	}

	private string _name;

	public string Name
	{
		get { return _name; }
        set
        {
            var names = value.Split(" ");
            FirstName = names[0];
            LastName = names[1];
            _name = value;
        }
	}

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
		LastName = lastName;
    }
}





























//namespace Uppgift_28;

//public class Person
//{
//	private string _firstName;

//	public string FirstName
//	{
//		get { return _firstName; }
//		set { _firstName = value; }
//	}

//	private string _lastName;

//	public string LastName
//	{
//		get { return _lastName; }
//		set { _lastName = value; }
//	}

//	private string _name;

//	public string Name
//	{
//		get { return $"{FirstName}{LastName}"; }
//        set
//        {
//            var names = value.Split(" "); //value == "Per Lind"
//            FirstName = names[0];
//            LastName = names[1];
//            _name = value;
//        }
//	}

//	public Person(string firstName, string lastName)
//    {
//        firstName = FirstName;
//		lastName = LastName;
//    }
//}