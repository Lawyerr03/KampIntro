select p.ProductName as 'Ürün Adı', SUM(od.UnitPrice*od.Quantity) as 'Kazanılan Toplam Miktar'
from Products as p
inner join [Order Details] as od on p.ProductID = od.ProductID
inner join Orders as o on O.OrderID = od.OrderID
group by p.ProductName
order by SUM(od.UnitPrice*od.Quantity) desc


select p.ProductName as 'Ürün Adı', SUM(od.UnitPrice*od.Quantity) as 'Kazanılan Toplam Miktar'
from Products as p
inner join [Order Details] as od on p.ProductID = od.ProductID
group by p.ProductName
order by [Kazanılan Toplam Miktar] desc