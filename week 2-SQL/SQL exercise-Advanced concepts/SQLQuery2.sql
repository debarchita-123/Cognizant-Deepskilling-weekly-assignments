SELECT *
FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS Rank
    FROM Products
) ranked
WHERE Rank <= 3;

