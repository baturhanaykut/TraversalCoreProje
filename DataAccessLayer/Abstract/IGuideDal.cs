using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IGuideDal:IGenericDal<Guide>
    {
        void ChageToTrueByGuide(int id);
        void ChangeToFalseByGuide(int id);

    }
}
