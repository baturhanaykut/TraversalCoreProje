using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Fetaure : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
           //ViewBag.image1 = featureManager.ge
            return View();
        }
    }
}
