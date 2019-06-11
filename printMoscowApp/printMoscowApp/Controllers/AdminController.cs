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

        public AdminController(IProductRepository repo, ICategoryRepository categoryRepo)
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
		public ViewResult InformationList() => View();

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

        public ViewResult CreateCategory() => View("EditCategory", new CategoryEditViewModel
            {
            Category = new Category()
            }
    );

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
    }
}

