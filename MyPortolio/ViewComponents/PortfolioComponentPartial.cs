using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class PortfolioComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
          
    }
}
