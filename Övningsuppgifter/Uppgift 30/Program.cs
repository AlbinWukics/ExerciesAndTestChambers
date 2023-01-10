//Gör en ny version av sten-sax-påse. Varje spelare ska representeras av ett “Player”-objekt.
//Man ska kunna anropa en metod på objekten som returnerar en enum med ett (random) av tre värden (sten, sax, påse).
//Objekten (klassen) ska ha en konstruktor som tar namn på spelaren, samt en x-, och y-koordinat som
//representerar ett ställe på skärmen där spelarens namn och poäng skrivs ut.
//Det ska finnas en property för poäng som automatisk uppdaterar spelarens poäng
//på den (x/y) positionen på skärmen varje gång man ändrar värdet på propertyn.

// Ex: På översta raden längst till vänster skrivs “Computer: 0”.
// Varje gång man uppdaterar poängen (t.ex computer.Score++;) så uppdateras poängen automatiskt på den positionen.
// Likadant för den andra spelaren.

// Dessutom ska det finnas en statisk metod på klassen som tar två enum (sten, sax, påse) och
// returnerar en ny enum (win, lose, draw) som säger om den första parametern man skickar in vinner över den andra (eller om det blir lika).

// Hint: Använd Console.CursorLeft och Console.CursorTop.
// Spara den tidigare positionen innan du ändrar; gör uppdateringen, och hoppa tillbaks.