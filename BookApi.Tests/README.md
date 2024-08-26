# .NET Core Developer Assessment

## Project Overview

This project is a REST API developed using .NET Core MVC. 
It manages book data by providing functionalities to

- Sort books by Publisher, Author (last, first), and Title.
- Retrieve the total price of all books in the database.
- Generate citations in MLA and Chicago styles.

The API interacts with a SQL Server(Windows Authentication) database and uses Entity Framework Core 
for data access. This project demonstrates various aspects of .NET Core development, 
including RESTful API design, database interaction, and unit testing.

## Technologies Used

- **.NET Core 8.0**: Framework for building the API.
- **Entity Framework Core**: ORM for data access and manipulation.
- **SQL Server Management Studio (SSMS-Windows Authentication)**: Database server for storing book data.
- **xUnit**: Framework for unit testing.
- **Moq**: Library for mocking dependencies in unit tests.


## Project Structure

## Controllers

BooksController: Handles API endpoints for retrieving, saving, 
and processing book data


Book: Represents the book entity with properties such as Publisher, 
Title, AuthorLastName, AuthorFirstName, and Price. Includes methods for 
generating MLA and Chicago style citations.

## Services

IBookService: Defines methods for book-related operations

BookService: Implements IBookService and interacts with the database
to perform operations.

## Repositories
IBookRepository: Defines methods for data access related to books

BookRepository: Implements IBookRepository and handles database operations.

## Data

BookContext: Entity Framework DbContext for interacting with the database.

## Tests

BooksControllerTests: Contains unit tests for the BooksController class.

BookServiceTests: Contains unit tests for the BookService class.

## API Endpoints

1. Get Books Sorted by Publisher, Author (Last, First), and Title
Endpoint: GET /api/books/sorted-by-publisher-author-title
Description: Returns a sorted list of books by Publisher, Author (Last, First), and Title.
 
2. Get Books Sorted by Author (Last, First) and Title
Endpoint: GET /api/books/sorted-by-author-title
Description: Returns a sorted list of books by Author (Last, First) and Title.
 
3. Get Total Price of All Books
Endpoint: GET /api/books/total-price
Description: Returns the total price of all books in the database.
 
## Stored Procedures

1. Stored Procedure for Sorted Books by Publisher, Author, and Title
Procedure Name: GetBooksSortedByPublisherAuthorTitle
Description: Retrieves books sorted by Publisher, Author (Last, First), and Title.
 
2. Stored Procedure for Sorted Books by Author and Title
Procedure Name: GetBooksSortedByAuthorTitle
Description: Retrieves books sorted by Author (Last, First) and Title.
 
## Implementation Details

--Entity Framework: Used for data access and manipulation.
  Provides an abstraction layer for interacting with the SQL database.

--Dependency Injection: Applied to enhance code flexibility and 
  manage dependencies. Services and repositories are injected into controllers and other services.

--Asynchronous Programming: Utilized async/await to improve performance and
  responsiveness of API calls and database operations.

--Design Patterns: Implemented Repository and Service patterns for data access and 
  business logic. This separation promotes a cleaner architecture and easier testing.