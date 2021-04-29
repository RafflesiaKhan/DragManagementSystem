using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entity;
using System.Threading;

namespace UI
{
    public partial class Working : Form
    {
        Connection c = new Connection();
        public Working()
        {
            InitializeComponent();
        }

        private void Owner_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_DemoDataSet.tbl_Drug' table. You can move, or remove it, as needed.
            this.tbl_DrugTableAdapter.Fill(this.pharmacy_DemoDataSet.tbl_Drug);
            // TODO: This line of code loads data into the 'pharmacy_DemoDataSet.tbl_Supplier' table. You can move, or remove it, as needed.
            this.tbl_SupplierTableAdapter.Fill(this.pharmacy_DemoDataSet.tbl_Supplier);
            label_ShowSupID.Visible = false;
            label_ShowSupName.Visible = false;
            label_ShowSupPhn.Visible = false;
            dateTime_Owner.Value = DateTime.Now;
        }

        private void OnSelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                c.Connect();

                string query = "Select sID, sName, sPhone From tbl_Supplier Where sName='" + comboBox_Supplier.Text + "'";
                SqlCommand cmd = new SqlCommand(query, c.Con);
                SqlDataReader reader = cmd.ExecuteReader();

                for (int i = 0; reader.Read(); i++)
                {
                    label_ShowSupID.Visible = true;
                    label_ShowSupID.Text = reader[0].ToString();
                    label_ShowSupName.Visible = true;
                    label_ShowSupName.Text = reader[1].ToString();
                    label_ShowSupPhn.Visible = true;
                    label_ShowSupPhn.Text = reader[2].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.Close();
            }
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            try
            {
                c.Connect();

                SqlCommand cmd = null;
                SqlDataReader reader = null;

                string sQuery = "Select dName, dUnitPrice, dQuantity From tbl_Drug Where dName='" + comboBox_Drug.Text + "'";
                cmd = new SqlCommand(sQuery, c.Con);
                reader = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Load(reader);
                //dataGridView1.DataSource = dt;
                //MessageBox.Show(quantity.ToString());
                int quantity = 0;
                for (int i = 0; reader.Read(); i++)
                {
                    quantity = Convert.ToInt32(reader[2]);
                }
                reader.Close();

                string uQuery = "Update tbl_Drug Set dQuantity=" + (quantity + Convert.ToInt32(comboBox_DrugQuantity.Text)) + " Where dName='" + comboBox_Drug.Text + "'";
                cmd = new SqlCommand(uQuery, c.Con);
                reader = cmd.ExecuteReader();
                reader.Close();

                sQuery = "Select dName, dUnitPrice, dQuantity From tbl_Drug Where dName='" + comboBox_Drug.Text + "'";
                cmd = new SqlCommand(sQuery, c.Con);
                reader = cmd.ExecuteReader();
                //MessageBox.Show(quantity.ToString());
                for (int i = 0; reader.Read(); i++)
                {
                    object[] ob = { reader[0], reader[1], reader[2] };
                    dataGridView_Supply.Rows.Add(ob);
                }
                reader.Close();
                //object[] ob = {"Seclo", 5, 500 };
                //dataGridView1.Rows.Add(ob);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.Close();
            }

        }

        private void OnInquiryClick(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(MyThread.StartInquiry));
            this.Close();
            t.Start();
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(MyThread.StartLogin));
            this.Close();
            t.Start();
        }
    }
}
