using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class ConnectionFactory
    {
        private string strconn = "server=USER-PC\\SQLEXPRESS;database=FASHIONSHOP;Integrated Security=true;";
        private SqlConnection sqlconn =null;
        public ConnectionFactory()
        {
            sqlconn = new SqlConnection(strconn);
        }
        public void OpenConnection()
        {
            if (sqlconn.State == ConnectionState.Closed)
                sqlconn.Open();
        }
        public void CloseConnection()
        {
            if (sqlconn.State == ConnectionState.Open)
                sqlconn.Close();
        }
        public SqlDataReader GetData(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = sqlconn;
            OpenConnection();
            SqlDataReader da = cmd.ExecuteReader();
            return da;
        }
        public int GetCount(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = sqlconn;
            OpenConnection();
            object o = cmd.ExecuteScalar();
            return (int)(o);
        }



    }
}