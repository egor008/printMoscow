using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintMoscowApp.Models.ViewModels
{
	public class CategoryEditViewModel
	{
		public Category Category { get; set; }
		public IFormFile CategoryImage { get; set; }
		public string ReturnUrl { get; set; }
	}
}
