using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static PrintMoscowApp.Models.Cart;

namespace PrintMoscowApp.Models
{
	public class Order
	{
		[BindNever]
		public int OrderID { get; set; }

		[BindNever]
		public ICollection<CartLine> Lines { get; set; }
		[BindNever]

		public bool Shipped { get; set; }
		[Required(ErrorMessage = "Введите имя")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Введите улицу")]
		public string Line1 { get; set; }
		[Required(ErrorMessage = "Введите название города")]
		public string City { get; set; }
		public string Zip { get; set; }
		public string GiftWrap { get; set; }
	}
}
