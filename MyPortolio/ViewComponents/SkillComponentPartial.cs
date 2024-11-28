﻿using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.ViewComponents
{
    public class SkillComponentPartial:ViewComponent
    {
        MyPortfolioContext context =new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values=context.Skills.ToList();
            return View(values);
        }
    }
}
