/*
Le programme suivant est fonctionnelle.  Il demande à l'utilisateur un index et affiche le mot à l'index choisi.
Utiliser les try/catch pour améliorer la fonction DisplayWordByIndex afin de gérer les cas d'exceptions.  Il y a deux cas à gérer:
    L'utilisateur n'a pas saisie un entier valide
    L'utilisateur a fourni un indice hors des limites du tableau.
*/

void DisplayWordByIndex(string[] words, int index){
    try {
        Console.WriteLine($"Le mot à l'indice {index} est : {words[index]}");
    }
    catch (IndexOutOfRangeException) {
        Console.WriteLine("Erreur : L'indice fourni est hors des limites du tableau.");
    }
    catch (FormatException) {
        Console.WriteLine("Erreur : Vous n'avez pas entré un nombre entier valide.");
    }
}
string[] words = ["pomme", "banane", "cerise", "date", "figue", "raisins", "kiwi", "orange", "mangue", "poire"];
int index = Convert.ToInt32(Console.ReadLine());

DisplayWordByIndex(words,index);