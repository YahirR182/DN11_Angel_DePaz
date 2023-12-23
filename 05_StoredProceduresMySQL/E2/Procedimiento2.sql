/*DELIMITER //

CREATE PROCEDURE RegistrarVenta(IN p_ProductTypeID INT,IN p_UserID INT)
BEGIN
    DECLARE v_SaleID INT;
   
    INSERT INTO Sales (MemberID, ProductTypeID, FechaVenta)
    VALUES (
        (SELECT MemberID FROM Members WHERE UserID = p_UserID LIMIT 1),
        p_ProductTypeID,
        CURDATE()
    );
    SET v_SaleID = LAST_INSERT_ID();

    SELECT v_SaleID AS SaleID, CURDATE() AS FechaVenta;
END //

DELIMITER ;
*/

CALL ResgistrarVenta(1,1);

