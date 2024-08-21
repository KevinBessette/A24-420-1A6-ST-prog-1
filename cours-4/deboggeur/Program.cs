/*
Dans une famille, le père a 32 ans, la mère 30 ans, son fils a 5 ans, mais on ne connaît pas l’âge de sa fille. 
Par contre, on sait que la somme de l’âge des parents est égale à 5 fois la somme de l’âge des enfants. Quel est l’âge de la fille?
*/
int agePere = 32;
int ageMere = 30;
int ageFils = 5;
int ageFille; // inconnue

Console.WriteLine("agePere + ageMere = 5 * (ageFils + ageFille)");

Console.WriteLine($"Âge père : {agePere} ans");
Console.WriteLine($"Âge mère : {ageMere} ans");
Console.WriteLine($"Âge fils : {ageFils} ans");

int sommeAgeParent = agePere + ageMere;
ageFille = sommeAgeParent / 5;
ageFille -= ageFils;

Console.WriteLine($"Âge fille : {ageFille} ans");

// Pourquoi ça ne marche pas. Parcequ'on travail avec des entiers, si ageFille et sommeAgeParent était des doubles, nous verrions qu'elle a 7,4 ans
