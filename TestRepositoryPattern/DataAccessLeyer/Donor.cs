using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryPattern.DataAccessLeyer
{
    public class Donor
    {
        public int DonorId;
        public string DonorName;
        public string DonorAddress;
        public Donor()
        {
        }
        public Donor(int Donorid, string Donorname, string Donoraddress)
        {
            DonorId = Donorid;
            DonorName = Donorname;
            DonorAddress = Donoraddress;
        }
    }
}
