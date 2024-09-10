/*# Exercice Formatif
Consommation électrique d'un ordinateur

## Instruction du programme
- Un ordinateur consomme 150 watts par heure.
- Chaque 100 watts d’utilisation coûte 0,15$.
- Écrivez un programme qui prend en entrée un nombre d'heure d'utilisation d'un ordinateur et retourne le coût d'utilisation de celui-ci.
*/

const int WATTS_PAR_HEURE = 150;
const double COUT_PAR_WATTS = 0.15 / 100;

Console.WriteLine("====== Consommation éléctrique d'un ordinateur ======");
Console.WriteLine("Inscrivez le nombre d'heure d'utilisation de votre ordinateur");
int nbHeure = Convert.ToInt32(Console.ReadLine());

int nbWatt = nbHeure * WATTS_PAR_HEURE;
double coutUtilisation = nbWatt * COUT_PAR_WATTS;

Console.Write($"Le coût d'utilisation de {nbHeure} heures d'ordinateur vous coûte {coutUtilisation}$");