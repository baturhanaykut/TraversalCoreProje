using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
        public Destination TGetDestinationWithGuide(int id);

        public List<Destination> TGetLast4Destinations();
    }
}
