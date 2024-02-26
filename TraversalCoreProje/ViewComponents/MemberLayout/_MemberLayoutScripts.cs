using Microsoft.AspNetCore.Mvc;
namespace TraversalCoreProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutScripts:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
