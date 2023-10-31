using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Newsletter
    {
        [Key]
        public int NewsletterId { get; set; }

        public string Mail { get; set; }
    }
}
