//UPPGIFT 23

//Skapa en metod int[] IndexOfAll(string text, char c) som söker igenom strängen text
//och returnerar en int[] med index till alla förekomster av c i text.


class ClassUppgift23
{
    static void Main(string[] args)
    {
        int[] array = IndexOfAll("abcabc", 'c');

        foreach (var i in array)
        {
            Console.WriteLine(i);
        }
    }

    static int[] IndexOfAll(string text, char c)
    {
        var list = new List<int>();
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == c)
            {
                list.Add(i);
            }
        }
        int[] result = list.ToArray();
        
        return result;
    }
}