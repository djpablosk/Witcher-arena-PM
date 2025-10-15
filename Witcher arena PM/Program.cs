System.Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();
Console.WriteLine($"Witcher Arena PM - Version {version}"); //zakladne veci nemenit
   
Console.WriteLine("Vitaj v Witcher Arena ");









































int hpP = HpPlayer();  // načita život hráča
int HpPlayer()
{
    const int hpPlayer = 100;       
    Console.WriteLine($"Život hráča: {hpPlayer}");
    return hpPlayer;
}

int HpM = HpMonster(); // načita život príšery
int HpMonster()
{
    const int hpMonster = 20;     
    Console.WriteLine($"Život príšery: {hpMonster}");
    return hpMonster;
}





