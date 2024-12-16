Random random = new Random();
int mysterNumber = random.Next(1, 10);

Console.WriteLine("--- Trouver le nombre mystére ---\n");



int compteur = 0;
int numberCoups = 0;
while (compteur != mysterNumber)
{
    
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"\t Veuillez saisir un nombre : ");
   int number = int.Parse(Console.ReadLine());
    compteur++;
    numberCoups++;

    if (number > mysterNumber)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\t \t Le nombre mystère est plus petit.");
    }
    else if (number < mysterNumber)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\t \t Le nombre mystère est plus grand");
    }
    else if (number == mysterNumber)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bravo !! vous avez trouvé le nombre mystère !");
        Console.WriteLine($"Vous avez trouvé en {numberCoups} coups !");
        Console.ResetColor();
        break;

    }

}

