using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.Controllers
{
    public class TestimonialsController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Testimonial()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
    }
}
