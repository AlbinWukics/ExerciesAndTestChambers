using OOPDemo;

// instansiera ett objekt av typen Player
Player albin = new Player();
albin.Name = "Albin";
albin.Level = 39;
albin.Alive = true;

//instansiera en List innehållandes objekt av typen PLayer
var players = new List<Player>();
//var tal = new List<int>();

//Lägger till en referens till objektet albin som är av typen Player
players.Add(albin);

for (int i = 0; i < 100; i++)
{
    //Samma sak som du gör högst upp. Instansiera ett objekt av typen player
    var player = new Player();
    player.Name = $"Player{i}";
    player.Level = 1;
    player.Alive = true;
    players.Add(player);
    //Console.WriteLine($"{player.Name} is Level {player.Level} and the playe is alive: {player.Alive}");
    //tal.Add(i);
}

foreach (var player in players)
{
    Console.WriteLine(player);
}

//niklas.Alive = true;
//niklas.Name = "Niklas";
//niklas.Level = 1;

//Console.WriteLine($"{niklas.Name} is level: {niklas.Level} and the player is alive: {niklas.Alive}");

//Console.WriteLine(niklas.ToString());

//niklas.PrintName("Niklas");

////instansiera en List innehållandes objekt av typen PLayer
//var players = new List<Player>();
////var tal = new List<int>();

////Lägger till en referens till objektet niklas som är av typen Player
//players.Add(niklas);

//for (int i = 100; i > 0; i--)
//{
//    var player = new Player();
//    player.Name = $"Person{i}";
//    player.Level = i;
//    player.Alive = true;
//    players.Add(player);
//    //tal.Add(i);
//}

////Använd Sort
////tal.Sort();

//// Använd reverse
//players.Reverse();

////foreach (var i in tal)
////{
////    Console.WriteLine(i);
////}

//// Count motsvarar Length på arrayer
//for (int i = 0; i < players.Count; i++)
//{
//    Console.WriteLine(players[i]);
//}


//Använd Sort
//tal.Sort();

//foreach (var i in tal)
//{
//    Console.WriteLine(i);
//}

// Count motsvarar Length på arrayer
//var length = players.Count;
//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine(players.Dequeue());
//}

//while (players.Count > 0)
//{
//    Console.WriteLine(players.Pop());
//}



//Car car1 = new Car();
//Car car2 = new Car();

//car1.Brand = "Volvo";
//car1.Color = "White";

//car2.Brand = "Audi";
//car2.Color = "Nardo Grey";

//car1.PrintCarInfo();
//car2.PrintCarInfo();    


//Console.WriteLine(car1.ToString());