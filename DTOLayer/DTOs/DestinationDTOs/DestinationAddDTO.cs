using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.DestinationDTOs
{
    public class DestinationAddDTO
    {
        public string City { get; set; }
        public string DayNight { get; set; }
        public Double Price { get; set; }
        public int Capacity { get; set; }
    }
}
