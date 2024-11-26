using System.Text.Json;
// Fonction pour ajouter une ligne à un fichier
void AppendToFile(string filename, string content){
    if (File.Exists(filename)){
        File.AppendAllText(filename, "\n");
    }
    File.AppendAllText(filename, content);
}
// Nom du fichier
const string FILENAME = "data.txt";
// Données
string nom = "Alice";
int age = 30;
char initiale = 'A';
double solde = 2567.89;
bool estMembre = true;
int[] scores = [85, 90, 78];
List<string> amis = ["Bob", "Charlie"];
// Repartie à zéro
File.Delete(FILENAME);
// Écriture
AppendToFile(FILENAME, JsonSerializer.Serialize(nom));
AppendToFile(FILENAME, JsonSerializer.Serialize(age));
AppendToFile(FILENAME, JsonSerializer.Serialize(initiale));
AppendToFile(FILENAME, JsonSerializer.Serialize(solde));
AppendToFile(FILENAME, JsonSerializer.Serialize(estMembre));
AppendToFile(FILENAME, JsonSerializer.Serialize(scores));
AppendToFile(FILENAME, JsonSerializer.Serialize(amis));
// Lecture
string[] loadedData = File.ReadAllLines(FILENAME);
// Desérialisation
string nomChargé = JsonSerializer.Deserialize<string>(loadedData[0]);
int ageChargé = JsonSerializer.Deserialize<int>(loadedData[1]);
char initialeChargé = JsonSerializer.Deserialize<char>(loadedData[2]);
double soldeChargé = JsonSerializer.Deserialize<double>(loadedData[3]);
bool estMembreChargé = JsonSerializer.Deserialize<bool>(loadedData[4]);
int[] scoresChargé = JsonSerializer.Deserialize<int[]>(loadedData[5]);
List<string> amisChargé = JsonSerializer.Deserialize<List<string>>(loadedData[6]);
// Affichage
Console.WriteLine($"Nom chargé : {nomChargé}");
Console.WriteLine($"age chargé : {ageChargé}");
Console.WriteLine($"initiale chargé : {initialeChargé}");
Console.WriteLine($"solde chargé : {soldeChargé}");
Console.WriteLine($"estMembre chargé : {estMembreChargé}");
Console.WriteLine($"scores chargé : {string.Join(", ",scoresChargé)}");
Console.WriteLine($"amis chargé : {string.Join(", ",amisChargé)}");

