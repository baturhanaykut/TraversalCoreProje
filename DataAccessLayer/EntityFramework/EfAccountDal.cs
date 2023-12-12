using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfAccountDal : GenericUowRepository<Account>,IAccountDal
    {
        public EfAccountDal(Context context) : base(context)
        {
            
        }
    }
}
