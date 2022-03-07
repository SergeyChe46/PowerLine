CREATE TABLE Customers
(
    Id INT PRIMARY KEY,
    Name VARCHAR(20)
)

INSERT INTO Customers (Id, Name) 
VALUES (1, 'Max'),
(2, 'Pavel'),
(3, 'Ivan'),
(4, 'Leonid')

CREATE TABLE Orders
(
    Id INT PRIMARY KEY,
    CustomerId INT REFERENCES Customers (Id)
)

INSERT INTO Orders (Id, CustomerId)
VALUES (1, 2),
(2, 4)

SELECT Name as Customer
  FROM Customers
 WHERE Customers.Id NOT IN(
     SELECT CustomerId 
       FROM Orders)