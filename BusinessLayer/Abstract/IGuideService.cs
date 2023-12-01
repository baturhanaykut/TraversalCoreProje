using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IGuideService : IGenericService<Guide>
    {
        void ChageToTrueByGuide(int id);
        void ChangeToFalseByGuide(int id);
    }
}
