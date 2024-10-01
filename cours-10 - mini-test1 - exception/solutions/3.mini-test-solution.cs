Console.WriteLine("Combien de dépenses voulez-vous entrer (1-20) : ");
int nombreDepenses = Convert.ToInt32(Console.ReadLine());

while (nombreDepenses < 1 || nombreDepenses > 20) {
    Console.WriteLine("Le nombre doit être entre 1 et 20. Réessayez : ");
    nombreDepenses = Convert.ToInt32(Console.ReadLine());
}

// Initialiser un tableau pour stocker les dépenses
double[] depenses = new double[nombreDepenses];

// Entrer les montants des dépenses
for (int i = 0; i < nombreDepenses; i++) {
    Console.WriteLine("Entrez la dépense " + (i + 1) + " : ");
    depenses[i] = Convert.ToDouble(Console.ReadLine());
}

// Calculer la somme, la dépense la plus élevée et la plus basse
double sommeTotale = 0;
double depenseMax = depenses[0];
double depenseMin = depenses[0];

for (int i = 0; i < nombreDepenses; i++) {
    sommeTotale += depenses[i];
    if (depenses[i] > depenseMax) {
        depenseMax = depenses[i];
    }
    if (depenses[i] < depenseMin) {
        depenseMin = depenses[i];
    }
}

// Afficher les résultats
Console.WriteLine("Somme totale des dépenses : " + sommeTotale);
Console.WriteLine("Dépense la plus élevée : " + depenseMax);
Console.WriteLine("Dépense la plus basse : " + depenseMin);

// Vérifier si le budget est dépassé
if (sommeTotale > 1000) {
    Console.WriteLine("Attention, vous avez dépassé votre budget mensuelle de 1000$!");
}