CREATE TABLE users
(
	id int PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date DATE NULL
)

SELECT * FROM users

INSERT INTO users (username, password, role, status, date) VALUES('admin', 'admin123', 'Admin', 'Aktív', '2025-05-06')

CREATE TABLE categories
(
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	date DATE NULL
)

SELECT * FROM categories

INSERT INTO categories (category,date) VALUES ('b','2025-05-12')

SELECT name FROM sys.tables WHERE name LIKE '%categories%';
SELECT * FROM information_schema.tables WHERE table_name = 'categories';

CREATE TABLE products
(
	id INT PRIMARY KEY IDENTITY(1,1),
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	category VARCHAR(MAX) NULL,
	price INT NULL,
	stock INT NULL,
	status VARCHAR(MAX) NULL,
	date DATE NULL,
	cost INT NULL
)

SELECT * FROM products

CREATE TABLE orders(
	id INT PRIMARY KEY IDENTITY(1,1),
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	category VARCHAR(MAX) NULL,
	quantity int NULL,
	price INT NULL,
	order_date DATE NULL,
	customer_id INT NULL,
	total_price INT NULL
)

SELECT * FROM orders

CREATE TABLE customers(
	id INT PRIMARY KEY IDENTITY(1,1),
	customer_id int NULL,
	/*prod_id VARCHAR(MAX) NULL,*/
	total_price INT NULL,
	amount INT NULL,
	change INT NULL,
	order_date DATE NULL
)

SELECT * FROM customers


ALTER TABLE orders
DROP COLUMN customer_id

ALTER TABLE orders
ADD total_price INT NULL

ALTER TABLE customers
DROP COLUMN prod_id