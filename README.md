## Critères d'évaluation
1. Analyse et préparation correctes du projet de développement de l’application (SS.1, SS.2, SS.3) 15 %
2. Programmation rigoureuse de l’interface et de la logique applicative selon les normes et spécifications (SS.1, SS.4, SS.5) 55 %
3. Contrôle rigoureux de la qualité de l’application (SS.6) 15 %
4. Déploiement et production d’une documentation de qualité respectueuse des normes du cours et respect des règles d’orthographe et de grammaire dans l’interface (SS.2, SS.7, SS.8) 15 %

## Relations
- Plusieurs enfants peuvent visiter une maison et une maison est visitée par plusieurs enfants.
- Une maison propose plusieurs bonbons, un bonbon est proposé par une seule maison.

## Exigences de l'application
- L'application doit permettre l'affichage, l'ajout, la modification et la suppression. Il y'a des bouts de code présents, vous devez les compléter afin de les faire fonctionner.
- L'application doit vérifier que l'adresse d'une maison est composée de 5 à 100 caractères
- L'application doit vérifier que le code postal respecte le format québécois (ex: H2X 1Y7) en utilisant une regex.
- L'application doit vérifier que le nom d'un bonbon est composé de 3 à 50 caractères et ne contient pas les caractères spéciaux suivants : {}<>[]#*@
- L'application doit vérifier que la quantité de bonbons est entre 1 et 500
- On doit pouvoir voir les maisons visitées par les enfants.
- On doit pouvoir voir naviguer d'une maison vers une page contenant des détails sur les bonbons. On doit également pouvoir ajouter, modifier et supprimer des bonbons (Instructions plus bas)

## Instructions
1. Seeding (15 pts)
Ajouter le seeding de bonbons pour créer au moins 11 bonbons répartis sur 3 maisons différentes. Assurer une variété de catégories.

2. Logique applicative (35 pts) et interface (20 pts)
a) Page de gestion des bonbons d'une maison :
- Créer une nouvelle page BonbonsMaisonPage qui affiche tous les bonbons d'une maison sélectionnée
- Afficher : Nom du bonbon, Quantité, Catégorie
- Permettre la navigation vers cette page depuis la carte d'une maison

b) Calcul de la quantité totale de bonbons par maison:
- Sur la page des maisons, afficher sur chaque carte de maison le nombre total de bonbon qu'elle possède.

c) Suppression de bonbon :
- Permettre la suppression d'un bonbon depuis la page des bonbons
- Le bonbon doit disparaître de l'interface ET de la base de données
- La quantité totale de la maison doit se mettre à jour automatiquement

d) Ajout et Modification de bonbon :
- Ajouter les fonctionnalités d'ajout et de modification de bonbons avec la méthode de votre choix (navigation vers une nouvelle par pour accéder au formulaire, formulaire dans dialog, formulaire dans flyout, etc. ).
Inclure : Nom, Quantité et Catégorie (ComboBox avec l'enum)
Sauvegarder dans la base de données

e) Respect des exigences de validation :
Implémenter toutes les validations listées ci-dessus
Afficher des messages d'erreur clairs

3. Tests (15 pts)
a) Test unitaire :
- Vérifier que le calcul de la quantité totale de bonbons d'une maison est correct.
- Ajoutez des tests pour au moin un ajout, une modification et une suppression.


4. Documentation (15 pts)
Documenter adéquatement toutes les méthodes qui touchent :
- Le calcul de la quantité totale de bonbons d'une maison
- L'ajout, la modification et la suppression de bonbons

## Diagrammes
### Diagramme de classes

### Diagramme de contexte

