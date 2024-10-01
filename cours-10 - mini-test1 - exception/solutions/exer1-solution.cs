/*
Le programme suivant est fonctionnelle.  Il demande à l'utilisateur d'inscrire deux nombres et retourne le quotient de ceux-ci.
Utiliser les try/catch pour améliorer la fonction DisplayQuotient afin de gérer le cas d'exception de la division par zéro.
*/
void DisplayQuotient(double number1, double number2){
    try {
        double quotient = number1 / number2;
        Console.WriteLine($"{number1} / {number2} = {quotient}");
    }
    catch (DivideByZeroException) {
        Console.WriteLine("Erreur : Le 2e nombres ne doit pas être un zéro.");
    }
}
Console.WriteLine("Écrivez 2 nombres, nous vous retournerons le quotient de ceux-ci.");
double number1 = Convert.ToDouble(Console.ReadLine());
double number2 = Convert.ToDouble(Console.ReadLine());
DisplayQuotient(number1, number2);