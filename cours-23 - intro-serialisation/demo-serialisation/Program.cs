using System.Text.Json;

const string FILENAME = "data.txt";

// Sérialisation
string nom = "Alice";
int age = 30;
char initiale = 'A';
double solde = 2567.89;
bool estMembre = true;
int[] scores = [85, 90, 78];
List<string> amis = ["Bob", "Charlie"];

File.Delete(FILENAME);
File.AppendAllText(FILENAME, JsonSerializer.Serialize(nom) + "\n");
File.AppendAllText(FILENAME, JsonSerializer.Serialize(age) + "\n");
File.AppendAllText(FILENAME, JsonSerializer.Serialize(initiale) + "\n");
File.AppendAllText(FILENAME, JsonSerializer.Serialize(solde) + "\n");
File.AppendAllText(FILENAME, JsonSerializer.Serialize(estMembre) + "\n");
File.AppendAllText(FILENAME, JsonSerializer.Serialize(scores) + "\n");
File.AppendAllText(FILENAME, JsonSerializer.Serialize(amis) + "\n");

// Desérialisation
string[] loadedData = File.ReadAllLines(FILENAME);

string nomChargé = JsonSerializer.Deserialize<string>(loadedData[0]);
int ageChargé = JsonSerializer.Deserialize<int>(loadedData[1]);
char initialeChargé = JsonSerializer.Deserialize<char>(loadedData[2]);
double soldeChargé = JsonSerializer.Deserialize<double>(loadedData[3]);
bool estMembreChargé = JsonSerializer.Deserialize<bool>(loadedData[4]);
int[] scoresChargé = JsonSerializer.Deserialize<int[]>(loadedData[5]);
List<string> amisChargé = JsonSerializer.Deserialize<List<string>>(loadedData[6]);

Console.WriteLine($"Nom chargé : {nomChargé}");
Console.WriteLine($"age chargé : {ageChargé}");
Console.WriteLine($"initiale chargé : {initialeChargé}");
Console.WriteLine($"solde chargé : {soldeChargé}");
Console.WriteLine($"estMembre chargé : {estMembreChargé}");
Console.WriteLine($"scores chargé : {string.Join(" ",scoresChargé)}");
Console.WriteLine($"amis chargé : {string.Join(" ",amisChargé)}");

