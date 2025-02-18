select  Username,Age,ProductName as FavProduct ,Users.UserId ,Role  from Users  
join Favourites  on Users.UserId =Favourites.UserId join Products on Favourites.ProductId=Products.ProductId
 where Role='user'

delete from Favourites where UserId=2021
delete from Users where UserId=2021