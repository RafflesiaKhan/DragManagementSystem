using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Threading;

namespace UI
{
    public partial class Login : Form
    {
        LoginClass lclass = new LoginClass();
        //SqlConnection con;
        public Login()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            string type = lclass.getLogin(textBox_UsrName.Text, textBox_Password.Text);
            
            //this.Close();
            //t.Start();

            switch (type)
            {
                case "Owner":
                    Thread t = new Thread(new ThreadStart(MyThread.StartOwner));
                    this.Close();
                    t.Start();
                    break;

                case "Staff":
                    Thread t2 = new Thread(new ThreadStart(MyThread.StartStaff));
                    this.Close();
                    t2.Start();
                    break;

                case "Customer":
                    Thread t3 = new Thread(new ThreadStart(MyThread.StartCustomer));
                    this.Close();
                    t3.Start();
                    break;

                default:
                    MessageBox.Show("Inset Correctly...", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            ClearField();
        }

        private void ClearField()
        {
            textBox_UsrName.Text = null;
            textBox_Password.Text = null;
        }

    }
}
