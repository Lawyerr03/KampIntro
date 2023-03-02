--Select (çalıştırmak stediğimiz kodu seçiyoruz) 
--ANSII
Select ContactName Adi,CompanyName Şirketadi,City Sehir from Customers -- bir tablo oluşturuyoruz !!

Select * from Customers where City = 'Berlin'

-- case insensitive (Büyük küçük harf duyarsız)
Select * from Products where CategoryID =1 or CategoryID = 3  -- or yada

select * from Products where CategoryID =1 and UnitPrice >= 10 -- and ve

select * from Products order by ProductName -- order by sırala

select * from Products order by UnitPrice asc -- fiyata göre sırala -- ascending (artan)

select * from Products order by UnitPrice desc -- descending (azalan)

select * from Products where CategoryID=1 order by UnitPrice desc

select * from Products order by CategoryID,ProductName -- v,rgül koyunca önce ilk sıralama sonra onlarıda kendi içide sırala diyoruz

select count(*) from Products -- tüm satırların sayısını ver (count =adet)

select count(*) Adet from Products where CategoryID=2

-- hangi kategoride kaç farklı ürün var ??

select categoryID,count (*) from Products group by CategoryID -- her bir gurup için arka planda bir grup oluşturuluyor

--ürün sayısı 10 dan az olan ürünleri listele

select categoryID,count (*) from Products group by CategoryID  having count (*) <10  

-- datayı filtelemek için 

select categoryID,count (*) from Products where UnitPrice>20 group by CategoryID  having count (*) <10  


-- join = birleştirmek

select Products.ProductID, Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10
-- koşulu on ile yazarsın -- "inner join" sadece eşleşen dataları bir araya getirir eşleşmeyenleri getirmez

--DTO Data Transformation object

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

-- left solda olup sağda olmayanlarıda getir demek

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

-- is null o data yok demek