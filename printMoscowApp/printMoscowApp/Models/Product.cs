using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PrintMoscowApp.Models
{

	public class Product
	{

		public int ProductID { get; set; }

		[Required(ErrorMessage = "Please enter a product name")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Please enter a description")]
		public string Description { get; set; }

		[Required]
		[Range(0.01, double.MaxValue,
			ErrorMessage = "Please enter a positive price")]
		public decimal Price { get; set; }

		[Required(ErrorMessage = "Please specify a category")]
		public string Category { get; set; }

		public byte[] ImageData { get; set; }

		[Column(TypeName = "varchar(50)")]
		public string ImageMimeType { get; set; }
	}
}
