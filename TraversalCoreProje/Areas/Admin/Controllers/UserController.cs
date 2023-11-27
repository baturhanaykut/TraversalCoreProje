using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserServices _appUserServices;

        public UserController(IAppUserServices appUserServices)
        {
            _appUserServices = appUserServices;
        }

        public IActionResult Index()
        {
            var values = _appUserServices.TGetList();

            return View(values);
        }

        public IActionResult DeleteUser(int id)
        {
            var values = _appUserServices.TGetById(id);
            _appUserServices.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _appUserServices.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditUser(AppUser   appUser)
        {
            _appUserServices.TUpdate(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommentUser(int id)
        {
            _appUserServices.TGetList();
            return View();
        }

        public IActionResult ReservationUser(int id)
        {
            _appUserServices.TGetList();
            return View();
        }
    }
}
