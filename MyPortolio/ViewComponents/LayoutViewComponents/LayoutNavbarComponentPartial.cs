using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.ViewComponents.LayoutViewComponents
{
	public class LayoutNavbarComponentPartial:ViewComponent
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.ToDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
			var values=context.ToDoLists.Where(x=>x.Status == false).ToList();
			return View(values);
		}
	}
}
