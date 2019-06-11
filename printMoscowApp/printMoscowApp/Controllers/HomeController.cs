
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PrintMoscowApp.Models;
using PrintMoscowApp.Models.ViewModels;

namespace PrintMoscowApp.Controllers
{
	public class HomeController : Controller
	{
		private ICategoryRepository repository;
		private IOurTeamRepository teamRepository;
		private IWhatDoWeOfferyRepository offerRepository;
		private ITypesOfPrintingRepository typeRepository;

		public HomeController(
			ICategoryRepository repo,
			IOurTeamRepository teamRepo,
			IWhatDoWeOfferyRepository offerRepo,
			ITypesOfPrintingRepository typeRepo)
		{
			repository = repo;
			teamRepository = teamRepo;
			offerRepository = offerRepo;
			typeRepository = typeRepo;
		}
		public ViewResult Index()
		{
			var offer = offerRepository.Offers.ToArray();
			var type = typeRepository.Types.ToArray();
			var team = teamRepository.Teams.ToArray();
			var category = repository.Categories.OrderBy(x => x.Price);

			var t = new HomeViewModel
			{
				Offer = offer,
				Team = team,
				Type = type,
				Categories = category
			};

			return View(t);
		}
	}
}
