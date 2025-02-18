select Products.ProductId,ProductName,Price,CategoryId from Products
join Favourites on Products.ProductId=Favourites.ProductId where Favourites.UserId=2021

select * from Favourites
select * from Products
select * from Users