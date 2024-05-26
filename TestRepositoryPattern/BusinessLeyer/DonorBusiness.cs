using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRepositoryPattern.BusinessLeyer;
using TestRepositoryPattern.DataAccessLeyer;

namespace TestRepositoryPattern.BusinessLeyer
{
    public class DonorBusiness
    {
        IDonorRepository _repository;

        public DonorBusiness(IDonorRepository repository)
        {
            _repository = repository;
        }

        public List<Donor> Get()
        {
            return _repository.Get();
        }

        public Donor Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Add(Donor SN)
        {
            return _repository.Add(SN);
        }

        public bool Update(Donor SN)
        {
            return _repository.Update(SN);
        }

        public bool Delete(int Donorid)
        {
            return _repository.Delete(Donorid);
        }
    }
}
