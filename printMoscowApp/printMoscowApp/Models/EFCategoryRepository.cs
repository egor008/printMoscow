using System.Collections.Generic;
using System.Linq;

namespace PrintMoscowApp.Models
{

	public class EFCategorytRepository : ICategoryRepository
	{
		private ApplicationDbContext context;

		public EFCategorytRepository(ApplicationDbContext ctx)
		{
			context = ctx;
		}

		public IEnumerable<Category> Categories => context.Categories;

		public void SaveCategory(Category category)
		{
			if (category.Id == 0)
			{
				context.Categories.Add(category);
			}
			else
			{
				Category dbEntry = context.Categories
					.FirstOrDefault(p => p.Id == category.Id);
				if (dbEntry != null)
				{
					dbEntry.Name = category.Name;
					dbEntry.Price = category.Price;
					dbEntry.CategoryImage = category.CategoryImage;
				}
			}
			context.SaveChanges();
		}

		public Category DeleteCategory(int id)
		{
			Category dbEntry = context.Categories
				.FirstOrDefault(p => p.Id == id);
			if (dbEntry != null)
			{
				context.Categories.Remove(dbEntry);
				context.SaveChanges();
			}
			return dbEntry;
		}
	}
}
