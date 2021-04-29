using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;

namespace DLL
{
    public class Drugs
    {
        public bool EntryDrug(int dID,
        string UPC, string Name, string medName, string Description, string Dosage,
        double UnitPrice)
        {
            Connection c = new Connection();

            try
            {
                c.Connect();

                string query = "Insert into tbl_Drug (dID, upc, dName, dMedName, dDiscription, dRecDosage, dUnitPrice) values ("
                    + dID + ", '" + UPC + "', '" + Name + "', '" + medName + "', '"
                    + Description + "', '" + Dosage + "', "+ UnitPrice +" )";
                SqlCommand cmd = new SqlCommand(query, c.Con);
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
