using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContactUS>, IContactUsDal
    {
     
        public void ContactUsStatusChangeFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUS> GetListContactUsByFalse()
        {
            using (var context = new Context())
            {
                return context.ContactUses.Where(x => x.MessageStatus == false).ToList();
            }
        }

        public List<ContactUS> GetListContactUsByTrue()
        {
            using (var context = new Context())
            {
                return context.ContactUses.Where(x => x.MessageStatus == true).ToList();
            }
        }
    }
}
