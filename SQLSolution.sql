CREATE TABLE Products (
Id INT PRIMARY KEY NOT NULL,
"Name" VARCHAR(255) NOT NULL
);

CREATE TABLE Categories (
Id INT PRIMARY KEY NOT NULL,
"Name" VARCHAR(255) NOT NULL
);

CREATE TABLE ProductCategory  (
ProductId INT FOREIGN KEY REFERENCES Products(Id),
CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Products
VALUES
(1,'Samsung Galaxy S10'),
(2, 'IPhone 12'),
(3, 'Nokia 3310'),
(4, 'Oppo Reno 5');

INSERT INTO Categories 
VALUES
(1,'Samsung'),
(2, 'Apple'),
(3, 'Nokia'),
(4, 'Sale');

INSERT INTO ProductCategory
VALUES
(1, 1),
(1, 4),
(2, 2),
(3, 3),
(3, 4);

SELECT Products.Name, Categories.Name
FROM Products
LEFT JOIN ProductCategory 
	ON Products.Id = ProductCategory.ProductId
LEFT JOIN Categories 
	ON ProductCategory.CategoryId = Categories.Id;