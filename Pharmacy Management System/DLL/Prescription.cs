using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;

namespace DLL
{
    public class Prescription
    {

        public bool InsertPrescription(int pID, int cID, int docID, DateTime pDate, 
            string pDisease, int pConfirm)
        {
            Connection c = new Connection();

            try
            {
                c.Connect();
                
                string query = "Insert into tbl_Prescription (pID, cID, docID, pDate, pDisease, pConfirm) values (" 
                    + pID + ", " + cID + ", " + docID + ", '" + pDate + "', '" 
                    + pDisease + "', " + pConfirm + ")";
                SqlCommand cmd = new SqlCommand(query,c.Con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
