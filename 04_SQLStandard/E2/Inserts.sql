
INSERT INTO Roles (RolID, RolNombre) VALUES
(1, 'Admin'),
(2, 'User'),
(3, 'Guest'),
(4, 'Moderator'),
(5, 'Editor');


INSERT INTO Users (UserID, Nombre, Apellido, CorreoElectronico, OtrosCamposUsuario) VALUES
(1, 'John', 'Doe', 'john.doe@example.com', 'Info1'),
(2, 'Jane', 'Smith', 'jane.smith@example.com', 'Info2'),
(3, 'Alice', 'Johnson', 'alice.johnson@example.com', 'Info3'),
(4, 'Bob', 'Williams', 'bob.williams@example.com', 'Info4'),
(5, 'Eva', 'Brown', 'eva.brown@example.com', 'Info5');


INSERT INTO UsersInRoles (UserID, RolID) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);


INSERT INTO Cities (CityID, NombreCiudad) VALUES
(1, 'City1'),
(2, 'City2'),
(3, 'City3'),
(4, 'City4'),
(5, 'City5');


INSERT INTO Members (MemberID, UserID, CityID, OtrosCamposMiembro) VALUES
(1, 1, 1, 'MemberInfo1'),
(2, 2, 2, 'MemberInfo2'),
(3, 3, 3, 'MemberInfo3'),
(4, 4, 4, 'MemberInfo4'),
(5, 5, 5, 'MemberInfo5');


INSERT INTO MembershipTypes (MembershipTypeID, TipoMembresia, Descripcion, DuracionMeses) VALUES
(1, 'Gold', 'Gold Membership', 12),
(2, 'Silver', 'Silver Membership', 6),
(3, 'Bronze', 'Bronze Membership', 3),
(4, 'Platinum', 'Platinum Membership', 24),
(5, 'Basic', 'Basic Membership', 1);


INSERT INTO EquipmentType (EquipmentTypeID, TipoEquipo, Descripcion) VALUES
(1, 'Laptop', 'Portable computer'),
(2, 'Printer', 'Printing device'),
(3, 'Server', 'Powerful computer for hosting'),
(4, 'Scanner', 'Image scanning device'),
(5, 'Desktop', 'Non-portable computer');


INSERT INTO ProductTypes (ProductTypeID, TipoProducto, Descripcion) VALUES
(1, 'Electronics', 'Electronic devices'),
(2, 'Clothing', 'Clothing items'),
(3, 'Books', 'Literary works'),
(4, 'Furniture', 'Household furniture'),
(5, 'Toys', 'Play items');


INSERT INTO MeasureType (MeasureTypeID, TipoMedida, Descripcion, UnidadMedida) VALUES
(1, 'Weight', 'Weight measurement', 'kg'),
(2, 'Length', 'Length measurement', 'm'),
(3, 'Volume', 'Volume measurement', 'L'),
(4, 'Quantity', 'Quantity measurement', 'units'),
(5, 'Area', 'Area measurement', 'sqm');


INSERT INTO Inventory (InventoryID, ProductTypeID, MeasureTypeID, CantidadDisponible, OtrosCamposInventario) VALUES
(1, 1, 1, 100, 'InventoryInfo1'),
(2, 2, 2, 50, 'InventoryInfo2'),
(3, 3, 3, 75, 'InventoryInfo3'),
(4, 4, 4, 30, 'InventoryInfo4'),
(5, 5, 5, 200, 'InventoryInfo5');


INSERT INTO Sales (SaleID, MemberID, ProductTypeID, FechaVenta, TotalVenta, OtrosCamposVenta) VALUES
(1, 1, 1, '2023-01-01', 500.00, 'SaleInfo1'),
(2, 2, 2, '2023-02-01', 300.00, 'SaleInfo2'),
(3, 3, 3, '2023-03-01', 750.00, 'SaleInfo3'),
(4, 4, 4, '2023-04-01', 200.00, 'SaleInfo4'),
(5, 5, 5, '2023-05-01', 1000.00, 'SaleInfo5');
