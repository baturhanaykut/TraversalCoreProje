namespace BusinessLayer.Abstract.AbstractUow
{
    public interface IGenercinUowService<T>
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TMultiUpdate(List<T> t);
        T TGetById(int id);
    }
}
