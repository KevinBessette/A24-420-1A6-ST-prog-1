# Exercice Formatif

## Objectif
- Expérimenter Git, Github, Github Desktop et VSCode
- Créer un premier programme c# de type Hello World!!

## Suivez les étapes:
1. Aller sur votre compte Github `https://github.com` et connectez-vous.
2. Cliquer sur le bouton `New` pour creer un nouveau répertoire.
   1. Choisir un nom significatif car vous en aurez plusieurs tout au long de votre technique.  Personnellement j'aime bien utiliser la structure suivante: `session-cours-titre`.  Dans ce cas-ci: `a24-prog1-helloworld`.
   2. Choisir `Private` afin que le dépôt ne soit pas public sur l'Internet.
   3. Cocher Add a README file.  Cela ajoutera automatiquement un fichier ReadMe.md à votre dépôt.
   4. Dans le menu déroulant `Add .gitignore`, choisissez Visual Studio.  Cela ajoutera automatiquement un fichier .gitignore configurer pour les projet Visual Studio (et donc c#) à votre dépôt.
   5. Cliquer sur Create repository
3. Cloner le dépôt sur votre ordinateur.
   1. Cliquer sur le bouton bleu `<> Code `
   2. Choisissez `Open with Github Desktop` Cela va ouvrir Github Desktop sur votre poste et préparer le clonage.  Si c'est une première utilisation, vous aurez probablement à vous authentifier.
   3. Dans la section `Local path` choisissez un l'emplacement où vous allez cloner le projet.  Je vous recommande fortement un emplacement local (cloner sur une clé USB, sur un répertoire réseau (M:/) ou un emplacement cloud (OneDrive) ralentira considérablement les opérations Git.
   4. Appuyez sur `Clone`.  
      1. C'est l'équivalent de rouler la commande `git clone` expliqué plutôt.
4. Initialiser un programme console en c# à l'intérieur du dossier cloné.
   1. Ouvrir le répertoire a24-prog1-helloworld.
   2. Exécuter la commande `dotnet new console`
5. Écriver votre nom dans le fichier readme.md.
   1. Prenez l'habitude de toujours écrire le nom de l'auteur dans ce fichier.  Surtout lorsque ce sera des exercices sommatifs, cela me permet de savoir à qui je dois donner la note. :P
6. Ouvrer le répertoire avec VSCode, jeter un coup d'oeil au code source dans le fichier `Program.cs` et jouer un peu avec.
   1. Cela devrait ressembler à ceci:
   ```
   // See https://aka.ms/new-console-template for more information
   Console.WriteLine("Hello, World!");
   ```
   2. Remarquer que La première ligne est précédé de deux `/`, cela signifie que la ligne est un commentaire destiner au programmeur et n'affect pas l'exécution du code.
   3. Sur la seconde ligne, la commande `Console.WriteLine("")` signifie qu'on écrire un ligne de texte dans la console.  Les mots entre guillemet sont ceux qui seront affiché.
7. *Commit early, commit often*
   1. Une bonne habitude à prendre est de faire des `commits` tôt et à chaque modification clé.
   2. Aller voir l'application Github Desktop, vous constatez que l'interface a changé. Il y a maintenant des modifications au répertoire git de signalé.
   3. Écriver un message décrivant la modification et appuyez sur `Commit to main`.
   4. Vous verrez ensuite un carré bleu vous signalé que votre dépôt local contient des changements qui n'ont pas encore été envoyé sur le dépôt distant (Github).  Appuyez sur `Push origin`.
8. Effectuer un modification au projet.
   1. Dans VSCODE
   2. Modifier le texte pour `Hello, prog1!`
   3. Sauvegarder le fichier.  Astuce: Utiliser le raccourci: `ctrl+s`
   4. Exécuter le code avec le petit bouton `play` en haut à droite.
   5. Le message devrait s'afficher dans le terminal interne de VSCode.
9.  Pousser à nouveau vos modification sur github.
   1. Voir étape 6.
10. Finalement, rafraichissez la page Web de votre répertoire sur Github.
   1.  Comme vous pouvez le voir, tout votre code et tout votre historique de programmation, est maintenant sauvegardé sur Github.
11. Bravo!