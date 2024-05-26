using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryPattern.DataAccessLeyer
{
    public interface IDonorRepository
    {
        List<Donor> Get();
        Donor Get(int Donorid);
        bool Add(Donor SN);
        bool Update(Donor SN);
        bool Delete(int Donorid);
    }
}
