/*
Le programme suivant est fonctionnelle.  Il demande à l'utilisateur d'inscrire un entier afin de le stocker dans une variable.
    1. Utiliser les try/catch pour améliorer la fonction ReadInteger afin de gérer le cas d'exception où l'utilisateur n'a pas saisie un entier.
    2. Ajouter une boucle dans la fonction ReadInteger pour demander à nouveau à l'utilisateur d'inscrire un entier, si l'exception a été déclenché.
*/
int ReadInteger(string message) {
    while (true) {
        try {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException) {
            Console.WriteLine("Erreur : Ce n'est pas un nombre valide. Veuillez réessayer.");
        }
    }
}

int number1 = ReadInteger("Entrez le premier nombre : ");
int number2 = ReadInteger("Entrez le deuxième nombre : ");

Console.WriteLine(number1);
Console.WriteLine(number2);