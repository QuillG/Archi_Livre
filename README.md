# ARCHI_LIVRE

## Aperçu
Ce projet se compose de deux composants principaux : le Client et l'API. Vous trouverez ci-dessous une explication détaillée de la structure et des fonctionnalités de chaque composant.

## Client
Le client est responsable de l'interaction avec l'utilisateur et de l'envoi des requêtes à l'API. Il est développé en [mentionner la technologie, ex. : React, Angular, etc.].

### Structure
- `src/`
    - `components/` : Contient des composants d'interface utilisateur réutilisables.
    - `view/` : Contient les pages principales de l'application.
    - `services/` : Contient les services permettant d'effectuer des appels à l'API.
    - `assets/` : Contient des ressources statiques comme des images et des feuilles de styles.
    - `environments/` : Contient les paramètres de configuration pour différents environnements (ex. : développement, production).
    - `models/` : Contient les modèles de données et interfaces utilisés dans le client (ex. : User, Book, etc.).
    - `routing/` : Gère la navigation et le routage entre les différentes pages de l'application.
    - `styles/` : Contient les feuilles de styles globales et les variables de conception (ex. : variables SCSS).
    - `utils/` : Contient des fonctions utilitaires et des méthodes d'aide utilisées dans différentes parties de l'application.
    - `index.js` : Le point d'entrée de l'application.

## API
L'API est responsable du traitement des requêtes du client et de l'interaction avec la base de données. Elle est développée en [mentionner la technologie, ex. : Node.js, Django, etc.].

### Structure
- `Controllers/` : Contient la logique de gestion des requêtes.
    - `userController.cs` : Gère les opérations liées aux utilisateurs.
    - `bookController.cs` : Gère les opérations liées aux livres.
- `DTO/` : Contient les objets de transfert de données utilisés pour structurer les échanges entre l'API et le client.
    - `UserDto.cs` : Définit la structure des données utilisateur pour la communication API.
    - `BookDto.cs` : Définit la structure des données de livre pour la communication API.
- `Services/` : Contient la logique métier.
    - `UsersServices.cs` : Gère les opérations liées aux utilisateurs.
    - `BooksService.cs` : Gère les opérations liées aux livres.
    - `LoansService.cs
