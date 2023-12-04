using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(_mapper.Map<List<AnnouncementListDTO>>(_announcementService.TGetList()));
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTO announcementAddDTO)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TAdd(new EntityLayer.Concrete.Announcement()
                {
                    Content = announcementAddDTO.Content,
                    Title = announcementAddDTO.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(announcementAddDTO);
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            _announcementService.TDelete(_announcementService.TGetById(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDTO>(_announcementService.TGetById(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDTO announcementUpdateDTO)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementId = announcementUpdateDTO.AnnouncementId,
                    Title = announcementUpdateDTO.Title,
                    Content = announcementUpdateDTO.Content,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(announcementUpdateDTO);
        }

    }
}
