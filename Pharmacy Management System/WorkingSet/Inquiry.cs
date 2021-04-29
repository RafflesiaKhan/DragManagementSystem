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
    public partial class Inquiry : Form
    {
        Connection c = new Connection();
        public Inquiry()
        {
            InitializeComponent();
        }

        private void OnBackClick(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(MyThread.StartOwner));
            this.Close();
            t.Start();
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            try
            {
                c.Connect();

                string query = "Select dName From tbl_Drug Where dDiscription Like '%" + textBox_Description.Text + "%'";
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
                c.Close();
            }
        }

        private void OnDetailsClick(object sender, EventArgs e)
        {
            try
            {
                c.Connect();

                string query = "Select dID as ID, dName as Name, dMedName as Medical_Name, dDiscription as Discription, dRecDosage as Dosage, dUnitPrice as Unit_Price, dQuantity as Quantity From tbl_Drug Where dName Like '%" + textBox_Medicine.Text + "%'";
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
                c.Close();
            }
        }
    }
}