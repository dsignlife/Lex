--6. Give the title and name of employees who have sold at least one of the products ‘Gravad Lax’ or ‘Mishi Kobe Niku’. 

use NORTHWND
select distinct e.Title, e.FirstName
from Orders o
inner join [Order Details] od
on o.OrderID = od.OrderID
inner join Products p
on od.ProductID = p.ProductID
inner join Employees e
on o.EmployeeID = e.EmployeeID

where p.ProductName = 'Gravad Lax' or p.ProductName = 'Mishi Kobe Niku'
;