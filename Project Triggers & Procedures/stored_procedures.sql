CREATE PROCEDURE dbo.UpdateShipmentStatusProcedure
    @order_id INT
AS
BEGIN
    UPDATE Shipments
    SET status = 'shipped'
    WHERE order_id = @order_id;
END;
