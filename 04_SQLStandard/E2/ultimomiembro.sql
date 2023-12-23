SELECT M.MemberID, U.Nombre, U.Apellido, MT.TipoMembresia FROM Members M JOIN Users U ON M.UserID = U.UserID
JOIN MembershipTypes MT ON M.MembershipTypeID = MT.MembershipTypeID ORDER BY M.MemberID DESC
LIMIT 1;

