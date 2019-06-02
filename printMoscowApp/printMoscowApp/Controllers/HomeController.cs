
using Microsoft.AspNetCore.Mvc;
using PrintMoscowApp.Models;

namespace PrintMoscowApp.Controllers
{
	public class HomeController : Controller
	{
		private IProductRepository repository;

		public HomeController(IProductRepository repo)
		{
			repository = repo;
		}
		public ViewResult Index() => View(repository.Products);
	}
}
