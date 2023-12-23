SELECT U.Nombre, U.Apellido, R.RolNombre FROM Users U JOIN UsersInRoles UR ON U.UserID = UR.UserID JOIN Roles R ON UR.RolID = R.RolID;
