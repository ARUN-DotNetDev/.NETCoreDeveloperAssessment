
INSERT INTO Books (Id, Publisher, Title, AuthorLastName, AuthorFirstName, Price)
VALUES
(1, 'Publisher A', 'Book 1', 'David', 'Miller', 39.99),
(2, 'Publisher B', 'Book 2', 'Andrew', 'Russel', 35.66),
(3, 'Publisher A', 'Book 3', 'Brenden', 'Mccullum', 45.30),
(4, 'Publisher C', 'Book 4', 'David', 'Warner', 20.10);


   
--Results
/*
 GET/api/books/sorted-by-publisher-author-title
  Description: Returns a sorted list of books by Publisher, Author (last, first), and Title.

Sample Request:

  https://localhost:7244/api/books/sorted-by-publisher-author-title
    ```
Sample Response
 
    [
  {
    "id": 3,
    "publisher": "Publisher A",
    "title": "Book 3",
    "authorLastName": "Brenden",
    "authorFirstName": "Mccullum",
    "price": 45.3,
    "mlaCitation": "Brenden, Mccullum. *Book 3*. Publisher A, 2024.",
    "chicagoCitation": "Brenden, Mccullum. *Book 3*. Publisher A, 2024."
  },
  {
    "id": 1,
    "publisher": "Publisher A",
    "title": "Book 1",
    "authorLastName": "David",
    "authorFirstName": "Miller",
    "price": 39.99,
    "mlaCitation": "David, Miller. *Book 1*. Publisher A, 2024.",
    "chicagoCitation": "David, Miller. *Book 1*. Publisher A, 2024."
  },
  {
    "id": 2,
    "publisher": "Publisher B",
    "title": "Book 2",
    "authorLastName": "Andrew",
    "authorFirstName": "Russel",
    "price": 35.66,
    "mlaCitation": "Andrew, Russel. *Book 2*. Publisher B, 2024.",
    "chicagoCitation": "Andrew, Russel. *Book 2*. Publisher B, 2024."
  },
  {
    "id": 4,
    "publisher": "Publisher C",
    "title": "Book 4",
    "authorLastName": "David",
    "authorFirstName": "Warner",
    "price": 20.1,
    "mlaCitation": "David, Warner. *Book 4*. Publisher C, 2024.",
    "chicagoCitation": "David, Warner. *Book 4*. Publisher C, 2024."
  }
]
*/



/*
GET /api/books/sorted-by-author-title
  Description: Returns a sorted list of books by Author (last, first) and Title.
  Sample Request

https://localhost:7244/api/books/sorted-by-author-titlee
    ```
  - Sample Response:
   
    [
  {
    "id": 2,
    "publisher": "Publisher B",
    "title": "Book 2",
    "authorLastName": "Andrew",
    "authorFirstName": "Russel",
    "price": 35.66,
    "mlaCitation": "Andrew, Russel. *Book 2*. Publisher B, 2024.",
    "chicagoCitation": "Andrew, Russel. *Book 2*. Publisher B, 2024."
  },
  {
    "id": 3,
    "publisher": "Publisher A",
    "title": "Book 3",
    "authorLastName": "Brenden",
    "authorFirstName": "Mccullum",
    "price": 45.3,
    "mlaCitation": "Brenden, Mccullum. *Book 3*. Publisher A, 2024.",
    "chicagoCitation": "Brenden, Mccullum. *Book 3*. Publisher A, 2024."
  },
  {
    "id": 1,
    "publisher": "Publisher A",
    "title": "Book 1",
    "authorLastName": "David",
    "authorFirstName": "Miller",
    "price": 39.99,
    "mlaCitation": "David, Miller. *Book 1*. Publisher A, 2024.",
    "chicagoCitation": "David, Miller. *Book 1*. Publisher A, 2024."
  },
  {
    "id": 4,
    "publisher": "Publisher C",
    "title": "Book 4",
    "authorLastName": "David",
    "authorFirstName": "Warner",
    "price": 20.1,
    "mlaCitation": "David, Warner. *Book 4*. Publisher C, 2024.",
    "chicagoCitation": "David, Warner. *Book 4*. Publisher C, 2024."
  }
]
*/

/*
GET /api/books/total-price
Description: Returns the total price of all books in the database.
 Sample Request:
  https://localhost:7244/api/books/total-price
    ```
 Sample Response:
   141.05*/
    

