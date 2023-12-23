/*ALTER TABLE Members ADD COLUMN FechaRegistro DATE;*/
/*DELIMITER //

CREATE PROCEDURE GetMembersLastWeek1()
BEGIN
    DECLARE inicioSemana DATE;

    SET inicioSemana = CURDATE() - INTERVAL (WEEKDAY(CURDATE()) + 7) DAY;

    SELECT M.MemberID, M.FechaRegistro, MT.TipoMembresia
    FROM Members M
    JOIN MembershipTypes MT ON M.MembershipTypeID = MT.MembershipTypeID
    WHERE M.FechaRegistro >= inicioSemana;
END //

DELIMITER ;
*/
CALL GetMembersLastWeek1();