using COMLETE_ADO_PROject.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_ADO_PROject.Business
{
    public class FavouriteService
    {
        DBContext dBContext;
        public FavouriteService()
        {
            dBContext = new DBContext();
        }

        public int AddFavourite(int userId,int prodId)
        {
            string cmd = $"insert into Favourites (UserId,ProductId) values({userId},{prodId})";
           return  dBContext.ExecuteNonQuery(cmd);

        }
        public DataTable Get_USers_FavProducts(int userId)
        {
            string cmd = $" select  p.ProductId ,p.ProductName from Products as p inner join Favourites\r\non p.ProductId =Favourites.ProductId where userId = {userId} ";
            return  dBContext.Select(cmd) ;
        }
        public DataTable Get_InfoOfFavProd(int user_Id)
        {
            string cmd = $"select Products.ProductId,ProductName,Price,CategoryId from Products\r\njoin Favourites on Products.ProductId=Favourites.ProductId where Favourites.UserId={user_Id}";
            return dBContext.Select(cmd) ;
        }
        public int Delete_Fav_Products (int userId,int ProductId)
        {
            string cmd = $"delete from Favourites where UserId={userId} and ProductId={ProductId}";
            return dBContext.ExecuteNonQuery (cmd);
        }
    }
}
