using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class TestimonialComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
