using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Customer : Form
    {
        Connection c = new Connection();
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_DemoDataSet.tbl_Drug' table. You can move, or remove it, as needed.
            this.tbl_DrugTableAdapter.Fill(this.pharmacy_DemoDataSet.tbl_Drug);

            for (int i = 1; i <= 500; i++)
            {
                comboBox_DrugQuantity.Items.Add(i);
            }

        }

        private void OnAddClick(object sender, EventArgs e)
        {
            try
            {
                c.Connect();

                SqlCommand cmd = null;
                SqlDataReader reader = null;

                #region getQuantity
                string QuantityQuery = "Select dQuantity From tbl_Drug Where dName = '" + comboBox_Drug.Text + "'";
                cmd = new SqlCommand(QuantityQuery, c.Con);
                reader = cmd.ExecuteReader();
                int totalQuantity = 0;
                while (reader.Read())
                {
                    totalQuantity = Convert.ToInt32(reader[0]);
                }
                reader.Close();
                //MessageBox.Show(quantity.ToString());
                #endregion

                #region getUnitPrice
                string PriceQuery = "Select dUnitPrice From tbl_Drug Where dName = '" + comboBox_Drug.Text + "'";
                cmd = new SqlCommand(PriceQuery, c.Con);
                reader = cmd.ExecuteReader();
                int UnitPrice = 0;
                while (reader.Read())
                {
                    UnitPrice = Convert.ToInt32(reader[0]);
                }
                reader.Close();
                //MessageBox.Show(UnitPrice.ToString()); 

                #endregion

                int customerQuantity = Convert.ToInt32(comboBox_DrugQuantity.Text);
                int totalPrice = UnitPrice * customerQuantity;

                //textBox_Subtotal.Text = subtotal.ToString();
                //MessageBox.Show(totalPrice.ToString());

                object[] ob = { comboBox_Drug.Text, customerQuantity, UnitPrice, totalPrice };
                dataGridView_Sell.Rows.Add(ob);

                #region updateData
                string updateQuery = "Update tbl_Drug Set dQuantity = " + (totalQuantity - customerQuantity) + " Where dName = '" + comboBox_Drug.Text + "'";
                cmd = new SqlCommand(updateQuery, c.Con);
                reader = cmd.ExecuteReader();
                reader.Close();
                #endregion

                int sum = 0;
                for (int i = 0; i < dataGridView_Sell.Rows.Count; i++)
                {
                    sum += (int)dataGridView_Sell.Rows[i].Cells[3].Value;
                }
                textBox_Subtotal.Text = sum.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.Close();
            }
        }
        
        private void OnSaveInfoClick(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(MyThread.StartStaff));
            this.Close();
            t.Start();
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Thread t = new Thread(new ThreadStart(MyThread.StartLogin));
            t.Start();
        }

        private void OnCheckOutClick(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(MyThread.StartShoppingCart));
            this.Close();
            t.Start();
        }
    }
}
