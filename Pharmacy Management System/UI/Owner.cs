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
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
            label_ShowSearchResults.Text = null;
            label_ShowSupID.Text = null;
            label_ShowSupName.Text = null;
            label_ShowSupPhn.Text = null;
        }

        private void OnStaffSaveClick(object sender, EventArgs e)
        {
            try
            {
                Connection c = new Connection();
                c.Connect();

                if (textBox_StaffID.Text != null && textBox_StaffName.Text != null && textBox_StaffPhone.Text != null)
                {
                    string query = "Insert into tbl_Staff (aID, aName, aPhone) values('" + textBox_StaffID.Text + "', '"
                        + textBox_StaffName.Text + "', '" + textBox_StaffPhone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, c.Con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    MessageBox.Show("Staff Information Saved Successfully...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();
                }
                else
                {
                    MessageBox.Show("Something went Wrong...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Wrong...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearField();
            }
        }

        private void ClearField()
        {
            #region Staff
            textBox_StaffID.Text = null;
            textBox_StaffName.Text = null;
            textBox_StaffPhone.Text = null;
            #endregion

            #region Drug
            textBox_dID.Text = null;
            textBox_UPC.Text = null;
            textBox_dName.Text = null;
            textBox_dMedName.Text = null;
            textBox_dDesc.Text = null;
            textBox_dDosage.Text = null;
            textBox_UnitPrice.Text = null;
            #endregion
        }

        private void OnDrugEntryClick(object sender, EventArgs e)
        {
            try
            {
                Connection c = new Connection();
                c.Connect();

                if (textBox_dID.Text != null && textBox_UPC.Text != null && textBox_dName.Text != null && textBox_dMedName.Text != null
                    && textBox_dDesc.Text != null && textBox_dDosage.Text != null && textBox_UnitPrice.Text != null)
                {
                    string query = "Insert into tbl_Drug (dID, upc, dName, dMedName, dDiscription, dRecDosage, dUnitPrice) values ("
                                + textBox_dID.Text + ", '" + textBox_UPC.Text + "', '" + textBox_dName.Text + "', '" + textBox_dMedName.Text + "', '"
                                + textBox_dDesc.Text + "', '" + textBox_dDosage.Text + "', " + textBox_UnitPrice.Text + " )";
                    SqlCommand cmd = new SqlCommand(query, c.Con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();

                    MessageBox.Show("Drug Information Saved Successfully...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();
                }

                else
                {
                    MessageBox.Show("Something went Wrong...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Wrong...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearField();
            }
        }

        #region SupplierTab
        private void OnSupplyDrugAdd(object sender, EventArgs e)
        {
            try
            {
                Connection c = new Connection();
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
                    dataGridView_SupplyDrug.Rows.Add(ob);
                }
                reader.Close();
                //object[] ob = {"Seclo", 5, 500 };
                //dataGridView1.Rows.Add(ob);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Wrong...", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnSelectedValueChanged(object sender, EventArgs e)
        {
            #region Supplier
            try
            {
                Connection c = new Connection();
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
                MessageBox.Show("Something went Wrong...", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            if (comboBox_Inquiry.Text == "Most Seeling Medicine")
            {
                Connection c = new Connection();
                c.Connect();

                string query = "select * from dbo.tbl_Drug where dbo.tbl_Drug.dName=(select dName from (select distinct T.dName, T.number_of_orderTime from dbo.tbl_Drug, (select dName, (select count(*) from dbo.tbl_Order where dbo.tbl_Order.dID = dbo.tbl_Drug.dID ) as number_of_orderTime from dbo.tbl_Drug) as T where number_of_orderTime = (select max(number_of_orderTime) from(select dName, (select count(*)from dbo.tbl_Order where dbo.tbl_Order.dID = dbo.tbl_Drug.dID) as number_of_orderTime from dbo.tbl_Drug)as T))as P)";
                SqlCommand cmd = new SqlCommand(query, c.Con);
                SqlDataReader reader = cmd.ExecuteReader();

                string s = null;
                while (reader.Read())
                {
                    s = reader[2].ToString();
                    label_ShowSearchResults.Text = s;
                    //MessageBox.Show(s, "Inquiry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reader.Close();
            }

            if(comboBox_Inquiry.Text == "Most Popular Doctor")
            {
                Connection c = new Connection();
                c.Connect();

                string query = "select * from dbo.tbl_Doctor where docID = (select docID from(select docID,(select count(*) from dbo.tbl_Prescription where pConfirm = docID ) as numberofpatients from dbo.tbl_Doctor) as T where numberofpatients = (select distinct max (numberofpatients) from(select docID,(select count(*) from dbo.tbl_Prescription where pConfirm = docID ) as numberofpatients from dbo.tbl_Doctor) as S))";
                SqlCommand cmd = new SqlCommand(query, c.Con);
                SqlDataReader reader = cmd.ExecuteReader();

                string s = null;
                while (reader.Read())
                {
                    s = reader[1].ToString();
                    label_ShowSearchResults.Text = s;
                    //MessageBox.Show(s, "Inquiry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reader.Close();
            }

            if(comboBox_Inquiry.Text == "Drug with Maximum Quantity")
            {
                Connection c = new Connection();
                c.Connect();

                string query = "Select dName,dQuantity from dbo.tbl_Drug where dQuantity = (Select max(dQuantity) from dbo.tbl_Drug)";
                SqlCommand cmd = new SqlCommand(query, c.Con);
                SqlDataReader reader = cmd.ExecuteReader();

                string s = null;
                while (reader.Read())
                {
                    s = reader[0].ToString();
                    label_ShowSearchResults.Text = s;
                    //MessageBox.Show(s, "Inquiry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reader.Close();
            }
        }
        #endregion

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Thread t = new Thread(new ThreadStart(MyThread.StartLogin));
            t.Start();
        }

        private void Owner_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_DemoDataSet.tbl_Supplier' table. You can move, or remove it, as needed.
            this.tbl_SupplierTableAdapter.Fill(this.pharmacy_DemoDataSet.tbl_Supplier);
            // TODO: This line of code loads data into the 'pharmacy_DemoDataSet.tbl_Drug' table. You can move, or remove it, as needed.
            this.tbl_DrugTableAdapter.Fill(this.pharmacy_DemoDataSet.tbl_Drug);
            // TODO: This line of code loads data into the 'pharmacy_DemoDataSet.tbl_Staff' table. You can move, or remove it, as needed.
            this.tbl_StaffTableAdapter.Fill(this.pharmacy_DemoDataSet.tbl_Staff);

        }

        private void OnInquiryShowClick(object sender, EventArgs e)
        {
            try
            {
                Connection c = new Connection();
                c.Connect();

                string query = "Select cID as ID, cName as Name, cSex as Sex, cCell as Phone From tbl_Customer Where cID='" + textBox_InquirycID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, c.Con);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                reader.Close();
                dataGridView_InquiryCustomer.DataSource = dt;
            }
            catch (Exception ex)
            {
            }
        }

        private void OnInquiryShowMedicineClick(object sender, EventArgs e)
        {
            try
            {
                Connection c = new Connection();
                c.Connect();

                string query = "select sName as Supplier_Name, dName as Drug_Name from dbo.tbl_Supplier, dbo.tbl_Drug where dComID = sID and sName = '"+ textBox_InSupName.Text+ "' order by sName";
                SqlCommand cmd = new SqlCommand(query, c.Con);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                reader.Close();
                dataGridView_InquiryMedicine.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
