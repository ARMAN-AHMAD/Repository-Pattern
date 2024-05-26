using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryPattern.DataAccessLeyer
{
    public class DonorRepository : IDonorRepository
    {
        List<Donor> listDonor = new List<Donor>()
        {
            new Donor(1, "Fahim", "Manikganj"),
            new Donor(2, "Omar", "Dinajpur"),
            new Donor(3, "Monir", "Tangail"),
            new Donor(4, "Joy", "Pabna")
        };
        public List<Donor> Get()
        {
            return listDonor.OrderBy(x => x.DonorName).ToList();
        }

        public Donor Get(int Donorid)
        {
            Donor oDonor = listDonor.Where(x => x.DonorId == Donorid).FirstOrDefault();
            return oDonor;
        }

        public bool Add(Donor SN)
        {
            listDonor.Add(SN);
            return true;
        }

        public bool Update(Donor SN)
        {
            bool isExecuted = false;
            Donor oDonor = listDonor.Where(x => x.DonorId == SN.DonorId).FirstOrDefault();
            if (oDonor != null)
            {
                listDonor.Remove(oDonor);
                listDonor.Add(SN);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete(int Donorid)
        {
            bool isExecuted = false;
            Donor oDonor = listDonor.Where(x => x.DonorId == Donorid).FirstOrDefault();
            if (oDonor != null)
            {
                listDonor.Remove(oDonor);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
