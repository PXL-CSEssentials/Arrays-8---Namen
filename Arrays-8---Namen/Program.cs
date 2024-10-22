Console.Write("Hoeveel namen wens je te beheren? ");
int numberOfNames = int.Parse(Console.ReadLine());
string[] names = new string[numberOfNames];

Console.WriteLine("==== Namen in array stockeren en afdrukken. ====\r\n");
for (int i = 0; i < names.Length; i++)
{
    Console.Write($"Geef naam {i + 1}/{names.Length} : ");
    names[i] = Console.ReadLine();
}

Console.WriteLine("\r\n\r\n==== Namen afdrukken. ====\r\n");
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Naam {i + 1} is  {names[i].ToUpper()}");
}

// Of via foreach
/*
int index = 1; 
foreach (string name in names) 
{ 
    Console.WriteLine($"Naam {index} is  {name.ToUpper()}"); 
    index++; 
}
*/
Console.ReadLine();