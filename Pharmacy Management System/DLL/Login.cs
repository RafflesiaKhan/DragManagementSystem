using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;

namespace DLL
{
    public class Login
    {
        public string LoginCheck(string usrname, string password)
        {
            Connection c = new Connection();
            //SqlConnection con = c.Con;
            try
            {
                c.Connect();
                string query = "SELECT acType FROM tbl_Account WHERE acName = '" + usrname + "' and acPassword = '" + password + "'";
                SqlCommand cmd = new SqlCommand(query, c.Con);
                SqlDataReader reader = cmd.ExecuteReader();
                string type = null;
                for (int i = 0; reader.Read(); i++)
                {
                    type = reader[0].ToString();
                    //MessageBox.Show(type);
                }
                reader.Close();
                if (type == "Owner" || type == "Customer" || type == "Staff")
                    return type;
                else
                    return "Error";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
