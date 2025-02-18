select  p.ProductId ,p.ProductName from Products as p inner join Favourites
on p.ProductId =Favourites.ProductId where userId =2

