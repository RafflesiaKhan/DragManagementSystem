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
    public partial class MedicalHistory : Form
    {
        public MedicalHistory()
        {
            InitializeComponent();
        }

        private void MedicalHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_DemoDataSet.tbl_MedicalHistory' table. You can move, or remove it, as needed.
            this.tbl_MedicalHistoryTableAdapter.Fill(this.pharmacy_DemoDataSet.tbl_MedicalHistory);

        }

        private void OnBackClick(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(MyThread.StartCustomer));
            this.Close();
            t.Start();
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            try
            {
                Connection c = new Connection();
                c.Connect();

                string query = "Insert Into tbl_MedicalHistory (mID, mDate, mDisease) Values ('" + textBox_mID.Text + "', '" + dateTime_Medic.Value.Date + "', '" + textBox_mDisease.Text + "')";
                SqlCommand cmd = new SqlCommand(query, c.Con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                MessageBox.Show("Medical History Saved Successfully !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
