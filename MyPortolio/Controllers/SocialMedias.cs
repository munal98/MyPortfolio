using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyPortolio.DAL.Entities;
using MyPortolio.DAL.Context;
using Newtonsoft.Json.Linq;

namespace MyPortolio.Controllers
{

    public class SocialMedias : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }

    }
}

