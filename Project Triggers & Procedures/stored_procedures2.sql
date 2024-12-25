CREATE PROCEDURE dbo.RevertShipmentStatusProcedure
    @order_id INT
AS
BEGIN
    UPDATE Shipments
    SET status = 'pending'
    WHERE order_id = @order_id;
END;
