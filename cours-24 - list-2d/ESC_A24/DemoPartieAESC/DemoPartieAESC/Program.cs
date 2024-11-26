namespace DemoPartieAESC
{
    internal class Program
    {

        public static bool Valider(double valeur, double borneMin, double borneMax, int seuil)
        {
            return ((valeur >= borneMin && valeur < borneMax) && seuil >= 60);
        }


        static void Main(string[] args)
        {

            Console.WriteLine("***************************************");
            Console.WriteLine("*** Système de location de marteaux ***");
            Console.WriteLine("***************************************");
            Console.WriteLine("");

            const int NbMarteaux = 3;

            int compteurMarteaux = NbMarteaux;
            int compteurLocation = 0;

            while (true)
            {
                Console.WriteLine("Menu:\n 1. Louer un marteau.\n 2. Retourner un marteau.\n 3. Quitter.\n");
                Console.Write("Choix : ");
                int choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1)
                {
                    if (compteurMarteaux > 0)
                    {
                        Console.WriteLine("Location d'un marteau.");
                        compteurLocation++;
                        compteurMarteaux--;
                    }
                    else
                    {
                        Console.WriteLine("Impossible de louer un marteau, l'inventaire est vide.");
                    }

                }
                else if (choix == 2)
                {
                    if (compteurMarteaux == NbMarteaux)
                    {
                        Console.WriteLine("Le retour est impossible, car l'inventaire est plein.");
                    }
                    else
                    {
                        Console.WriteLine("Retour d'un marteau.");
                        compteurMarteaux++;
                    }
                }
                else if (choix == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Choix invalide");
                }


            }

            if (compteurLocation == 0)
            {
                Console.WriteLine("Il n'y a eu aucune location.");

            }
            else
            {
                Console.WriteLine("Nombre de locations  : " + compteurLocation);

            }

            /*
            double valeur = 0;

            for (int i = 2; i <= 6; ++i)
            {
                valeur += i;
            }
            */
            /*`
double valeur = 0;

for (int i = 2; i <= 6; ++i)
{
    valeur += i;
}

Console.WriteLine("Donnée : {1}", (valeur % 9) );




            int nbCadeaux = 2;
Console.WriteLine($"Nombre de cadeaux : {nbCadeaux}");


int compteur = 0;
while (true)
{
    if (compteur > 21)
    {
        break;
    }

    compteur = compteur + 3;
}

Console.WriteLine("Veuillez saisir votre âge ?");
int âge = Console.ReadLine();
            */

        }
    }
}
