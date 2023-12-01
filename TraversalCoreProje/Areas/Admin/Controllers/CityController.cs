using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            return Json(JsonConvert.SerializeObject(_destinationService.TGetList()));
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            return Json(JsonConvert.SerializeObject(destination));
        }

        
        public IActionResult GetById(int DestinationId)
        {
            return Json(JsonConvert.SerializeObject(_destinationService.TGetById(DestinationId)));
        }

    
        public IActionResult DeleteCity(int id)
        {
            _destinationService.TDelete(_destinationService.TGetById(id));
            return NoContent();
        }

       
        public IActionResult UpdateCity(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return Json(JsonConvert.SerializeObject(destination));
        }

       
    }
}
