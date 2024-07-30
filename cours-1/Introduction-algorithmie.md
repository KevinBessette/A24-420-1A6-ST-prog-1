---
marp: true
paginate: true
_class: invert
---

### 420-1A6-ST Algorithmie et programmation structurée
(Programmation 1)
# Introduction

---

# Qu'est-ce qu'un algorithme ?
## Définition
Un **algorithme** est une suite d'étapes permettant de résoudre un problème ou d'accomplir une tâche spécifique.
- **Entrée** : Un algorithme peut avoir zéro ou plusieurs entrées, qui sont les données sur lesquelles il opère pour produire une sortie.
- **Sortie** : Un algorithme doit produire au moins une sortie, qui est le résultat de son exécution sur les entrées fournies.
---

## Caractéristiques d'un algorithme
- **Finitude** : Se termine après un nombre fini d'étapes. Attention au boucle infinie.
- **Déterminisme** : Un même ensemble d'entrées doit toujours produire le même ensemble de sorties.
- **Efficacité** : Utilise une quantité raisonnable de ressources telles que le temps et l'espace mémoire.
- **Indépendance du langage** :  Un même algorithme devrait pouvoir être programmer dans plusieurs différents langages.

---

# Qu'est-ce que le pseudo-code ?
## Définition
Le **pseudo-code** est une manière informelle de décrire un algorithme en utilisant un langage naturel (ex. du français)
_J'utiliserai le pseudo-code pour vous expliquez certain concept général de programmation._

---

## Avantages du Pseudo-code
- **Lisibilité** : Facile à lire et à comprendre, même pour les non-programmeurs.
- **Flexibilité** : Indépendant du langage de programmation.
- **Clarté** : Aide à clarifier les étapes d'un algorithme avant de le coder.

---

## Exemple de Pseudo-code
```
Programme de Salutation

Entrées :
- nom
- messageSalutation

Sortie :
- salutationComplete

Début
    ECRIRE "Entrez votre nom : "
    Lire nom

    ECRIRE "Entrez votre message de salutation : "
    Lire messageSalutation

    salutationComplete <- "Bonjour " + nom + ", " + messageSalutation

    ECRIRE salutationComplete
Fin
```

---

# Qu'est-ce que le C# ?
## Définition
**C#** (prononcé "C sharp") est un langage de programmation moderne, développé par Microsoft dans le cadre de sa plateforme .NET.
_C'est le langage de programmation qui sera utilisé dans ce cours_

---

## Caractéristiques du C#
- **Syntaxe familière** : Sa syntaxe et ses concepts sont similaires à ceux de nombreux autres langages populaires comme Java, C++, et Python.
- **Fortement typé** : Les types de données sont précis.  Par exemple,. il y a un type différent pour un chiffre et pour un nombre à virgule.
- **Gestion automatique de la mémoire** : Utilise un ramasse-miettes pour la gestion de la mémoire.
- **Interopérabilité** : Peut interagir avec d'autres langages via .NET.

---

## Utilisations du C#
- **Applications de bureau** : Applications Windows. Console (dans ce cours) ou avec GUI (Prog2).
- **Applications web** : Développement web avec ASP.NET. (Web2)
- **Jeux vidéo** : Développement de jeux avec Unity. (cours de jeux)
- etc.

---

## Exemple de Code en C#

```csharp
string nom, messageSalutation;
string salutationComplete;

Console.WriteLine("Entrez votre nom : ");
nom = Console.ReadLine();

Console.WriteLine("Entrez votre message de salutation : ");
messageSalutation = Console.ReadLine();

salutationComplete = "Bonjour " + nom + ", " + messageSalutation;
Console.WriteLine(salutationComplete);
```

---

# Quiz

---

## Question 1
Nommez-moi une caractéristiques d'un algorithme ?

---

## Réponse
- **Finitude**: Pas de boucle infini.
- **Déterminisme**: même entrée = même sortie.
- **Efficacité** : Quantité raisonnable de ressources.
- **Indépendance du langage** :  Peut être programmer dans plusieurs langages.

---

## Question 2
Quelle est l'utilité principale du pseudo-code ?
(A) Compiler des programmes
(B) Décrire un algorithme de manière formelle
(C) Écrire des programmes de manière informelle
(D) Analyser les performances d'un programme

---
## Réponse
(C) Écrire des programmes de manière informelle

---

## Question 3
Quel est le langage de programmation qui sera utilisé dans ce cours ?
(A) Java
(B) C++
(C) Python
(D) C#

---

## Réponse
(D) c#

---

## Question 4
Quelle caractéristique du C# parmi les suivantes est correct?
(A) Syntaxe unique
(B) Typage dynamique
(C) Gestion manuelle de la mémoire
(D) Fortement typé

---

## Réponse
(D) Fortement typé

