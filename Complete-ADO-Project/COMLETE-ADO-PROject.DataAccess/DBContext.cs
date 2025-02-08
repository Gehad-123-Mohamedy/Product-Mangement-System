using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMLETE_ADO_PROject.DataAccess
{
    public class DBContext
    {
        SqlConnection SqlConnection;

        // select
       
        public DBContext()
        {
            SqlConnection=new SqlConnection("Server=.\\SQLexpress;Database=ADOPROJECT ;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DataTable Select(string cmd)
        {
            //disconnected
            SqlDataAdapter adapter = new();
            DataTable dt = new();

            //define command
            SqlCommand command = new(cmd, SqlConnection);
        
            // attach adapter
            adapter.SelectCommand = command;

            //get data

            adapter.Fill(dt);


            return dt;

        }


        // insert update delete


        public int ExecuteNonQuery(string cmd)
        {
            //connected mode
            SqlCommand command = new(cmd, SqlConnection);
            int affectedRows = -1;

            try
            {
                //open conn
                SqlConnection.Open();
                affectedRows = command.ExecuteNonQuery();

            }
            catch (Exception ex) {

                throw new Exception(ex.Message);

            }
            finally
            {
                SqlConnection.Close();
            }

            return affectedRows;

        }


    }
}
