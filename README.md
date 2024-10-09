# Movie Rental Backend

This project is a backend API for renting movies online. It allows users to view available movies, search for movies, rent and return copies of movies, and manage stock levels.

## Features
- **Get All Movies**: View a list of all available movies.
- **Search Movies**: Search for movies by title, genre, director, or year of release.
- **Checkout Movie**: Rent a specified number of copies of a movie.
- **Return Movie**: Return a specified number of copies of a movie.

## Technologies Used
- **ASP.NET Core 8.0**
- **C#**
- **REST API**
- **Swashbuckle for API Documentation**

## How to Run

### Prerequisites
- [.NET SDK 8.0+](https://dotnet.microsoft.com/download/dotnet/8.0)

### Running Locally

1. Clone the repository:
    ```bash
    git clone https://github.com/mjguillemette/movies-backend.git
    cd MovieRentalBackend
    ```

2. Build and run the project:
    ```bash
    dotnet run
    ```

3. The server will be running on `http://localhost:5154` (or any other port specified). [To utilize the frontend with this backend make sure that the `movieService.ts` file points correctly to the specified route and port]

### API Endpoints

#### Get All Movies
- **URL**: `/api/movies`
- **Method**: `GET`
- **Description**: Fetches all available movies.

#### Search Movies
- **URL**: `/api/movies/search`
- **Method**: `GET`
- **Query Parameters**:
    - `title` (optional): The title of the movie.
    - `genre` (optional): The genre of the movie.
    - `director` (optional): The director of the movie.
    - `yearOfRelease` (optional): The year the movie was released.

#### Checkout Movie
- **URL**: `/api/movies/checkout`
- **Method**: `POST`
- **Body (JSON)**:
    ```json
    {
      "title": "Inception",
      "amount": 1
    }
    ```

#### Return Movie
- **URL**: `/api/movies/return`
- **Method**: `POST`
- **Body (JSON)**:
    ```json
    {
      "title": "Inception",
      "amount": 1
    }
    ```
