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

		public ViewResult EditCategory(int categoryId)
		{
			var category = categoryRepository.Categories.Where(p => p.Id == categoryId).FirstOrDefault();
			var t = new CategoryEditViewModel
			{
				Category = category
			};
			return View(t);
		}

		// POST: /Admin/EditCategory
		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> EditCategory(CategoryEditViewModel categoryView)
		{
			ViewData["ReturnUrl"] = categoryView.ReturnUrl;
			if (ModelState.IsValid)
			{
				var category = new Category
				{
					Name = categoryView.Category.Name,
					Price = categoryView.Category.Price
				};
				using (var memoryStream = new MemoryStream())
				{
					await categoryView.CategoryImage.CopyToAsync(memoryStream);
					category.CategoryImage = memoryStream.ToArray();
				}
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
		[HttpPost("UploadFiles")]
		public async Task<IActionResult> Post(List<IFormFile> files, string returnUrl)
		{
			long size = files.Sum(f => f.Length);

			// full path to file in temp location
			var filePath = Path.GetTempFileName();

			foreach (var formFile in files)
			{
				if (formFile.Length > 0)
				{
					using (var stream = new FileStream(filePath, FileMode.Create))
					{
						await formFile.CopyToAsync(stream);
					}
				}
			}

			// process uploaded files
			// Don't rely on or trust the FileName property without validation.

			return Ok(new { count = files.Count, size, filePath });
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
