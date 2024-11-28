using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
