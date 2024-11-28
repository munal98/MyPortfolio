using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
