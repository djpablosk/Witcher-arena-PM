using System.Diagnostics.CodeAnalysis;

System.Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();
Console.WriteLine($"Witcher Arena PM - Version {version}"); //zakladne veci (nemenit)
   
Console.WriteLine("Vitaj v Witcher Arena "); //welcome veta

Console.WriteLine("Zadaj svoje meno: ");
string playerName = Console.ReadLine();
Console.WriteLine("Ahoj " + playerName + ", prave si vstupil do arény plnej príšer!");  //meno

int hpP = HpPlayer();  // načita život hráča
int HpPlayer()
{
    const int hpPlayer = 100;       
    Console.WriteLine($"Život hráča {playerName}: {hpPlayer}");
    return hpPlayer;
}

int HpM = HpMonster(); // načita život príšery
int HpMonster()
{
    const int hpMonster = 20;     
    Console.WriteLine($"Život príšery: {hpMonster}");
    return hpMonster;
}


Console.WriteLine("Vyber si svoju postavu: ");                                              // výber postavy
Console.WriteLine("1. Alex:");
Console.WriteLine("2. Chomik:");
string character = Console.ReadLine();
switch (character)
{
    case "1":
        Console.WriteLine("Vybral si si Alex.");
        break;
    case "2":
        Console.WriteLine("Vybral si si Chomik.");
        break;
    default:
        Console.WriteLine("Neplatná voľba, vyber si Alex alebo Chomik.");
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
else if (character == "2")                                                                      //Postava 2 (Chomik)
{
    Console.WriteLine("  0   ");
    Console.WriteLine("  | ");
    Console.WriteLine(" / / ");
}

Console.WriteLine("Pre nacitanie areny stlac ENTER...");                                            //nacitanie areny
Console.ReadLine();
Console.Clear();

Console.WriteLine("Vitaj v arene!");                                           //vstup do areny





