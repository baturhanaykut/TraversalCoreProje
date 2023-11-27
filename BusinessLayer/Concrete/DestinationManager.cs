using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public Destination TGetById(int id)
        {
           return _destinationDal.GetById(id);
        }

        public List<Destination> TGetList()
        {
           return _destinationDal.GetList();
        }

        public void TUpdate(Destination t)
        {
            _destinationDal.Update(t);
        }
    }
}
