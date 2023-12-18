using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TAdd(ContactUS t)
        {
            _contactUsDal.Insert(t);
        }

        public void TContactUsStatusChangeFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUS t)
        {
            throw new NotImplementedException();
        }

        public ContactUS TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUS> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public List<ContactUS> TGetListContactUsByFalse()
        {
            return _contactUsDal.GetListContactUsByFalse();
        }

        public List<ContactUS> TGetListContactUsByTrue()
        {
            return _contactUsDal.GetListContactUsByTrue();
        }

        public void TUpdate(ContactUS t)
        {
            throw new NotImplementedException();
        }
    }
}
