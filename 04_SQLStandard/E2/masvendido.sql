SELECT P.ProductTypeID, P.TipoProducto, P.Descripcion, SUM(S.TotalVenta) AS TotalVendido FROM ProductTypes P
JOIN Sales S ON P.ProductTypeID = S.ProductTypeID GROUP BY P.ProductTypeID, P.TipoProducto, P.Descripcion ORDER BY TotalVendido DESC
LIMIT 1;
