# ARCHI_LIVRE

## Overview
This project consists of two main components: the Client and the API. Below is a detailed explanation of the structure and functionality of each component.

## Client
The client is responsible for interacting with the user and sending requests to the API. It is built using [mention the technology, e.g., React, Angular, etc.].

### Structure
- `src/`
    - `components/`: Contains reusable UI components.
    - `view/`: Contains the main pages of the application.
    - `services/`: Contains services for making API calls.
    - `assets/`: Contains static assets like images and stylesheets.
    - `environments/`: Contains configuration settings for different environments (e.g., development, production).
    - `models`: Contains data models and interfaces used throughout the client (e.g., User, Book, etc.).
    - `routing`: Handles the navigation and routing between different pages of the application.
    - `styles`: Contains global stylesheets and design variables (e.g., SCSS variables).
    - `utils`: Contains utility functions and helper methods used across different parts of the application.
    - `index.js`: The entry point of the application.

## API
The API is responsible for handling requests from the client and interacting with the database. It is built using [mention the technology, e.g., Node.js, Django, etc.].

### Structure
- `Controllers/`: Contains the logic for handling requests.
    - `userController.cs`: Logic for user-related operations.
    - `bookController.cs`: Logic for book-related operations.
- `DTO/`: Contains Data Transfer Objects used to structure data between the API and client.
    - `UserDto.cs`: Defines the structure of user data for API communication.
    - `BookDto.cs`: Defines the structure of book data for API communication.
- `Services/`: Contains the business logic.
    - `UsersServices.cs`: Handles user-related operations.
    - `BooksService.cs`: Manages book-related operations.
    - `LoansService.cs`: Handles book loan operations.
    - `ReservationsService.cs`: Manages reservation operations.
- `Entities/`: Contains database models.
    - `User.js`: User model, representing the user entity in the database.
    - `Book.js`: Book model, representing the book entity in the database.
- `Middlewares/`: Contains middleware functions.
    - `AuthMiddleware.cs`: Middleware for authentication and authorization.
- `Data/`: Contains configuration files.
    - `DataContext.cs`: Database configuration and connection management.
- `Program.cs`: Configuration file to bootstrap and run the API.

