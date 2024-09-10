

# Commentaires (1/2)

- Il est possible de documenter les méthodes.

```c#
///<summary>Méthode pour faire la somme de deux nombres entiers</summary>
///<param name="nb1">Premier nombre</param>
///<param name="nb2">Deuxième nombre</param>
///<returns>Somme</returns>
int Somme(int nb1, int nb2)
{
    return nb1 + nb2;
}
```

<div class="center-content">

![alt text](images/image-98.png)

</div>



---

# Commentaires (2/2)

- Dans visual studio, il est possible de générer l'en-tête des commentaires automatiquement.
- Il suffit de faire 4 barres obliques en haut de la méthode "////"
- Cette mécanique fonctionne si le projet n'utilise pas les instructions de niveau supérieur.

<div class="center-content">

![alt text](images/image-97.png)

</div>


---

# Méthodes 

- Il existe déjà des méthodes faites pour nous aider pour le développement de nos algorithmes

- Ces méthodes seront disponibles en pseudo-code ou en c#.

---

# Méthodes (pseudo-code) 

<div class="center-content">

| Méthode  | Description                     | Exemple                                          |
| -------- | ------------------------------- | ------------------------------------------------ |
| Maximum  | Obtenir le maximum de 2 nombres | Maximum(5,10) = 10<br>Maximum(1.23, 1.11) = 1.23 |
| Minimum  | Obtenir le minimum de 2 nombres | Minimum(5,10) = 5<br> Minimum(1.23, 1.11) = 1.11 |
| Plancher | Obtenir l'entier précédent      | Plancher(1.13) = 1<br>Plancher(321.123) = 321    |
| Plafond  | Obtenir le prochain entier      | Plafond(1.13) = 2<br>Plafond(321.123) = 322      |
| Arrondir | Arrondir un nombre              | Arrondir(1.5) = 2<br>Arrondir(1.49) = 1          |

</div>

---

# Méthodes - Exemple (pseudo-code)

```
//Trouvez le plus jeune client
VARIABLE entier âgeClient1
LIRE âgeClient1
VARIABLE entier âgeClient2
LIRE âgeClient2
VARIABLE entier jeuneClient
jeuneClient = Minimum(âgeClient1, âgeClient2)
```

```
//Combien de pizzas entières devont nous commander
VARIABLE entier nbInvités
LIRE nbInvités
VARIABLE réel consommationPizzaParPersonne
LIRE consommationPizzaParPersonne
VARIABLE entier quantitéPizzas
quantitéPizzas = Plafond(nbInvités * consommationPizzaParPersonne)
```

---

# Bibliothèque .NET

- Il existe beaucoup de méthodes disponibles dans .NET
- Nous allons faciliter nos développements en utilisant les classes déjà présentes dans la bibliothèque .NET.

---

# System.Math

- La classe "System.Math" permet d'avoir accès à des méthodes et à des constantes universelles en mathématique.
- Constantes    :
  - PI = 3.1415926535897931
  - E = 2.7182818284590451
  - Tau = 6.2831853071795862 (RAD)

---

# System.Math - Minimum et Maximum
    
- Minimum : Trouve le minimum entre deux nombres

```c#
System.Math.Min(2,12); // Résultat 2
System.Math.Min(3,9); // Résultat 3
System.Math.Min(5,-5); // Résultat -5
```

- Maximum : Trouve le maximum entre deux nombres 

```c#
System.Math.Max(2,12); // Résultat 12
System.Math.Max(3,9); // Résultat 9
System.Math.Max(5,-5); // Résultat 5
```

---


# System.Math - Plafond et Plancher
    

- Plafond – Trouve le nombre entier suivant en utilisant un nombre réel

```c#
System.Math.Ceiling(4.4); // Résultat 5
System.Math.Ceiling(9.9); // Résultat 10
System.Math.Ceiling(12.1); // Résultat 13
```

- Plancher – Trouve le nombre entier précédent en utilisant un nombre réel 

```c#
System.Math.Floor(4.5); // Résultat 4
System.Math.Floor(9.9); // Résultat 9
System.Math.Floor(12.1); // Résultat 12
```

---

# System.Math - Racine carré et Arrondir 
    

- Racine carré (SquareRoot) – Calcul la racine carrée d'un nombre.
```c#
System.Math.Sqrt(4); // Résultat 2
System.Math.Sqrt(16); // Résultat 4
System.Math.Sqrt(81); // Résultat 9
```

- Arrondir – Arrondi un nombre réel. 
    - Le 2e paramètre représente le nombre de décimales

```c#
System.Math.Round(1.126); // Résultat 1
System.Math.Round(1.126,2); // Résultat 1.13
System.Math.Round(1.126,1); // Résultat 1.1
```

- Logarithme : Trouve l'exposant. (100 = 10^x => x = 2)
```c#
System.Math.Log(100,10); // Résultat 2
```

---

# System.Convert

- La classe « Convert » permet de convertir une donnée d'un type X vers un type Y. 

```c#
char caractere = Convert.ToChar(67);
Console.WriteLine(caractere); // 'C'

int valeur = Convert.ToInt32(Math.PI);
Console.WriteLine(valeur);  //3 

int prixEntier = 10;
double prixReel = Convert.ToDouble(prixEntier);
Console.WriteLine(prixReel); //10.00
```

<div class="columns">
<div class="center-content">

![height:175px](images/image-65.png)

</div>
<div class="center-content">

![height:175px](images/image-66.png)

</div>
</div>

---

# Système.Console

```c#
//ReadLine : Lire l'entrée par l'utilisateur
string texte = Console.ReadLine();

//WriteLine : Écrire dans la console
Console.WriteLine("Bonjour Monde!");

//Beep : À vous de découvrir !
Console.Beep();

//Clear : Efface la console
Console.Clear();

//Color : Modifier couleur d'arrière ou d'avant plan
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Green;
```

---

# Console.Beep (À ne pas utiliser)

<div class="columns">
<div>


- Code c#

![alt text](images/image-67.png)

- P.S : Soyez indulgent envers l'art…

</div>
<div>

```c#
const int noteDo = 261;
const int noteRe = 293;
const int noteMi = 329;
const int noteFa = 349;
const int noteSol = 440;
const int noteLa = 493;
const int nbMillisecondes = 500;

Console.Beep(noteDo, nbMillisecondes); 
Console.Beep(noteRe, nbMillisecondes); 
Console.Beep(noteMi, nbMillisecondes); 
Console.Beep(noteDo, nbMillisecondes); 
Console.Beep(noteDo, nbMillisecondes); 
Console.Beep(noteRe, nbMillisecondes); 
Console.Beep(noteMi, nbMillisecondes);
Console.Beep(noteDo, nbMillisecondes);
Console.Beep(noteMi, nbMillisecondes);
Console.Beep(noteFa, nbMillisecondes);
Console.Beep(noteSol, nbMillisecondes * 2);
Console.Beep(noteMi, nbMillisecondes);
Console.Beep(noteFa, nbMillisecondes);
Console.Beep(noteSol, nbMillisecondes *2 );
Console.Beep(noteSol, nbMillisecondes);
Console.Beep(noteLa, nbMillisecondes / 2);
Console.Beep(noteSol, nbMillisecondes / 2);
Console.Beep(noteFa, nbMillisecondes / 2);
Console.Beep(noteMi, nbMillisecondes );
Console.Beep(noteDo, nbMillisecondes);
Console.Beep(noteSol, nbMillisecondes);
Console.Beep(noteLa, nbMillisecondes / 2);
Console.Beep(noteSol, nbMillisecondes / 2);
Console.Beep(noteFa, nbMillisecondes / 2);
Console.Beep(noteMi, nbMillisecondes);
Console.Beep(noteDo, nbMillisecondes);
Console.Beep(noteDo, nbMillisecondes);
Console.Beep(noteSol / 2, nbMillisecondes);
Console.Beep(noteDo, nbMillisecondes * 2);
Console.Beep(noteDo, nbMillisecondes);
Console.Beep(noteSol / 2, nbMillisecondes);
Console.Beep(noteDo, nbMillisecondes);
```

</div>
</div>

---

# Thread.Sleep


<div class="columns">
<div>
<br />

![alt text](images/image-68.png)

- Faire attendre le programme
- Utiliser « Thread.Sleep »
- Indiquer le nombre de millisecondes d'attente
- Tester le code suivant :


</div>
<div>

```c#
string message = "Traitement en cours";
Console.WriteLine(message);
Thread.Sleep(1000);
    
message = message + ".";
Console.Clear();
Console.WriteLine(message);
Thread.Sleep(1000);

message += ".";
Console.Clear();
Console.WriteLine(message);
Thread.Sleep(1000);

message += ".";
Console.Clear();
Console.WriteLine(message);
Thread.Sleep(1000);
```

</div>
</div>






---
