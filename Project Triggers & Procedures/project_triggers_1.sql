-- Example trigger: Update product quantity in Inventory when an order is placed
USE [Supply Management System];

GO
CREATE TRIGGER update_inventory
ON Order_Items
AFTER INSERT
AS
BEGIN
  UPDATE Inventory
  SET Inventory.quantity = Inventory.quantity - i.quantity
  FROM Inventory
  INNER JOIN inserted i ON Inventory.product_id = i.product_id
END;









