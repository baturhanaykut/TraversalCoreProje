using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfFeature2Dal:GenericRepository<Feature2>,IFeature2Dal
    {
    }
}
