using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_dress
{
    internal class DataBase
    {
        static readonly SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6RGBJ3OL;Initial Catalog=magazin;Integrated Security=True;MultipleActiveResultSets=true;");

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            { con.Open(); }
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            { con.Close(); }
        }

        public SqlConnection GetConnection()
        {
            return con;
        }

        public static SqlConnection GetOpenConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6RGBJ3OL;Initial Catalog=magazin;Integrated Security=True;MultipleActiveResultSets=true;");
            con.Open();
            return con;
        }
    }
}

