using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BLL
{
    public class DrugsClass
    {
        Drugs d = new Drugs();
        public bool EntryDrug(int dID,
        string UPC, string Name, string medName, string Description, string Dosage,
        double UnitPrice)
        {
            return d.EntryDrug(dID, UPC, Name, medName, Description, Dosage, UnitPrice);
        }
    }
}
