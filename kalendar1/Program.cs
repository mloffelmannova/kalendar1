

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Čaukooo ☺ ☻");

Console.ForegroundColor = ConsoleColor.DarkCyan;
DateTime cas = DateTime.Now;
int cisloMesice = cas.Month;

string[] poleMesicu = { "leden", "únor", "březen", "duben", "květen", "červen", "červenec", "srpen", "září", "říjen", "listopad", "prosinec" };

Console.WriteLine("Akt. měsíc je: " + poleMesicu[cisloMesice-1] +" další měsíc je: " + poleMesicu[cisloMesice] + " předchozí: " + poleMesicu[cisloMesice - 2]);
int vstup = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("zadej cislo mesice");
Console.WriteLine("- - - - - - - ");

if (vstup == 1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Akt. měsíc je: " + poleMesicu[vstup - 1] + " další měsíc je: " + poleMesicu[vstup] + " předchozí: " + poleMesicu[11]);
}
else if (vstup >= 2 && vstup <= 11)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Akt. měsíc je: " + poleMesicu[vstup - 1] + " další měsíc je: " + poleMesicu[vstup] + " předchozí: " + poleMesicu[vstup - 2]);
}

else if (cisloMesice == 12)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("je prosinec , byl listopad, bude leden");
}

else
{
    Console.WriteLine("špatně :(");
}

