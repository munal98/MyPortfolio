using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
