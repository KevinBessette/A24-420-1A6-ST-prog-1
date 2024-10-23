Exercice : Gestionnaire de stock de livres

Vous devez développer un petit programme de gestion de stock pour une bibliothèque. Le programme permettra d'ajouter des livres, de rechercher des livres en fonction de certains critères, et d'afficher la liste des livres disponibles.
Spécifications :

Collection de livres :
    Utilisez une liste pour stocker les livres. Chaque livre doit avoir les informations suivantes : titre, nombre de copies disponibles.

Fonctionnalités : Implémentez les fonctions suivantes :
    AjouterLivre: Cette fonction prend en paramètre un titre, un nombre de copies, et ajoute un livre à la collection.

    RechercherParAuteur: Cette fonction prend le nom d'un auteur en paramètre et renvoie tous les livres écrits par cet auteur. Utilisez une boucle pour parcourir la collection et une condition pour vérifier si l'auteur correspond.

    AfficherTousLesLivres: Cette fonction parcourt la collection de livres et affiche leurs détails. Utilisez une boucle pour afficher les informations de chaque livre.

    AfficherLivresDisponibles: Cette fonction affiche uniquement les livres qui ont plus de 0 copies disponibles. Utilisez une boucle et une condition pour filtrer les livres.

    EmprunterLivre: Cette fonction permet de simuler l'emprunt d'un livre. Elle prend le titre du livre en paramètre, vérifie s'il est disponible (nombre de copies > 0), et si c'est le cas, décrémente le nombre de copies. Sinon, elle affiche un message disant que le livre n'est pas disponible.

Exigences techniques :
    Implémentez des fonctions pour chacune des opérations.
    Respecter les principes SOLID.
    Valider vos inputs
    Utilisez les try-catch pour gérer les cas d'exceptions.