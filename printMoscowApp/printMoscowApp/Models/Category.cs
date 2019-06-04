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
		public byte[] CategoryImage { get; set; }
	}
}
