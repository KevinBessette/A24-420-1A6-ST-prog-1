namespace DemoPartieB
{
    internal class Program
    {

        public static void Main()
        {
            const string nomFichier = "data.txt";

            // Initialisation des liste
            List<string> titres = new List<string>() { "HMM 3", "Alerte rouge 2", "Chrono trigger" };
            List<int> limitesMinute = new List<int>() { 10, 15, 25 };
            List<int> minutesJeu = new List<int>() { 0, 0, 0 };

            Recuperer(nomFichier, ref titres, ref limitesMinute, ref minutesJeu);

            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("=== Gestionnaire de jeux vidéos ===");
                Console.WriteLine("===================================");

                Console.WriteLine(
                    "\nOpérations possibles :\n\n" +
                    "1 - Ajout un nouveau jeu\n" +
                    "2 - Démarrer une séance de jeu\n" +
                    "3 - Statistiques\n" +
                    "0 - Quitter\n");
                Console.Write("Choix : ");

                int action = Convert.ToInt32(Console.ReadLine());

                /***/
                if (action == 0) break;
                /***/

                switch (action)
                {
                    case 1:
                        AjouterJeu(ref titres, ref limitesMinute, ref minutesJeu);
                        break;
                    case 2:
                        DémarrerSéanceJeu(titres, limitesMinute, ref minutesJeu);
                        break;
                    case 3:
                        Statistiques(titres, limitesMinute, minutesJeu);
                        break;
                    default: break;
                }
            }

            Enregistrer(nomFichier, titres, limitesMinute, minutesJeu);

        }

        public static void AjouterJeu(ref List<string> titres, ref List<int> limitesMinute, ref List<int> minutesJeu)
        {
            //Entête.
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("===   Saisir un nouveau jeu   ===");
            Console.WriteLine("=================================");

            Console.Write("Veuillez saisir le titre du nouveau jeu : ");
            string titre = Console.ReadLine();

            //Vérification si le titre est présent
            if (!titres.Contains(titre))
            {
                //Ajout du titre
                titres.Add(titre);

                //Ajout de la limite en minute
                Console.Write("Veuillez saisir la limite de temps de jeu en minutes : ");
                int limiteTemps = Convert.ToInt32(Console.ReadLine());
                limitesMinute.Add(limiteTemps);

                //Aucune minute n'est encore jouée
                minutesJeu.Add(0);

                Console.WriteLine("Appuyer sur une touche pour continuer");
                _ = Console.ReadKey();
            }
            else
            {
                //Message pour ne pas avoir le même jeu en double.
                Console.WriteLine("Ce jeu existe déjà dans la liste.");
                Console.WriteLine("Appuyer sur une touche pour continuer");
                _ = Console.ReadKey();
            }
        }

        public static void DémarrerSéanceJeu(List<string> titres, List<int> limitesMinute, ref List<int> minutesJeu)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Liste des jeux : ");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"{"No",-3} {"Titre",-20}{"Minutes restantes",-20}");
                Console.WriteLine("-----------------------------------------");
                for (int i = 0; i < titres.Count; ++i)
                {
                    Console.WriteLine($"{i + 1,-3} {titres[i],-20} {limitesMinute[i] - minutesJeu[i],20}");
                }

                Console.WriteLine("0   Quitter\n");

                Console.Write("Saisir votre choix : ");
                int choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 0)
                {
                    break;
                }
                else
                {

                    Console.Write("Temps de la séance de jeu en minutes : ");
                    int minutes = Convert.ToInt32(Console.ReadLine());

                    if (minutes <= limitesMinute[choix - 1] - minutesJeu[choix - 1])
                    {
                        minutesJeu[choix - 1] += minutes;
                        Console.WriteLine("Bonne séance de jeu...");
                        Chronomètre(minutes);
                    }
                    else
                    {
                        Console.WriteLine("Impossible de jouer à ce jeu, vous dépassez votre limite autorisée.");
                        Console.WriteLine("Appuyer sur une touche pour continuer");
                        _ = Console.ReadKey();
                    }

                }
            }

        }

        public static void Chronomètre(int minutes)
        {
            while (true)
            {
                Console.WriteLine("Minute restantes : " + minutes);

                Thread.Sleep(1000);

                minutes--;

                if (minutes == 0)
                {
                    break;
                }
            }
        }

        public static void Statistiques(List<string> titres, List<int> limitesMinute, List<int> minutesJeu)
        {

            Console.Clear();
            Console.WriteLine("    1         2         3         4         5         6");
            Console.WriteLine("12345678901234567890123456789012345678901234567890101234567890");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"{"Titre",-20} {"Limite",10} {"Minutes",10} {"Pourcentage",15}");
            Console.WriteLine("----------------------------------------------------------");

            int minuteTotalesJeu = 0;
            for (int i = 0; i < titres.Count; ++i)
            {
            double pourcentageJeu = Math.Round(1.0 * minutesJeu[i] / limitesMinute[i],2);
            Console.WriteLine($"{titres[i],-20} {limitesMinute[i],10} {minutesJeu[i],10} {pourcentageJeu,15:P2}");
                minuteTotalesJeu += minutesJeu[i];
            }

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"{"Vous avez joué : " + minuteTotalesJeu,50} minutes");

            Console.WriteLine("\nAppuyer sur une touche pour continuer");
            _ = Console.ReadKey();

        }
   

        public static void Enregistrer(string nomFichier, List<string> titres, List<int> limitesMinute, List<int> minutesJeu)
        {
            StreamWriter sw = new StreamWriter(nomFichier);
            string nomsJSON = System.Text.Json.JsonSerializer.Serialize(titres);
            sw.WriteLine(nomsJSON);
            string notesJSON = System.Text.Json.JsonSerializer.Serialize(limitesMinute);
            sw.WriteLine(notesJSON);
            string moyenneJSON = System.Text.Json.JsonSerializer.Serialize(minutesJeu);
            sw.WriteLine(moyenneJSON);
            sw.Close();
        }

        public static bool Recuperer(string nomFichier, ref List<string> titres, ref List<int> limitesMinute, ref List<int> minutesJeu)
        {
            if (File.Exists(nomFichier))
            {
                StreamReader sr = new StreamReader(nomFichier);
                titres = System.Text.Json.JsonSerializer.Deserialize<List<string>>(sr.ReadLine());
                limitesMinute = System.Text.Json.JsonSerializer.Deserialize<List<int>>(sr.ReadLine());
                minutesJeu = System.Text.Json.JsonSerializer.Deserialize<List<int>>(sr.ReadLine());
                sr.Close();
                return true;
            }
            else
            {
                titres = new List<string>() { "HMM 3", "Alerte rouge 2", "Chrono trigger" };
                limitesMinute = new List<int>() { 10, 15, 25 };
                minutesJeu = new List<int>() { 0, 0, 0 };

                return false;
            }
        }
    }

}

