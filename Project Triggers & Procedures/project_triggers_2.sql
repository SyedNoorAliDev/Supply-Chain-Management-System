USE [Supply Management];

GO
CREATE TRIGGER after_order_insert
ON Orders
AFTER INSERT
AS
BEGIN
    INSERT INTO Shipments (shipment_id, order_id, shipment_date, status)
    SELECT (SELECT COUNT(*) + 1 FROM Shipments), 
           order_id, 
           order_date, 
           'pending'
    FROM INSERTED;
END;