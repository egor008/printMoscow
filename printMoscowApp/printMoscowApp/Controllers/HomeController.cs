
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
		public FileContentResult GetImage(Category item)
		{
			Category category = repository.Categories
				.FirstOrDefault(g => g.Id == item.Id);

			if (category != null)
			{
				return File(category.CategoryImage, category.ImageMimeType);
			}
			else
			{
				return null;
			}
		}
		public FileContentResult GetImageOffer(WhatDoWeOffer item)
		{
			WhatDoWeOffer offer = offerRepository.Offers
				.FirstOrDefault(g => g.Id == item.Id);

			if (offer != null)
			{
				return File(offer.Image, offer.ImageMimeType);
			}
			else
			{
				return null;
			}
		}
		public FileContentResult GetImageType(TypesOfPrinting item)
		{
			TypesOfPrinting type = typeRepository.Types
				.FirstOrDefault(g => g.Id == item.Id);

			if (type != null)
			{
				return File(type.Image, type.ImageMimeType);
			}
			else
			{
				return null;
			}
		}
		public FileContentResult GetImageTeam(OurTeam item)
		{
			OurTeam team = teamRepository.Teams
				.FirstOrDefault(g => g.Id == item.Id);

			if (team != null)
			{
				return File(team.Image, team.ImageMimeType);
			}
			else
			{
				return null;
			}
		}
	}
}
