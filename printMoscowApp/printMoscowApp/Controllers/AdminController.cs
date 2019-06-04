using Microsoft.AspNetCore.Mvc;
using PrintMoscowApp.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace PrintMoscowApp.Controllers
{

	[Authorize]
	public class AdminController : Controller
	{
		private IProductRepository repository;
		private ICategoryRepository categoryRepository;

		public AdminController(IProductRepository repo,ICategoryRepository categoryRepo)
		{
			repository = repo;
			categoryRepository = categoryRepo;
		}

		public ViewResult Index() => View(repository.Products);		

		public ViewResult Edit(int productId) =>
			View(repository.Products
				.FirstOrDefault(p => p.ProductID == productId));

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

		public ViewResult Create() => View("Edit", new Product());

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

		public ViewResult CategoryList() => View(categoryRepository.Categories);

		public ViewResult EditCategory(int categoryId) =>
			View(categoryRepository.Categories
				.FirstOrDefault(p => p.Id == categoryId));

		[HttpPost]
		public IActionResult EditCategory(Category category, IFormFile image = null)
		{
			if (ModelState.IsValid)
			{
				if (image != null)
				{
					category.ImageMimeType = image.ContentType;
					category.ImageData = new byte[image.Length];
					image.OpenReadStream().Read(category.ImageData, 0,1);
				}
				categoryRepository.SaveCategory(category);
				TempData["message"] = $"{category.Name} has been saved";
				return RedirectToAction("CategoryList");
			}
			else
			{
				// there is something wrong with the data values
				return View(category);
			}
		}

		public ViewResult CreateCategory() => View("EditCategory", new Category());

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
	}
}
