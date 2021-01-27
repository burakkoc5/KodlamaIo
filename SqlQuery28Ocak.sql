--Select
--Select ContactName Adi,Phone Telefonu,City Sehri from Customers

--Select * from Customers where City = 'London'

--Case insensitive
Select * from Products where CategoryID = 1 or CategoryID = 3

Select * from Products where CategoryID = 1 and UnitPrice >= 10

SELECT * from Products where categoryId= 3 order by UnitPrice desc -- ascending = artan -- descending = azalann

Select categoryId,count(*) Adet from products where UnitPrice>20
group by CategoryID having count(*)<10



--inner join sadece 2 tabloda eşleşenleri getirir
select Products.ProductID,Products.ProductName,Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10
--DTO Data Transformation Object

--left join solda olup sağda olmayanları da getir
select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o on o.OrderID = od.OrderID

Select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null








