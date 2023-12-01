using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void ChageToTrueByGuide(int id)
        {
            _guideDal.ChageToTrueByGuide(id);
        }

        public void ChangeToFalseByGuide(int id)
        {
            _guideDal.ChangeToFalseByGuide(id);
        }

        public void TAdd(Guide t)
        {
            _guideDal.Insert(t);
        }

        public void TDelete(Guide t)
        {
            _guideDal.Delete(t);
        }

        public Guide TGetById(int id)
        {
            return _guideDal.GetById(id);
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetList();
        }

        public void TUpdate(Guide t)
        {
            _guideDal.Update(t);
        }
    }
}
