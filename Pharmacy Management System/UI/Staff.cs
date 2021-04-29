using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
using System.Data.SqlClient;
using System.Threading;

namespace UI
{
    public partial class Staff : Form
    {
        PrescriptionClass pClass = new PrescriptionClass();
        DrugsClass dClass = new DrugsClass();
        public Staff()
        {
            InitializeComponent();

            for (int i = 1; i <= 500; i++)
            {
                comboBox_DrugQuantity.Items.Add(i);
            }
        }

        private void OnProceedClick(object sender, EventArgs e)
        {
            int pID = 0, cID = 0, docID = 0;
            DateTime pDate = DateTime.Today;
            string pDisease = null;
            int pConfirm = 0;

            if (radioButton_Accept.Checked)
            {
                pConfirm = 1;
                getPrescription(ref pID, ref cID, ref docID, ref pDate, ref pDisease);

                bool isInsert = pClass.InputPrescription(pID, cID, docID, pDate, pDisease, pConfirm);
                if (isInsert)
                {
                    MessageBox.Show("Prescription information Saved Successfully...", "Info"
                      , MessageBoxButtons.OK, MessageBoxIcon.Information); ClearField();
                }
                else
                {
                    MessageBox.Show("Something went Wrong...", "Error Message"
                      , MessageBoxButtons.OK, MessageBoxIcon.Error); ClearField();
                }
            }
            if (radioButton_Decline.Checked)
            {
                pConfirm = 0;
                MessageBox.Show("Declined", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearField();
            }
        }

        private void OnOrderClick(object sender, EventArgs e)
        {

        }

        private void getPrescription(ref int pID, ref int cID, ref int docID, ref DateTime pDate, ref string pDisease)
        {
            pID = Convert.ToInt32(textBox_pID.Text);
            cID = Convert.ToInt32(textBox_cID.Text);
            docID = Convert.ToInt32(textBox_docID.Text);

            pDate = dateTime_Prescription.Value;
            //MessageBox.Show(pDate.ToString());
            pDisease = textBox_Disease.Text;
        }



        private void ClearField()
        {
            #region Prescription
            textBox_pID.Text = null;
            textBox_cID.Text = null;
            textBox_docID.Text = null;
            dateTime_Prescription.Value = DateTime.Today;
            textBox_Disease.Text = null;
            radioButton_Accept.Checked = false;
            radioButton_Decline.Checked = false;
            #endregion

            #region MedicalHistory
            textBox_mID.Text = null;
            textBox_mDisease.Text = null;
            dateTime_Medic.Value = DateTime.Today;
            #endregion

        }

        private void OnMedicSaveClick(object sender, EventArgs e)
        {
            Connection c = new Connection();
            try
            {
                if (textBox_mID.Text != null && textBox_mDisease.Text != null)
                {
                    c.Connect();

                    string query = "Insert Into tbl_MedicalHistory (mID, mDate, mDisease) Values ('" + textBox_mID.Text + "', '" + dateTime_Medic.Value.Date + "', '" + textBox_mDisease.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, c.Con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    MessageBox.Show("Medical History Saved Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Something went Wrong...", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Wrong...", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.Close();
                ClearField();
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_DemoDataSet.tbl_Drug' table. You can move, or remove it, as needed.
            this.tbl_DrugTableAdapter.Fill(this.pharmacy_DemoDataSet.tbl_Drug);
            // TODO: This line of code loads data into the 'pharmacy_DemoDataSet.tbl_MedicalHistory' table. You can move, or remove it, as needed.
            this.tbl_MedicalHistoryTableAdapter.Fill(this.pharmacy_DemoDataSet.tbl_MedicalHistory);

        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Thread t = new Thread(new ThreadStart(MyThread.StartLogin));
            t.Start();
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            try
            {
                Connection c = new Connection();
                c.Connect();

                string query = "Select dID as ID, dName as Name, dMedName as Medical_Name, dDiscription as Discription, dRecDosage as Dosage, dUnitPrice as Unit_Price From tbl_Drug Where dDiscription Like '%" + textBox_SearchDescription.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, c.Con);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable("Drug Name");
                dt.Load(reader);
                dataGridView_Inquary.DataSource = dt;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnDetailsClick(object sender, EventArgs e)
        {
            try
            {
                Connection c = new Connection();
                c.Connect();

                string query = "Select dID as ID, dName as Name, dMedName as Medical_Name, dDiscription as Discription, dRecDosage as Dosage, dUnitPrice as Unit_Price, dQuantity as Quantity From tbl_Drug Where dName Like '%" + textBox_SearchMedicine.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, c.Con);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable("Drug Name");
                dt.Load(reader);
                dataGridView_Inquary.DataSource = dt;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Purchase
        private void OnAddClick(object sender, EventArgs e)
        {
            try
            {
                Connection c = new Connection();
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
                #endregion

                int customerQuantity = Convert.ToInt32(comboBox_DrugQuantity.Text);
                int totalPrice = UnitPrice * customerQuantity;

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

                //Connection c = new Connection();
                //c.Connect();

                string query = "Insert Into tbl_Purchase (Customer_ID, Drug_Name) values ('" + textBox_PurchasecId.Text + "', '" + comboBox_Drug.Text + "')";
                cmd = new SqlCommand(query, c.Con);
                reader = cmd.ExecuteReader();
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Wrong...", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnSavePurchageClick(object sender, EventArgs e)
        {
            try
            {
                Connection c = new Connection();
                c.Connect();

                string query = "Insert Into tbl_Purchase (Customer_ID, Drug_Name) values ('" + textBox_PurchasecId.Text + "', '" + comboBox_Drug.Text + "')";
                SqlCommand cmd = new SqlCommand(query, c.Con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();


            }
            catch (Exception ex)
            {
            }
        }
        #endregion

        private void OnOrderSearchClick(object sender, EventArgs e)
        {
            try
            {
                Connection c = new Connection();
                c.Connect();

                string query = "select distinct tbl_Order.cID as Customer_ID, tbl_Drug.dName as Drug_Name, oQuantity as Quantity, dUnitPrice as Unit_Price from tbl_Customer, tbl_Drug, tbl_Order Where oDate = '04/23/2016' and tbl_Order.cID = 'C00001' and tbl_Order.dID = tbl_Drug.dID";
                SqlCommand cmd = new SqlCommand(query, c.Con);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView_Searchorder.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage_Purchage_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Subtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox_PurchasecId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_Sell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_DrugQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Drug_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tblDrugBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_PurchasecSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox_PurchasecContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox_PurchasecName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void dateTime_Customer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage_Prescription_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton_Accept_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Decline_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Disease_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTime_Prescription_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_docID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_cID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_pID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_MedicalHistory_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tblMedicalHistoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBox_mDisease_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void textBox_mID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void dateTime_Medic_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage_Search_Click(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void textBox_SearchMedicine_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_Inquary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void textBox_SearchDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage_Order_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
