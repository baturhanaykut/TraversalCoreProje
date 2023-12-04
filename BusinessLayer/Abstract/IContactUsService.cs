using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IContactUsService : IGenericService<ContactUS>
    {
        List<ContactUS> TGetListContactUsByTrue();
        List<ContactUS> TGetListContactUsByFalse();

        void TContactUsStatusChangeFalse(int id);
    }
}
