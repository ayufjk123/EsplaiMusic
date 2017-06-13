using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace EsplaiMusic
{
    class dbConnect
    {
        private static SqlConnection conn = null;

        public static SqlConnection openConnection()
        {
            if (conn == null)
            {
                string stringConn = "user id=sad;" + "password=;server=(LocalDb)\\MSSQLLocalDB;" + "Trusted_Connection=yes;" +
                    "database=esplaimusic;" + "connection timeout=30;";

                conn = new SqlConnection(stringConn);

                try
                {
                    conn.Open();
                    return conn;
                }
                catch (Exception e)
                {

                    conn = null;
                    Console.WriteLine(e.ToString());
                    return null;
                }
            }
            else
            {
                return conn;
            }
        }

        public static void closeConnection()
        {
            if (conn != null)
            {
                try
                {
                    conn.Close();
                    conn = null;
                }
                catch (Exception e)
                {
                    conn = null;
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public static SqlConnection getConn()
        {
            return conn;
        }
    }
}
