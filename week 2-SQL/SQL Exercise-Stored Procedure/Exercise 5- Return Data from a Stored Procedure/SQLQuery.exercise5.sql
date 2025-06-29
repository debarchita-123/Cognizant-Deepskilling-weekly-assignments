CREATE PROCEDURE sp_GetEmployeeCountByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        D.DepartmentName,
        COUNT(E.EmployeeID) AS TotalEmployees
    FROM Departments D
    LEFT JOIN Employees E ON D.DepartmentID = E.DepartmentID
    WHERE D.DepartmentID = @DepartmentID
    GROUP BY D.DepartmentName;
END;
