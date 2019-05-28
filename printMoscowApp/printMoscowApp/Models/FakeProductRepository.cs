using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintMoscowApp.Models
{
	public class FakeProductRepository: IProductRepository
	{
		public IEnumerable<Product> Products => new List<Product>
		{
			new Product {Name = "Визитки", Price = 25},
			new Product {Name = "Газеты", Price = 179},
			new Product {Name = "Стикеры", Price = 95}
		};
	}
}
