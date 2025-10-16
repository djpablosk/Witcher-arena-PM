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



int jedenHITM = 5;                                                                          // prvý hit príšere
int druhyHITM = 3;                                                                         // druhý hit príšere
int criticalHITM = 12;                                                                     // kritický hit príšere
int jedenHITP = 16;                                                                         // prvý hit hráčovi
int druhyHITP = 15;                                                                        // druhý hit hráčovi
                                                                  



int jedenHIT = 5;

Console.WriteLine("   (0)   ");                                                                //Príšera


Console.WriteLine("Goblin>Prisera");
Console.WriteLine("Pre HIT stlac H");




int HpM2 = 15;                                                                               // život prišery po prvom zápase
int HpM4 = 12;                                                                              // život príšery po druhom zápase
int HpM6 = 0;                                                                             // život príšery po kritickom hite
int hpP2 = 84;                                                                             // život hráča po prvom zápase
int hpP3 = 69;                                                                            // život hráča po druhom zápase


string action = Console.ReadLine();                                                         //HIT hraca
    if (action == "H" || action == "h")
    {
    int HpM3 = HpM - jedenHITM;
     Console.WriteLine($"Život príšery: {HpM2}");                                               //odčítanie HP príšery
}
    if (HpM <= 0)
    {
        Console.WriteLine("Príšera porazená!");
    }
    else
    {
        Console.WriteLine("Príšera útočí naspäť!");                                             //útok príšery
    int HpP2 = hpP - jedenHITP;
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


    Console.Clear();


Console.WriteLine("Znova stlač H");
string action2 = Console.ReadLine();                                                        //2HIT hraca
if (action2 == "H" || action2 == "h")
{
    int HpM3 = HpM2 - druhyHITM;
    Console.WriteLine($"Život príšery: {HpM3}");         //odčítanie HP príšery po druhom zápase


    Console.WriteLine("Príšera znova útočí!");
    int HpP3 = hpP2 - druhyHITP;
    Console.WriteLine($"Život hráča {playerName}: {HpP3}");
    Console.WriteLine("Pre ďalší HIT stlač H");
    string action3 = Console.ReadLine();                                                         //3HIT hraca
    if (action3 == "H" || action3 == "h")
    {
        Console.WriteLine("Udelil si kritický HIT príšere");
    }
    else if (HpM6 == 0) ;
    {
        int HpM5 = HpM4 - criticalHITM;
        Console.WriteLine($"Život príšery: {HpM5}");         //odčítanie HP po kritickom hite príšery
    }
}


Console.WriteLine("Gratulujeme, úspešne si prešiel prvou arénou!");  //koniec prvej arény
Console.WriteLine("Do vstupu do uzdravovaciej miestnosti stlač ENTER");
Console.ReadLine();

Console.BackgroundColor = ConsoleColor.DarkGreen;                                                //nastavenie farby pozadia
  Console.Clear();
System.Threading.Thread.Sleep(2000);
Console.WriteLine("Vitaj v uzdravovacej miestnosti!");                                               //vstup do uzdravovacej miestnosti
Console.WriteLine("Teraz máš možnosť sa uzdraviť o 10 HP stlač D");                       //možnost liečenia
    string heal = Console.ReadLine();
if (heal == "D" || heal == "d")
{
    int HpP3 = hpP3 + 10;
    Console.WriteLine("Gratulujeme, úspešne si sa uzdravil");
    Console.WriteLine($"Tvoje aktuálne Hpčka sú: {HpP3}");
}

Console.WriteLine("Do vstupu do druhej arény stlač ENTER...");
Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkYellow;                                                             //nastavenie farby pozadia
Console.Clear();
Console.WriteLine("Vitaj v druhej aréne!");                                                                 //vstup do druhej areny
System.Threading.Thread.Sleep(1500);
Console.WriteLine("Práve sa zobúdza príšera Kiklop");
System.Threading.Thread.Sleep(2500);
Console.WriteLine("Príšera sa zoubudila");