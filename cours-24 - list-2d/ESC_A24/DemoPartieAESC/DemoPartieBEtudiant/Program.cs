namespace DemoPartieBEtudiant
{
    internal class Program
    {

        public static void Main()
        {
            //a) Complétez le code

            //f) Complétez le code

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
                        //c) Complétez le code

                        break;
                    case 2:
                        DémarrerSéanceJeu(titres, limitesMinute, ref minutesJeu);
                        break;
                    case 3:
                        //b) Complétez le code

                    default: break;
                }
            }

            //f) Complétez le code

        }

        //c) Complétez le code

        public static void DémarrerSéanceJeu(List<string> titres, List<int> limitesMinute, ref List<int> minutesJeu)
        {

            //Complétez le code

            Console.Clear();
            Console.WriteLine("Liste des jeux : ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"{"No",-3} {"Titre",-20}{"Minutes restantes",-20}");
            Console.WriteLine("-----------------------------------------");
          
            //Complétez le code

            Console.Write("Saisir votre choix : ");

            //Complétez le code
           
        }

        //e) Complétez le code

        public static void Statistiques()
        {

            Console.Clear();
            Console.WriteLine("    1         2         3         4         5         6");
            Console.WriteLine("12345678901234567890123456789012345678901234567890101234567890");
            Console.WriteLine("----------------------------------------------------------");

            //f) Complétez le code

            Console.WriteLine("\nAppuyer sur une touche pour continuer");
            _ = Console.ReadKey();

        }
    }
}
