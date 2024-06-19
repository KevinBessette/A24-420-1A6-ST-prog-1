---
marp: true
---

# Git - Fonctionnement et commande de base

---
# Git
Dans le cadre du cours, la majorité des notes de cours et exercices seront déposé sur Github.
Une fois que vous aurez créé votre compte Github, je vous donnerez accès aux dépôts du cours.  Vous pourrez ensuite cloner le dépôts du cours.

---
# Commandes de base de Git (1/2)
### git clone
`git clone <url>` : Cette commande est utilisée pour cloner (copier) un dépôt à partir d'une URL existante.
### git add
`git add <fichier>` : Cette commande ajoute un fichier à la zone de préparation pour le prochain commit.
### git commit
`git commit -m "<message>"` : Cette commande enregistre vos modifications dans le dépôt local. Le message qui suit `-m` est utilisé pour noter l'intention du commit.

---
# Commandes de base de Git (2/2)
### git push
`git push` : Cette commande envoie les commits de la branche locale vers le dépôt distant nommé.
### git pull
`git pull` : Cette commande récupère et fusionne les modifications du dépôt distant vers votre branche locale.
### git fetch
`git fetch` : Cette commande récupère toutes les modifications du dépôt distant, mais ne les fusionne pas avec votre branche locale.

---
# Schémas récapitulatif
![Schémas récapitulatif de Git](git-schema.png)