
using Microsoft.AspNetCore.Mvc;
using PrintMoscowApp.Models;

namespace PrintMoscowApp.Controllers
{
	public class HomeController : Controller
	{
		private ICategoryRepository repository;

		public HomeController(ICategoryRepository repo)
		{
			repository = repo;
		}
		public ViewResult Index() => View(repository.Categories);
	}
}
