USE [Supply Management System];

-- Suppliers table
CREATE TABLE Suppliers (
  supplier_id INT PRIMARY KEY,
  supplier_name VARCHAR(50),
  supplier_address VARCHAR(100)
);

-- Products table
CREATE TABLE Products (
  product_id INT PRIMARY KEY,
  product_name VARCHAR(50),
  supplier_id INT,
  price DECIMAL(10, 2),
  FOREIGN KEY (supplier_id) REFERENCES Suppliers(supplier_id)
);

-- Orders table
CREATE TABLE Orders (
  order_id INT PRIMARY KEY,
  order_date DATE,
  supplier_id INT,
  FOREIGN KEY (supplier_id) REFERENCES Suppliers(supplier_id)
);

-- Order_Items table
CREATE TABLE Order_Items (
  order_item_id INT PRIMARY KEY,
  order_id INT,
  product_id INT,
  quantity INT,
  FOREIGN KEY (order_id) REFERENCES Orders(order_id),
  FOREIGN KEY (product_id) REFERENCES Products(product_id)
);

-- Customers table
CREATE TABLE Customers (
  customer_id INT PRIMARY KEY,
  customer_name VARCHAR(50),
  email VARCHAR(50),
  phone_number VARCHAR(20)
);

-- Shipments table
CREATE TABLE Shipments (
  shipment_id INT PRIMARY KEY,
  order_id INT,
  shipment_date DATE,
  status VARCHAR(20),
  FOREIGN KEY (order_id) REFERENCES Orders(order_id)
);

-- Inventory table
CREATE TABLE Inventory (
  product_id INT,
  quantity INT,
  FOREIGN KEY (product_id) REFERENCES Products(product_id)
);

-- Payments table
CREATE TABLE Payments (
  payment_id INT PRIMARY KEY,
  order_id INT,
  amount DECIMAL(10, 2),
  payment_date DATE,
  FOREIGN KEY (order_id) REFERENCES Orders(order_id)
);

-- Categories table
CREATE TABLE Categories (
  category_id INT PRIMARY KEY,
  category_name VARCHAR(50)
);

-- Products_Categories table
CREATE TABLE Products_Categories (
  product_id INT,
  category_id INT,
  FOREIGN KEY (product_id) REFERENCES Products(product_id),
  FOREIGN KEY (category_id) REFERENCES Categories(category_id)
);

-- Reviews table
CREATE TABLE Reviews (
  review_id INT PRIMARY KEY,
  product_id INT,
  customer_id INT,
  rating INT,
  review_text VARCHAR(500),
  FOREIGN KEY (product_id) REFERENCES Products(product_id),
  FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);