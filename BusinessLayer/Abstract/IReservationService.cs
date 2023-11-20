using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListWithReservationByWaittApproval(int id);
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
    }
}
