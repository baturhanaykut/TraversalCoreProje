using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonailManager testimonailManager = new TestimonailManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonailManager.TGetList();
            return View(values);
        }
    }
}
