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


--En Önemli SQL Komutlarından Bazıları
--SELECT- bir veritabanından veri ayıklar
--UPDATE- bir veritabanındaki verileri günceller
--DELETE- veri tabanından verileri siler
--INSERT INTO- bir veritabanına yeni veriler ekler
--CREATE DATABASE- yeni bir veritabanı oluşturur
--ALTER DATABASE- bir veritabanını değiştirir
--CREATE TABLE- yeni bir tablo oluşturur
--ALTER TABLE- bir tabloyu değiştirir
--DROP TABLE- bir tabloyu siler
--CREATE INDEX- bir dizin oluşturur (arama anahtarı)
--DROP INDEX- bir dizini siler

--""""WHERE Maddesindeki Operatörler"""""
--=	Equal	
-->	Greater than	
--<	Less than	
-->=	Greater than or equal	
--<=	Less than or equal	
--<>	Not equal. Note: In some versions of SQL this operator may be written as !=	
--BETWEEN	Between a certain range	
--LIKE	Search for a pattern	
--IN	To specify multiple possible values for a column


select p.ProductName as 'Ürün Adı', SUM(od.UnitPrice*od.Quantity) as 'Kazanılan Toplam Miktar'
from Products as p
inner join [Order Details] as od on p.ProductID = od.ProductID
inner join Orders as o on O.OrderID = od.OrderID
group by p.ProductName
order by SUM(od.UnitPrice*od.Quantity) desc