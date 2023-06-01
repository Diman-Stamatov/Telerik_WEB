-- 1. Find all information about all departments.

--SELECT * FROM Departments;

-- 2. Find all department names.

--SELECT DISTINCT Name FROM Departments;

-- 3. Find the salary of each employee.

--SELECT FirstName, LastName, Salary FROM Employees;

-- 4. Write a SQL to find the full name of each employee. 

--       Hint: Full name is constructed by joining first, middle and last name.
--SELECT CONCAT_WS(' ', FirstName ,MiddleName ,LastName) AS FullName FROM Employees;

-- 5. Find all different employee salaries.

--SELECT DISTINCT Salary FROM Employees;

-- 6. Find all information about the employees whose job title is "Sales Representative" or "Sales Manager".

--SELECT * FROM Employees
--WHERE JobTitle = 'Sales Representative' OR JobTitle ='Sales Manager';

-- 7. Find the names of all employees whose first name starts with "SA".

--SELECT CONCAT_WS(' ', FirstName, MiddleName, LastName) AS FullName FROM Employees
--WHERE FirstName LIKE 'Sa%';

-- 8. Find the names of all employees whose last name contains "ei".

--SELECT Concat_WS(' ', FirstName, MiddleName, LastName) AS FullName FROM Employees
--WHERE LastName LIKE '%ei%';

-- 9. Find the salary of all employees whose salary is in the range [20000…30000].

--SELECT Salary FROM Employees
--WHERE Salary < 30000 AND Salary > 20000
--ORDER BY Salary;

-- 10. Find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

--SELECT CONCAT_WS(' ', FirstName, MiddleName, LastName) AS FullName, Salary FROM Employees
--WHERE Salary = 25000 OR Salary = 14000 OR Salary = 12500 OR Salary = 23600
--ORDER BY Salary;

-- 11. Find all employees that do not have manager.

--SELECT * FROM Employees
--WHERE ManagerID IS NULL;

-- 12. Find all employees that have salary more than 50000. Order them in decreasing order by salary.

--SELECT * FROM Employees
--WHERE Salary > 50000
--ORDER BY SALARY DESC;

-- 13. Find the top 5 best paid employees.

--SELECT TOP 5 * FROM Employees
--ORDER BY Salary DESC;

-- 14. Find all employees along with their address. Use inner join with ON clause.

--SELECT CONCAT_WS(' ', FirstName, MiddleName, LastName) AS FullName, AddressText AS Address FROM Employees
--INNER JOIN Addresses ON Employees.AddressID = Addresses.AddressID;

-- 15. Find all employees and their address. Use equijoins (conditions in the WHERE clause).

--SELECT FirstName, LastName, AddressText FROM Employees, Addresses
--WHERE Employees.AddressID = Addresses.AddressID;

-- 16. Find all employees along with their manager.

--SELECT CONCAT_WS(' ', Employees.FirstName ,Employees.MiddleName ,Employees.LastName) AS FullName, 
--CONCAT_WS(' ', Managers.FirstName ,Managers.MiddleName ,Managers.LastName) AS ManagerName FROM Employees 
--INNER JOIN Employees as Managers on Employees.ManagerID = Managers.EmployeeID
--ORDER BY Employees.EmployeeID;
 
-- 17. Find all employees, along with their manager's address. 
--       Hint: Join Employees AS e, Employees AS m and Addresses.

--SELECT CONCAT_WS(' ', Employees.FirstName, Employees.MiddleName, Employees.LastName) AS FullName, 
--AddressText as ManagerAddress FROM Employees
--INNER JOIN Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID
--INNER JOIN Addresses ON Managers.AddressID = Addresses.ADDRESSID
--;

-- 18. Find all departments and all town names as a single list. 
--       Hint: Use UNION (https://www.w3schools.com/sql/sql_union.asp)

--SELECT Name FROM Departments
--UNION
--SELECT Name FROM Towns

-- 19. Write a SQL query that lists the name of each employee along with the name of their manager.
--       Hint: Use RIGHT OUTER JOIN (https://www.w3schools.com/sql/sql_join_right.asp). Rewrite the query using LEFT OUTER JOIN.
--             The expected result after using RIGHT OUTER JOIN is shown below.

--SELECT CONCAT_WS(' ', Employee.FirstName ,Employee.LastName) as EmployeeName,
--CONCAT_WS(' ', Manager.FirstName, Manager.LastName) as ManagerName
--FROM Employees as Manager RIGHT OUTER JOIN Employees as Employee
--ON Employee.ManagerID = Manager.EmployeeID;

-- | Employee                 | Manager            |
-- | ------------------------ | ------------------ |
-- | Ken Sanchez              | NULL               |
-- | Martin Kulov             | NULL               |
-- | George Denchev           | NULL               |
-- | Ovidiu Cracium           | Roberto Tamburello |
-- | Michael Sullivan         | Roberto Tamburello |
-- | Sharon Salavaria         | Roberto Tamburello |
-- | Dylan Miller             | Roberto Tamburello |
-- | Rob Walters              | Roberto Tamburello |
-- | Gail Erickson            | Roberto Tamburello |
-- | Jossef Goldberg          | Roberto Tamburello |
-- | Kevin Brown              | David Bradley      |
-- | Sariya Harnpadoungsataya | David Bradley      |
-- | Jill Williams            | David Bradley      |
-- | Mary Gibson              | David Bradley      |
-- | Terry Eminhizer          | David Bradley      |

-- 20. Find the names of all employees who were hired between 1995 and 2005 and are part of the "Sales" or "Finance" departments.

--SELECT CONCAT_WS(' ', FirstName , MiddleName , LastName) as FullName, Departments.Name as DepartmentName
--FROM Employees JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID
--WHERE HireDate >= 1995 AND HireDate <= '2005'
--AND Name = 'Sales' OR Name = 'Finance';

-- 21. Find the names and salaries of the employees that take the minimal salary in the company.
--       Hint: Use a nested SELECT statement.

--SELECT CONCAT_WS(' ', FirstName , MiddleName , LastName) as FullName, Salary FROM Employees
--WHERE Salary = (SELECT TOP 1 Salary FROM Employees ORDER BY Salary ASC);

-- 22. Find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.

--SELECT CONCAT_WS(' ', FirstName , MiddleName , LastName) as FullName, Salary FROM Employees
--WHERE Salary <= (SELECT TOP 1 Salary FROM Employees ORDER BY Salary ASC)*1.1;

-- 23. Find the full name, salary and department of the employees that take the minimal salary in their department.
--       Hint: Use a nested SELECT statement.

--SELECT CONCAT_WS(' ', FirstName , MiddleName , LastName) as FullName, Salary, Name as DepartmentName FROM Employees
--JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID
--WHERE Salary IN (SELECT MIN(Salary) FROM Employees WHERE Employees.DepartmentID = Departments.DepartmentID
--GROUP BY Employees.DepartmentID)
--ORDER BY DepartmentName;

-- 24. Find the number of employees and average salary for each department.
--       Hint: The expected result is shown below.

--SELECT  Name as Department, COUNT (FirstName) as Employees, FORMAT(AVG (Salary), '000.00') as AverageSalary
--FROM Employees JOIN Departments on Employees.DepartmentID = Departments.DepartmentID
--GROUP BY Name
--ORDER BY AverageSalary DESC

-- | Department                 | Employees | Average Salary |
-- | -------------------------- | --------- | -------------- |
-- | Executive                  | 2         | 92800.00       |
-- | Research and Development   | 6         | 45133.00       |
-- | Engineering                | 6         | 40167.00       |
-- | Information Services       | 10        | 34180.00       |
-- | Sales                      | 18        | 29989.00       |
-- | Tool Design                | 4         | 27150.00       |
-- | Finance                    | 10        | 23930.00       |
-- | Purchasing                 | 12        | 18983.00       |
-- | Production Control         | 6         | 18683.00       |
-- | Human Resources            | 6         | 18017.00       |
-- | Quality Assurance          | 7         | 17543.00       |
-- | Document Control           | 5         | 14400.00       |
-- | Production                 | 179       | 14163.00       |
-- | Marketing                  | 8         | 14063.00       |
-- | Facilities and Maintenance | 7         | 13057.00       |
-- | Shipping and Receiving     | 6         | 10867.00       |

-- 25. Find the average salary in the "Sales" department.

--SELECT Name AS Department, FORMAT (AVG (Salary), '0.00') AS AverageSalary
--FROM Employees JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID
--WHERE Name = 'Sales'
--GROUP BY Name;

-- 26. Find the number of employees in the "Sales" department.

--SELECT Name as Department, COUNT (FirstName) AS NumberOfEmployees 
--FROM Employees JOIN Departments
--ON Employees.DepartmentID = Departments.DepartmentID
--WHERE Name = 'Sales'
--GROUP BY Name;

-- 27. Find the number of all employees that have a manager.

--SELECT COUNT (FirstName) as EmployeesWithManager
--FROM Employees
--WHERE ManagerID IS NOT NULL;

-- 28. Find the number of all employees that have no manager.

--SELECT COUNT (FirstName) as EmployeesWithoutManager
--FROM Employees
--WHERE ManagerID IS NULL;

-- 29. Find all employees along with their manager. For employees without a manager display the value "(shef4e)".

--SELECT CONCAT_WS(' ', Employee.FirstName, Employee.MiddleName, Employee.LastName) as EmployeeName, 
--CASE WHEN Employee.ManagerID IS NULL THEN 'Shef4e' 
--ELSE CONCAT_WS(' ', Manager.FirstName, Manager.MiddleName, Manager.LastName)END as ManagerName
--FROM Employees AS Employee LEFT OUTER JOIN Employees as Manager 
--ON Employee.ManagerID = Manager.EmployeeID;

-- 30. Find all departments and the average salary for each of them.

--SELECT Name AS Department, Format (AVG(Salary), '0.00') AS AverageSalary
--FROM Employees JOIN Departments 
--ON Employees.DepartmentID = Departments.DepartmentID
--GROUP BY Name;

-- 31. Find the number of employees in each town's department. The result table should have 3 columns - Town, Department and Employees Count. 
--       Hint: The expected table has 85 rows. The first 12 rows are shown below.

--SELECT Towns.Name AS Town, Departments.Name AS Department, COUNT (FirstName) AS EmployeeCount
--FROM Employees JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID
--JOIN Addresses ON Employees.AddressID = Addresses.AddressID
--JOIN Towns ON Addresses.TownID = Towns.TownID
--GROUP BY Towns.Name, Departments.Name
--ORDER BY Town, EmployeeCount DESC;

-- | Town	    | Department	                | Employees Count |
-- | ---------- | ----------------------------- | --------------- |
-- | Bellevue	| Production	                | 22              |
-- | Bellevue	| Purchasing	                | 5               |
-- | Bellevue	| Production Control	        | 2               |
-- | Bellevue	| Marketing	                    | 2               |
-- | Bellevue	| Engineering	                | 1               |
-- | Bellevue	| Human Resources	            | 1               |
-- | Bellevue	| Information Services	        | 1               |
-- | Bellevue	| Research and Development	    | 1               |
-- | Bellevue	| Sales	                        | 1               |
-- | Berlin	    | Sales	                        | 1               |
-- | Bordeaux	| Sales	                        | 1               |

-- 32. Display the first and last name of all managers with exactly 5 employees. 

--SELECT * FROM 
--(SELECT Manager.FirstName, Manager.LastName, COUNT (Employee.ManagerID) as EmployeeCount
--FROM Employees as Employee JOIN Employees as Manager
--ON Employee.ManagerID = Manager.EmployeeID
--GROUP BY Employee.ManagerID, Manager.FirstName, Manager.LastName
--) as InnerTable
--WHERE EmployeeCount = 5;

-- 33. Find the minimal and average employee salary for each department.

--SELECT Name as Department, FORMAT(MIN(Salary),'0.00') as MinimumSalary, Format(AVG (Salary),'0.00') as AverageSalary
--FROM Employees JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID
--GROUP BY Name

-- 34. Find the town with most employees.

--Select TOP 1 Towns.Name AS Town, Count(FirstName) as EmployeeCount
--FROM Employees JOIN Addresses
--ON Employees.AddressID = Addresses.AddressID
--JOIN Towns ON Addresses.TownID = Towns.TownID
--GROUP BY Towns.Name
--ORDER BY EmployeeCount DESC