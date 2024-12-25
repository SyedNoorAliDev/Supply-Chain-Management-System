
USE [Supply Management System];

-- Example view: Get shipment details with order and supplier information
CREATE VIEW Shipment_Details AS
SELECT Shipments.shipment_id, Shipments.shipment_date, Orders.order_id, Orders.order_date, Suppliers.supplier_name
FROM Shipments
JOIN Orders ON Shipments.order_id = Orders.order_id
JOIN Suppliers ON Orders.supplier_id = Suppliers.supplier_id;

-- Example view: Get product inventory details with supplier information
CREATE VIEW Product_Inventory AS
SELECT Products.product_id, Products.product_name, Suppliers.supplier_name, Inventory.quantity
FROM Products
JOIN Suppliers ON Products.supplier_id = Suppliers.supplier_id
JOIN Inventory ON Products.product_id = Inventory.product_id;