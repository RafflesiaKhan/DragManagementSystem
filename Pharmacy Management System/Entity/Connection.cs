using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entity
{
    public class Connection
    {
        SqlConnection con;

        public SqlConnection Con
        {
            get
            {
                return con;
            }
        }

        public void Connect()
        {
            String conString = @"Data Source=RILUS-PC\SQLEXPRESS;Initial Catalog=Pharmacy_Demo;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con = new SqlConnection(conString);
            con.Open();
        }

        public void Close()
        {
            con.Close();
        }
    }
}
