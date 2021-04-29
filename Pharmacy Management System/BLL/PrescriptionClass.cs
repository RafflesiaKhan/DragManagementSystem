using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BLL
{
    public class PrescriptionClass
    {
        Prescription pres = new Prescription();

        public bool InputPrescription(int pID, int cID, int docID, DateTime pDate,
            string pDisease, int pConfirm)
        {
            return pres.InsertPrescription(pID, cID, docID, pDate, pDisease, pConfirm);
        }

    }
}
