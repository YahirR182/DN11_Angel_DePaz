SELECT P.ProductTypeID, P.TipoProducto, P.Descripcion, I.CantidadDisponible FROM ProductTypes P JOIN Inventory I ON P.ProductTypeID = I.ProductTypeID;
