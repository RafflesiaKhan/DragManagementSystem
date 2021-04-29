using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    class MyThread
    {

        public static void StartLogin()
        {
            Application.Run(new Login());
        }
        public static void StartStaff()
        {
            Application.Run(new Staff());
        }

        public static void StartOwner()
        {
            Application.Run(new Owner());
        }

        public static void StartCustomer()
        {
            Application.Run(new Customer());
        }

        public static void StartShoppingCart()
        {
            Application.Run(new Shopping_Cart());
        }
    }
}
