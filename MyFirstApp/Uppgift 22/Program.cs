//UPPGIFT 22

//Skriv en funktion som kan ta ett godtyckligt antal strängar
//som parametrar och som returnerar den längsta av dem.

class classUppgift22
{
    static void Main(string[] args)
    {
        Uppgift22Method();
    }
    static void Uppgift22Method()
    {
        Console.WriteLine("Hur många strängar vill du mata in?");
        int antalSträngar = int.Parse(Console.ReadLine());

        var list = new List<string>();
        for (int i = 0; i < antalSträngar; i++)
        {
            list.Add(Console.ReadLine());
        }

        string longestString = String.Empty;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Length > longestString.Length)
            {
                longestString = list[i];
            }
        }
        Console.WriteLine(longestString);


        //VARFÖR FUNGERAR INTE DETTA? Mellan 'a','A','c','C' blir 'C' störst. 'Cc har mindre ASCII värde än 'a','c' men större än 'A'.
        //Console.WriteLine(list.Max());



        //foreach (var i in list)
        //{
        //    Console.WriteLine(i);
        //}
    }
}