select * from Categories
select * from Favourites
select * from Products
delete from Products where ProductId=113
delete from Favourites where ProductId=113
delete from Products where ProductId=1111
delete from Favourites where ProductId=1111
insert into Categories (CategoryName) values ('Foods')
update  Categories set CategoryName='Accessory' where CategoryId =102
delete from Categories where CategoryId=106
 DELETE FROM Favourites
    WHERE ProductId IN (SELECT ProductId FROM Products WHERE CategoryId =103)