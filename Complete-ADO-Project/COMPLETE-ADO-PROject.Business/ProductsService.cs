using COMLETE_ADO_PROject.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_ADO_PROject.Business
{
    public class ProductsService
    {
        DBContext dbcontext;


        public ProductsService()
        {
            dbcontext = new DBContext();
        }
        public DataTable GetProdId_ProdName()
        {
            string cmd = "select ProductId,ProductName from Products";
           DataTable dt=  dbcontext.Select(cmd);
            return dt;

        }
        public DataTable GetAllProducts()
        {
            string cmd = "select  ProductId , ProductName ,Price ,CategoryId from Products";
           return  dbcontext.Select(cmd);
        }
        public int AddNewProduct(string name , decimal price , int categoryId)
        {
            
            string cmd = $"insert into Products (ProductName,Price,CategoryId) values ('{name}',{price},{categoryId})";
            return  dbcontext.ExecuteNonQuery(cmd);

        }
        public int DeleteProduct(int productId) {

            dbcontext.ExecuteNonQuery($"delete from Favourites where ProductId={productId}");
            string cmd = $"delete from Products where ProductId={productId}";
            return  dbcontext.ExecuteNonQuery(cmd);
        
        
        }

        public int ModifyProduct(int productId ,string prodName ,decimal price, int categryId) {
            string cmd = $"update Products set ProductName='{prodName}' , Price={price} , CategoryId={categryId} where ProductId={productId}";

             return dbcontext.ExecuteNonQuery (cmd);


        }
    }
}
