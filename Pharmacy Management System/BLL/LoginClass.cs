using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using DLL;

namespace BLL
{
    public class LoginClass
    {
        Login log = new Login();
        public string getLogin(string usrname, string password)
        {
            return log.LoginCheck(usrname, password);
        }
    }
}
