using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfAbout2Dal : GenericRepository<About2>, IAbout2Dal
    {
    }
}
