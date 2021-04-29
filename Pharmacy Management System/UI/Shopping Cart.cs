using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Shopping_Cart : Form
    {
        public Shopping_Cart()
        {
            InitializeComponent();

            label_ShowCustomerId.Text = null;
            label_ShowCustomerName.Text = null;
        }

        private void OnCheckOutClick(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(MyThread.StartCustomer));
            this.Close();
            t.Start();
        }
    }
}
