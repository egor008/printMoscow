using System.Collections.Generic;

namespace PrintMoscowApp.Models
{

	public interface ICategoryRepository
	{
		IEnumerable<Category> Categories { get; }
		void SaveCategory(Category category);
		Category DeleteCategory(int categoryId);
	}
}
