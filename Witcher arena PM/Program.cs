using System.ComponentModel;
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
System.Threading.Thread.Sleep(2500);                                                              //pauza 2,5s pre animaciu nacitania
Console.Clear();

Console.WriteLine("Vitaj v hre Witcher Arena!");
List<string> menuOptions = new List<string> { "Hrat (H)", "Opis (O)" };                           //hlavne menu
foreach (string option in menuOptions)
{
    Console.WriteLine(option);
}
string menuChoice = Console.ReadLine();                                                          //výber z menu
switch (menuChoice.ToUpper())
{
    case "H":
        Console.WriteLine("Začínaš hru...");                                                      //začatie hry
        System.Threading.Thread.Sleep(1000);
        Console.Clear();
        break;
    case "O":
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.Clear();
        Console.WriteLine("Witcher Arena je textová RPG hra, v ktorej si vyberieš postavu a bojuješ proti príšerám v rôznych arénach. Cieľom je prežiť a poraziť všetky príšery.");         //opis hry
        Console.WriteLine("Hra obsahuje rôzne postavy, každá s unikátnymi schopnosťami, a rôzne arény s rôznymi príšerami.");
        Console.WriteLine("Túto hru vytvorili Michal Vancel a Patrik Smržo");
        Console.WriteLine("Stlač ENTER pre návrat do hlavného menu...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Vitaj v hre Witcher Arena!");
        foreach (string option in menuOptions)
        {
            Console.WriteLine(option);
        }
        menuChoice = Console.ReadLine();
        break;
    default:
        Console.WriteLine("Neplatná voľba, skúste znova.");                                                      //neplatná voľba
        break;
}




Console.WriteLine(" Pre pokračovanie zadaj svoj nickname: ");                                                      // zadanie mena
string playerName = Console.ReadLine();
Console.WriteLine("Ahoj " + playerName + ", prave si vstupil do hry Witcher Arena, dúfam že si pripravený na boj!");       //meno
Console.WriteLine("Načítavam postavy...");
System.Threading.Thread.Sleep(2000);                                                              //pauza 2s pre animaciu nacitania
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
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine($"Život príšery: {HpM2}");                                               //odčítanie HP príšery
}
    if (HpM <= 0)
    {
        Console.WriteLine("Príšera porazená!");
    }
    else
    {
        Console.WriteLine("Príšera útočí naspäť!");                      //útok príšery
    System.Threading.Thread.Sleep(1500);
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
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine($"Život príšery: {HpM3}");         //odčítanie HP príšery po druhom zápase


    Console.WriteLine("Príšera znova útočí!");
    System.Threading.Thread.Sleep(1500);
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
        System.Threading.Thread.Sleep(1500);
        Console.WriteLine($"Život príšery: {HpM5}");         //odčítanie HP po kritickom hite príšery
    }
}
Console.WriteLine("Z príšery vypadol uzdravovací lektvar");                             //vypadnutie lektvaru)
Console.WriteLine("Pre získanie lektvaru stlač L");
string lektvar = Console.ReadLine();
if (lektvar == "L" || lektvar == "l")
{
    
    Console.WriteLine("Zobral si lektvar do inventára");
}
Console.WriteLine("Pre otvorenie inventára stlač E");
string inventar = Console.ReadLine();

List<string> inventory = new List<string>();
if (inventar == "E" || inventar == "e")
{
    inventory.Add("Uzdravovací lektvar");
    Console.WriteLine("Inventár:");
    foreach (string item in inventory)
    {
        Console.WriteLine("- " + item);
    }
}
Console.WriteLine("Chceš použiť lektvar na uzdravenie? Áno (A) / Nie (N)");
string pouzitLektvar = Console.ReadLine();
if (pouzitLektvar == "A" || pouzitLektvar == "a")
{
    int HpP4 = hpP3 + 25;
    Console.WriteLine($"Použil si lektvar a tvoje Hpčka sú {HpP4}");

}
else if (pouzitLektvar == "N" || pouzitLektvar == "n")
{
    Console.WriteLine("Môžeš pokračovať v boji");
}

    Console.WriteLine("Gratulujeme, úspešne si prešiel prvou arénou!");  //koniec prvej arény




int HpM7 = 60;
int HpM9 = 45;
int HpM11 = 19;
int HpM12 = 20;
int HpM14 = 5;
int HpP5 = 94;
int HpP6 = 69;
int HpP23 = 4;
int HpP19 = 43;
int HpP21 = 19;
int HpP7 = 44;
int hit1naP = 25;
int hit2naP = 26;
int hit3naP = 35;
int hit1nakiklopa = 15;
int hit2nakiklopa = 25;
int hit3nakiklopa = 15;
int hit4nakiklopa = 5;
Console.WriteLine("Pre vstup do druhej arény stlač ENTER...");
Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkYellow;                                                             //nastavenie farby pozadia
Console.Clear();
Console.WriteLine("Vitaj v druhej aréne!");                                                                 //vstup do druhej areny
System.Threading.Thread.Sleep(1500);
Console.WriteLine("Práve sa zobúdza príšera Kiklop");
Console.WriteLine("   <0>   ");
System.Threading.Thread.Sleep(1500);
Console.WriteLine("Kiklop sa zoubudil");

if (pouzitLektvar == "A" || pouzitLektvar == "a")
{
    Console.WriteLine($"Život hráča {playerName}: {HpP5}");
}
else if (pouzitLektvar == "N" || pouzitLektvar == "n")
{
    Console.WriteLine($"Život hráča {playerName}: {HpP6}");
}
int hpM1 =  HpMonster1();
int  HpMonster1()
{
    const int hpMonster = 60;
    Console.WriteLine($"Život Kiklopa: {HpM7}");
    return hpMonster;
}

Console.WriteLine("Stlač ENTER pre začatie boja");
Console.ReadLine();
Console.WriteLine("Boj začína");
System.Threading.Thread.Sleep(500);
Console.BackgroundColor = ConsoleColor.Red;                                               //zmena farby pozadia
Console.Clear();
Console.WriteLine("Pre útok stlač H");
string action4 = Console.ReadLine();                                                     //HIT hraca na Kiklopa


 if (pouzitLektvar == "A" || pouzitLektvar == "a")
{
    int HpM8 = HpM7 - hit1nakiklopa;
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine($"Život Kiklopa: {HpM8}");                                               //odčítanie HP Kiklopa
    Console.WriteLine("Kiklop útočí naspäť!");                                             //útok Kiklopa
    System.Threading.Thread.Sleep(1500);
    int HpP18 = HpP5 - hit1naP;
    Console.WriteLine($"Život hráča {playerName}: {HpP6}");
}
else if (pouzitLektvar == "N" || pouzitLektvar == "n")
{
    int HpM8 = HpM7 - hit1nakiklopa;
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine($"Život Kiklopa: {HpM8}");                                               //odčítanie HP Kiklopa
    Console.WriteLine("Kiklop útočí naspäť!");                                             //útok Kiklopa
    System.Threading.Thread.Sleep(1500);
    int HpP8 = HpP6 - hit1naP;
    Console.WriteLine($"Život hráča {playerName}: {HpP7}");
}
    string action5 = Console.ReadLine();
if (pouzitLektvar == "A" || pouzitLektvar == "a")
{
    int HpM13 = HpM9 - hit2nakiklopa;
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine($"Život Kiklopa: {HpM12}");                                               //odčítanie HP Kiklopa
    Console.WriteLine("Kiklop útočí naspäť!");                                             //útok Kiklopa
    System.Threading.Thread.Sleep(1500);
    int HpP20 = HpP6 - hit2naP;
    Console.WriteLine($"Život hráča {playerName}: {HpP19}");
}
else if (pouzitLektvar == "N" || pouzitLektvar == "n")
{
    int HpM13 = HpM9 - hit2nakiklopa;
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine($"Život Kiklopa: {HpM12}");                                               //odčítanie HP Kiklopa
    Console.WriteLine("Kiklop útočí naspäť!");                                             //útok Kiklopa
    System.Threading.Thread.Sleep(1500);
    int HpP22 = HpP7 - hit2naP;
    Console.WriteLine($"Život hráča {playerName}: {HpP21}");

}
    string action6 = Console.ReadLine();
if (pouzitLektvar == "A" || pouzitLektvar == "a")
{
    int HpM15 = HpM12 - hit3nakiklopa;
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine($"Zivot Kiklopa: {HpM14}");
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine("Kiklop útočí");
    int HpP10 = HpP6 - hit3naP;
    Console.WriteLine($"Život hráča {playerName}: {HpP10}");

}
else if (pouzitLektvar == "N" || pouzitLektvar == "n")
{
    int HpM15 = HpM12 - hit3nakiklopa;
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine($"Zivot Kiklopa: {HpM14}");
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine("Kiklop útočí");
    int HpP24 = HpP21 - hit3naP;
    Console.WriteLine($"Život hráča {playerName}: {HpP23}");
}
 string action7 = Console.ReadLine();
if (pouzitLektvar == "A" || pouzitLektvar == "a")
{
    int HpM16 = HpM14 - hit4nakiklopa;
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine("Zabil si Kiklopa");
}
else if (pouzitLektvar == "N" || pouzitLektvar == "n")
{
    int HpM16 = HpM14 - hit4nakiklopa;
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine("Zabil si Kiklopa");
}
Console.WriteLine("Gratulujeme, úspešne si prešiel druhou arénou!");  //koniec druhej arény
System.Threading.Thread.Sleep(1500);
Console.Clear();
Console.WriteLine("Z Kiklopa vypadol zlatý meč a lektvar ochrany");                             //vypadnutie meča)
Console.WriteLine(@"
              /\
             /  \
            |    |
            |    |
            |    |
            |    |
            |    |
            |    |
            |    |
            |    |
            |    |
            |    |
       _____|    |_____
       \____|    |____/
            |    |
            |    |
            |    |
             \  /
              \/
");
Console.WriteLine("Pre získanie meča stlač M");
string mec = Console.ReadLine();
if (mec == "M" || mec == "m")
{
    Console.WriteLine("Zobral si meč do inventára");
    inventory.Add("Zlatý meč");
}
Console.WriteLine("Pre otvorenie inventára stlač E");
string inventar2 = Console.ReadLine();
if (inventar2 == "E" || inventar2 == "e")
{
    Console.WriteLine("Inventár:");
    foreach (string item in inventory)
    {
        Console.WriteLine("- " + item);
    }
}

    Console.WriteLine("Pre zobratie lektvara stlač L");
string lektvar2 = Console.ReadLine();
if (lektvar2 == "L" || lektvar2 == "l")
{
    inventory.Add("Lektvar ochrany");
    Console.WriteLine("Zobral si lektvar do inventára");
}
Console.WriteLine("Otvor inventár a môžeš aktivovať lektvar");
string inventar3 = Console.ReadLine();
if (inventar3 == "E" || inventar3 == "e")
{
    Console.WriteLine("Inventár:");
    foreach (string item in inventory)
    {
        Console.WriteLine("- " + item);
    }
}
Console.WriteLine("Chceš použiť lektvar ochrany? Áno (A) / Nie (N)");
string pouzitLektvar2 = Console.ReadLine();
if (pouzitLektvar2 == "A" || pouzitLektvar2 == "a")
{
    Console.WriteLine("Pouzil si lektvar ochrany, ochranu maš na 3 útoky");
}
else if (pouzitLektvar2 == "N" || pouzitLektvar2 == "n")
{
    Console.WriteLine("Môžeš pokračovať v boji bez ochrany");
}
Console.BackgroundColor = ConsoleColor.Yellow;
Console.Clear();
Console.WriteLine("Pripravujeme ďalšie arény...");                                       //pripravovanie ďalších arén
System.Threading.Thread.Sleep(2000);


Console.WriteLine("Vitaj v tretej aréne!");                                                                 //vstup do tretej areny
System.Threading.Thread.Sleep(1500);
Console.WriteLine("Práve sa zobúdza príšera Drak");
Console.WriteLine("    / \\  ");
System.Threading.Thread.Sleep(1500);
Console.WriteLine("Drak sa zoubudil");
Console.WriteLine("Stlač ENTER pre začatie boja");
Console.ReadLine();
Console.WriteLine("Boj začína");
System.Threading.Thread.Sleep(500);
Console.Clear();
Console.BackgroundColor = ConsoleColor.Red;                                               //zmena farby pozadia
Console.Clear();

int HpD = 85;
int HpD2 = 40;
int HpD4 = 30;
int HpD6 = 5;
int HitDnaP = 0;
int hitPnadraka = 45;
int hit2Pnadraka = 10;
int hit3Pnadraka = 25;
int hit4Pnadraka = 5;
int hitDnaPbezL = 5;

Console.WriteLine("Pre útok stlač H");
string action8 = Console.ReadLine();

if (pouzitLektvar2 == "A" || pouzitLektvar2 == "a")
{
    int HpD3 = HpD - hitPnadraka;
    Console.WriteLine($"Život Draka: {HpD2}");                                               //odčítanie HP Draka
    Console.WriteLine("Drak útočí naspäť!");                                             //útok Draka
    System.Threading.Thread.Sleep(1500);
    int HpP25 = HpP23 - HitDnaP;
    Console.WriteLine($"Život hráča {playerName}: {HpP25}");
}
else if (pouzitLektvar2 == "N" || pouzitLektvar2 == "n")
{
    int HpD3 = HpD - hitPnadraka;
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine($"Život Draka: {HpD2}");                                     //odčítanie HP Draka
    Console.WriteLine("Drak útočí naspäť!");                                             //útok Draka
    System.Threading.Thread.Sleep(1500);
    int HpP25 = HpP23 - hitDnaPbezL;
    Console.WriteLine($"Život hráča {playerName}: {HpP25}");
    Console.WriteLine("Zomrel si porazil si 2 príšery");
    Console.WriteLine("Ďakujeme za hranie hry");
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine("Načítavam záverečnú obrazovku...");


    System.Threading.Thread.Sleep(2000);
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();
    Console.WriteLine("Ďakujeme že ste si zahrali Witcher Arena PM!");                       //koniec hry
    Console.WriteLine("Vytvoril: Patrik a Michal");
    Console.WriteLine("Verzia: " + version);                                                //verzia
    Console.WriteLine("Dátum vydania: 2025");                                               //dátum vydania
    Console.WriteLine("Stlač ENTER pre ukončenie...");
    Console.ReadLine();
    Console.Clear();
    Environment.ExitCode = 0;                                                                  //ukončenie programu
    Environment.Exit(Environment.ExitCode);
}

string action9 = Console.ReadLine();
if (pouzitLektvar2 == "A" || pouzitLektvar2 == "a")
{
    int HpD5 = HpD2 - hit2Pnadraka;
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine($"Život Draka: {HpD4}");
    Console.WriteLine("Drak útočí naspäť");
    System.Threading.Thread.Sleep(1500);
    int HpP25 = HpP23 - HitDnaP;
    Console.WriteLine($"Život hráča {playerName}: {HpP25}");
}
string action10 = Console.ReadLine();
if (pouzitLektvar2 == "A" || pouzitLektvar2 == "a")
{
    int HpD7 = HpD4 - hit3Pnadraka;
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine($"Život Draka: {HpD6}");
    Console.WriteLine("Drak útočí naspäť");
    System.Threading.Thread.Sleep(1500);
    int HpP25 = HpP23 - HitDnaP;
    Console.WriteLine($"Život hráča {playerName}: {HpP25}");
}
string action11 = Console.ReadLine();
if (pouzitLektvar2 == "A" || pouzitLektvar2 == "a")
{
    int HpD9 = HpD6 - hit4Pnadraka;
    System.Threading.Thread.Sleep(1500);
    Console.WriteLine($"Život Draka: {HpD9}");
   
}
Console.WriteLine("Drak porazený!");
System.Threading.Thread.Sleep(1500);
Console.Clear();
Console.BackgroundColor = ConsoleColor.Magenta;
Console.Clear();
Console.WriteLine("Gratulujeme, úspešne si prešiel treťou arénou a uspesne si dokoncil hru!");    //koniec tretej arény a hry
Console.WriteLine("Porazil si 3 príšery");
System.Threading.Thread.Sleep(1500);
Console.WriteLine("Načítavam záverečnú obrazovku...");


System.Threading.Thread.Sleep(2000);
Console.BackgroundColor = ConsoleColor.Black;
Console.Clear();
Console.WriteLine("Ďakujeme že ste si zahrali Witcher Arena PM!");                       //koniec hry
Console.WriteLine("Vytvoril: Patrik a Michal");
Console.WriteLine("Verzia: " + version);                                                //verzia
Console.WriteLine("Dátum vydania: 2025");                                               //dátum vydania
Console.WriteLine("Stlač ENTER pre ukončenie...");
Console.ReadLine();
Console.Clear();
Environment.ExitCode = 0;                                                                  //ukončenie programu
Environment.Exit(Environment.ExitCode);













