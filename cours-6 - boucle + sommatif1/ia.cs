const int gridSize = 10;
int x = 5, y = 5; // Position initiale du X
bool running = true;

while (running)
{
	Console.Clear();
	// Dessiner la grille
	for (int i = 0; i < gridSize; i++)
	{
		for (int j = 0; j < gridSize; j++)
		{
			if (i == y && j == x)
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

	// Demander l'instruction à l'utilisateur
	Console.WriteLine("Instructions: g (gauche), d (droite), h (haut), b (bas), exit (quitter)");
	string instruction = Console.ReadLine();

	switch (instruction)
	{
		case "g": // Gauche
			if (x > 0) x--;
			break;
		case "d": // Droite
			if (x < gridSize - 1) x++;
			break;
		case "h": // Haut
			if (y > 0) y--;
			break;
		case "b": // Bas
			if (y < gridSize - 1) y++;
			break;
		case "exit":
			running = false;
			break;
		default:
			Console.WriteLine("Instruction non reconnue, veuillez réessayer.");
			break;
	}
}

Console.WriteLine("Programme terminé.");