using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PrintMoscowApp.Models
{

	public class Category
	{
		public int Id { get; set; }		
		public string Name { get; set; }	
		public int Price { get; set; }
		public byte[] ImageData { get; set; }
		[Column(TypeName = "varchar(50)")]
		public string ImageMimeType { get; set; }
	}
}
