using System.Diagnostics.CodeAnalysis;

System.Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();
Console.WriteLine($"Witcher Arena PM - Version {version}"); //zakladne veci nemenit
   
Console.WriteLine("Vitaj v Witcher Arena ");

Console.WriteLine("Zadaj svoje meno: ");
string playerName = Console.ReadLine();
Console.WriteLine("Ahoj " + playerName + ", prave si vstupil do arény plnej príšer!");  //meno














































const int hpPlayer = 100;       // zivoty hraca
const int hpMonster = 20;      // zivoty prisery

