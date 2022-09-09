//UPPGIFT 8
//Skapa ett program som skriver ut 1 på första raden, 2 på nästa, sedan 4, o.s.v (dubbelt så hög siffra för varje rad).
//Fortsätt till du skrivit ut 16 rader.
var siffra = 1;
for (int i = 0; i < 16; i++)
{
    Console.Write(siffra);
    Console.WriteLine("    "+i);
    siffra *= 2;
}