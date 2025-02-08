using COMLETE_ADO_PROject.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_ADO_PROject.Business
{
    public class UsersService
    {
        DBContext dbcontext;

        public UsersService()
        {
            dbcontext = new DBContext();

        }

        // select 
        public DataTable getRole( string username , string  password)
        {
            string cmd = $"select Role ,UserId from Users where username='{username}' and  Password='{password}'";
            DataTable dt =dbcontext.Select(cmd);
            return dt;
        }

        // insert
        public int AddUser( string Username, string Password,string Email,string Address,int Age, string role)
        {
            string cmd = $"insert into Users (Username,Password, Email,Address,Age ,Role) Values('{Username}' ,'{Password}','{Email}','{Address}',{Age},'{role}')";
            return dbcontext.ExecuteNonQuery(cmd);
        }

        public DataTable GetUsersInfo()
        {
            string cmd = "select Username,Age,Users.UserId,ProductName as FavProduct ,Role  from Users  join Favourites  on Users.UserId =Favourites.UserId join Products on Favourites.ProductId=Products.ProductId\r\n where Role='user'";
            return dbcontext.Select(cmd);
        }
        public int DeleteUser(int userid)
        {
            string c1 = $"delete from Favourites where UserId={userid}";
            string cmd = $"delete from Users where UserId={userid}";
            return dbcontext.ExecuteNonQuery(cmd);
        }

    }
}
