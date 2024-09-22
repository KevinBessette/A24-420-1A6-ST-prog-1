int posX = 5;
int posY = 5;
bool continuer = true;

while (continuer)
{
    Console.Clear();
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            if (i == posY && j == posX)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();  
    }
    Console.WriteLine("Instructions: g (gauche), d (droite), h (haut), b (bas), exit (quitter)");
    Console.Write("Entrez une commande : ");
    string commande = Console.ReadLine();
    switch (commande)
    {
        case "g":
            if (posX > 0)
            {
                posX--;
            }
            break;
        case "d":
            if (posX < 9)
            {
                posX++;
            }
            break;
        case "h": 
            if (posY > 0)
            {
                posY--;
            }
            break;
        case "b":
            if (posY < 9)
            {
                posY++;
            }
            break;
        case "exit": 
            continuer = false;
            break;
        default:
            Console.WriteLine("Erreur");
            break;
    }
}

Console.WriteLine("Programme terminé.");
