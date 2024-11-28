using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class HeadComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
