using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

System.Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;   //zistenie verzie
Console.BackgroundColor = ConsoleColor.DarkBlue;                                                //nastavenie farby pozadia
Console.Clear();
Console.WriteLine($"Witcher Arena PM - Version {version}");                                   //zakladne veci (nemenit)
   
Console.WriteLine("Vitaj v Witcher Arena ");                                                 //welcome veta
string title = @"
                __________
\    /     ||        |          /\          |               /   \
 \  /      ||        |         /  \         |               |. .|
  \/       ||        |        /    \    \ _ /               \_ _/

";

Console.WriteLine(title);                                                                      //uvodna grafika
Console.WriteLine("Načítavam hru...");
System.Threading.Thread.Sleep(3000);                                                              //pauza 3s pre animaciu nacitania
Console.Clear();




Console.WriteLine(" Pre pokračovanie zadaj svoj nickname: ");                                                      // zadanie mena
string playerName = Console.ReadLine();
Console.WriteLine("Ahoj " + playerName + ", prave si vstupil do hry Witcher Arena, dúfam že si pripravený na boj!");       //meno
Console.WriteLine("Načítavam postavy...");
System.Threading.Thread.Sleep(4000);                                                              //pauza 4s pre animaciu nacitania
Console.Clear();

Console.WriteLine("Vyber si svoju postavu: ");                                              // výber postavy
Console.WriteLine("1. Alex:");
Console.WriteLine("2. Steve:");
string character = Console.ReadLine();
switch (character)
{
    case "1":
        Console.WriteLine("Vybral si si Alex.");
        break;
    case "2":
        Console.WriteLine("Vybral si si Steve.");
        break;
    default:
        Console.WriteLine("Neplatná voľba, vyber si Alex alebo Steve.");
        break;
}
Console.WriteLine("Stlač ENTER pre pokračovanie...");                                       // enter na pokračovanie a zacanie hry
Console.ReadLine();
Console.Clear();

Console.WriteLine("Toto je tvoja postava");                                                    // zobrazenie postavy
if (character == "1")
{
    Console.WriteLine("  0   ");                                                                //Postava 1 (Alex)
    Console.WriteLine(" /| ");
    Console.WriteLine(" / \\ ");
}
else if (character == "2")                                                                      //Postava 2 (Steve)
{
    Console.WriteLine("  00   ");
    Console.WriteLine("  | ");
    Console.WriteLine(" / / ");
}

Console.WriteLine("Pre načítanie arény stlač ENTER...");                                            //nacitanie areny
Console.ReadLine();
Console.Clear();

Console.WriteLine("Vitaj v prvej aréne!");                                                                 //vstup do areny


int hpP = HpPlayer();                                                                            // načita život hráča
int HpPlayer()
{
    const int hpPlayer = 100;
    Console.WriteLine($"Život hráča {playerName}: {hpPlayer}");
    return hpPlayer;
}

int HpM = HpMonster();                                                                       // načita život príšery
int HpMonster()
{
    const int hpMonster = 20;
    Console.WriteLine($"Život príšery: {hpMonster}");
    return hpMonster;
}
Console.WriteLine("Prvá príšera sa objavuje...");                                              //objavenie príšery
Console.WriteLine("Stlač ENTER pre boj");
Console.ReadLine();
Console.BackgroundColor = ConsoleColor.Red;                                               //zmena farby pozadia
Console.Clear();


int jedenHIT = 5;

Console.WriteLine("   (0)   ");                                                                //Príšera
Console.WriteLine("Hagy>Prisera");
Console.WriteLine("Pre HIT stlač H");

    string action = Console.ReadLine();                                                         //HIT hraca
    if (action == "H" || action == "h")
    {
    int HpM2 = HpM - jedenHIT;
     Console.WriteLine($"Život príšery: {HpM2}");                                               //odčítanie HP príšery
}
    if (HpM <= 0)
    {
        Console.WriteLine("Príšera porazená!");
    }
    else
    {
        Console.WriteLine("Príšera útočí naspäť!");                                             //útok príšery
    int HpP2 = hpP - jedenHIT;
        Console.WriteLine($"Život hráča {playerName}: {HpP2}");
    }
    if (hpP <= 0)
    {
        Console.WriteLine("Si mŕtvy!");
    }
    else
    {
        Console.WriteLine("Pokračuj v boji!");
}
    Console.WriteLine("Stlac ENTER pre pokračovanie...");                                   // enter na pokračovanie
Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkGreen;                                                //nastavenie farby pozadia
Console.Clear();
Console.WriteLine("Teraz máš možnosť sa uzdraviť o 10 HP stlač D");                       //možnost liečenia
string heal = Console.ReadLine();
if (heal == "D" || heal == "d")
    {
        int HpP3 = hpP + 10;
        Console.WriteLine($"Život hráča {playerName}: {HpP3}");
    }
    else
    {
        Console.WriteLine("Pokračuj v boji!");
}







