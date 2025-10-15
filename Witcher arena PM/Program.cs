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





