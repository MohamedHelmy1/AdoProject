using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AplicationDbContext
    {
        SqlConnection con;
        public AplicationDbContext()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=AdoEccomerce;Integrated Security=True;trustServerCertificate=true;");
        }
        public DataTable ExecuteQuery(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand=new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
           
        }
        public int ExecuteNoQuery(string sql) { 
        
            SqlCommand cmd = new SqlCommand(sql, con);
            int rowaffected = 0;
            try
            {
                con.Open();
                rowaffected= cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();

            }
            return rowaffected;
        }
    }
}
