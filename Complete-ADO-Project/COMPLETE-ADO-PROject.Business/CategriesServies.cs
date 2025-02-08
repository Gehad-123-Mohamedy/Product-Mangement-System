using COMLETE_ADO_PROject.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_ADO_PROject.Business
{
    public class CategriesServies
    {
        DBContext dBContext;
        ProductsService productsService;
        public CategriesServies()
        {
            dBContext = new DBContext();
            productsService = new ProductsService();
        }

        public DataTable Get_Categories()
        {
            string cmd = "select CategoryId ,CategoryName from Categories";
            return  dBContext.Select(cmd);
                
        }

        public int AddCategory(string categoryName) {

            string cmd = $"insert into Categories (CategoryName) values ('{categoryName}')";
            return dBContext.ExecuteNonQuery(cmd);
        }

        public int updateCategories(int id ,string CategoryName)
        {
            string cmd = $"update  Categories set CategoryName='{CategoryName}' where CategoryId ={id}";
            return dBContext.ExecuteNonQuery(cmd);
        }

        public int DeleteCategories(int id)
        {
            string favourite = $@"
        DELETE FROM Favourites
        WHERE ProductId IN (SELECT ProductId FROM Products WHERE CategoryId = {id})";
            dBContext.ExecuteNonQuery(favourite);
            dBContext.ExecuteNonQuery($"delete from Products where CategoryId={id}");
            string cmd = $"delete from Categories where CategoryId={id}";
            return dBContext.ExecuteNonQuery(cmd);
        }

    }
}
