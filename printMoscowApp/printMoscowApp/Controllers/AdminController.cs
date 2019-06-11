using Microsoft.AspNetCore.Mvc;
using PrintMoscowApp.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Collections.Generic;
using PrintMoscowApp.Models.ViewModels;

namespace PrintMoscowApp.Controllers
{

    [Authorize]
    public class AdminController : Controller
    {
        private IProductRepository repository;
        private ICategoryRepository categoryRepository;
		private IOurTeamRepository teamRepository;
		private IWhatDoWeOfferyRepository offerRepository;
		private ITypesOfPrintingRepository typeRepository;

		public AdminController(
			IProductRepository repo,
			ICategoryRepository categoryRepo,
			IOurTeamRepository teamRepo,
			IWhatDoWeOfferyRepository offerRepo,
			ITypesOfPrintingRepository typeRepo
			)
        {
            repository = repo;
            categoryRepository = categoryRepo;
			teamRepository = teamRepo;
			offerRepository = offerRepo;
			typeRepository = typeRepo;
        }

        public ViewResult Index() => View(repository.Products);
		public ViewResult CategoryList() => View(categoryRepository.Categories);
		public ViewResult InformationList() {
			var offer = offerRepository.Offers.ToArray();
			var type = typeRepository.Types.ToArray();
			var team = teamRepository.Teams.ToArray();

			var t = new InformationListViewModel {
			Offer = offer,
			Team = team,
			Type = type
			};

			return View(t);
		} 


		public ViewResult Edit(int productId) =>
            View(repository.Products
                .FirstOrDefault(p => p.ProductID == productId));

		public ViewResult EditCategory(int categoryId)
		{
			var category = categoryRepository.Categories.Where(p => p.Id == categoryId).FirstOrDefault();
			var t = new CategoryEditViewModel
			{
				Category = category
			};
			return View(t);
		}

		public ViewResult EditWhatDoWeOffer(int offerId)
		{
			var offer = offerRepository.Offers.Where(p => p.Id == offerId).FirstOrDefault();
			var t = new OfferEditViewModel
			{
				Offer = offer
			};
			return View(t);
		}
		public ViewResult EditTypesOfPrinting(int typeId)
		{
			var type = typeRepository.Types.Where(p => p.Id == typeId).FirstOrDefault();
			var t = new TypeEditViewModel
			{
				Type = type
			};
			return View(t);
		}
		public ViewResult EditOurTeam(int teamId)
		{
			var team = teamRepository.Teams.Where(p => p.Id == teamId).FirstOrDefault();
			var t = new TeamEditViewModel
			{
				Team = team
			};
			return View(t);
		}


		[HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = $"{product.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(product);
            }
        }
		// POST: /Admin/EditCategory
		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> EditCategory(CategoryEditViewModel categoryView)
		{
			if (categoryView.CategoryImage != null)
			{
				using (var memoryStream = new MemoryStream())
				{
					await categoryView.CategoryImage.CopyToAsync(memoryStream);
					categoryView.Category.CategoryImage = memoryStream.ToArray();
					categoryView.Category.ImageMimeType = categoryView.CategoryImage.ContentType;
				}
			}
			if (ModelState.IsValid)
			{
				var category = new Category
				{
					Name = categoryView.Category.Name,
					Price = categoryView.Category.Price,
					CategoryImage = categoryView.Category.CategoryImage
				};

				categoryRepository.SaveCategory(categoryView.Category);
				TempData["message"] = $"{categoryView.Category.Name} has been saved";
				return RedirectToAction("CategoryList");
			}
			else
			{
				// there is something wrong with the data values
				return View(categoryView);
			}
		}

		// POST: /Admin/EditWhatDoWeOffer
		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> EditWhatDoWeOffer(OfferEditViewModel offerView)
		{
			if (offerView.OfferImage != null)
			{
				using (var memoryStream = new MemoryStream())
				{
					await offerView.OfferImage.CopyToAsync(memoryStream);
					offerView.Offer.Image = memoryStream.ToArray();
					offerView.Offer.ImageMimeType = offerView.OfferImage.ContentType;
				}
			}
			if (ModelState.IsValid)
			{
				var category = new WhatDoWeOffer
				{
					Title = offerView.Offer.Title,
					Description = offerView.Offer.Description,
					Image = offerView.Offer.Image
				};

				offerRepository.SaveOffer(offerView.Offer);
				TempData["message"] = $"{offerView.Offer.Title} has been saved";
				return RedirectToAction("InformationList");
			}
			else
			{
				// there is something wrong with the data values
				return View(offerView);
			}
		}


		// POST: /Admin/EditTypesOfPrinting
		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> EditTypesOfPrinting(TypeEditViewModel typeView)
		{
			if (typeView.TypeImage != null)
			{
				using (var memoryStream = new MemoryStream())
				{
					await typeView.TypeImage.CopyToAsync(memoryStream);
					typeView.Type.Image = memoryStream.ToArray();
					typeView.Type.ImageMimeType = typeView.TypeImage.ContentType;
				}
			}
			if (ModelState.IsValid)
			{
				var category = new TypesOfPrinting
				{
					Title = typeView.Type.Title,
					Description = typeView.Type.Description,
					Image = typeView.Type.Image
				};

				typeRepository.SaveType(typeView.Type);
				TempData["message"] = $"{typeView.Type.Title} has been saved";
				return RedirectToAction("InformationList");
			}
			else
			{
				// there is something wrong with the data values
				return View(typeView);
			}
		}

		// POST: /Admin/EditOurTeam
		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> EditOurTeam(TeamEditViewModel teamView)
		{
			if (teamView.TeamImage != null)
			{
				using (var memoryStream = new MemoryStream())
				{
					await teamView.TeamImage.CopyToAsync(memoryStream);
					teamView.Team.Image = memoryStream.ToArray();
					teamView.Team.ImageMimeType = teamView.TeamImage.ContentType;
				}
			}
			if (ModelState.IsValid)
			{
				var category = new OurTeam
				{
					Name = teamView.Team.Name,
					Description = teamView.Team.Description,
					Position = teamView.Team.Position,
					Image = teamView.Team.Image
				};

				teamRepository.SaveTeam(teamView.Team);
				TempData["message"] = $"{teamView.Team.Name} has been saved";
				return RedirectToAction("InformationList");
			}
			else
			{
				// there is something wrong with the data values
				return View(teamView);
			}
		}

		public ViewResult Create() => View("Edit", new Product());
		public ViewResult CreateCategory() => View("EditCategory", new CategoryEditViewModel
		{
			Category = new Category()
		});
		public ViewResult CreateOffer() => View("EditWhatDoWeOffer", new OfferEditViewModel
		{
			Offer = new WhatDoWeOffer()
		});
		public ViewResult CreateTeam() => View("EditOurTeam", new TeamEditViewModel
		{
			Team = new OurTeam()
		});
		public ViewResult CreateType() => View("EditTypesOfPrinting", new TypeEditViewModel
		{
			Type = new TypesOfPrinting()
		});

		[HttpPost]
        public IActionResult Delete(int productId)
        {
            Product deletedProduct = repository.DeleteProduct(productId);
            if (deletedProduct != null)
            {
                TempData["message"] = $"{deletedProduct.Name} was deleted";
            }
            return RedirectToAction("Index");
        }
		[HttpPost]
		public IActionResult DeleteCategory(int categoryId)
		{
			Category deletedCategory = categoryRepository.DeleteCategory(categoryId);
			if (deletedCategory != null)
			{
				TempData["message"] = $"{deletedCategory.Name} was deleted";
			}
			return RedirectToAction("CategoryList");
		}

		[HttpPost]
		public IActionResult DeleteOffer(int offerId)
		{
			WhatDoWeOffer deletedOffer = offerRepository.DeleteOffer(offerId);
			if (deletedOffer != null)
			{
				TempData["message"] = $"{deletedOffer.Title} was deleted";
			}
			return RedirectToAction("InformationList");
		}

		[HttpPost]
		public IActionResult DeleteTeam(int teamId)
		{
			OurTeam deletedTeam= teamRepository.DeleteTeam(teamId);
			if (deletedTeam != null)
			{
				TempData["message"] = $"{deletedTeam.Name} was deleted";
			}
			return RedirectToAction("InformationList");
		}

		[HttpPost]
		public IActionResult DeleteType(int typeId)
		{
			TypesOfPrinting deletedType = typeRepository.DeleteType(typeId);
			if (deletedType != null)
			{
				TempData["message"] = $"{deletedType.Title} was deleted";
			}
			return RedirectToAction("InformationList");
		}

		public FileContentResult GetImage(Category item)
        {
            Category category = categoryRepository.Categories
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

