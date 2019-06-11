using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintMoscowApp.Models.ViewModels
{
	public class TypeEditViewModel
	{
		public TypesOfPrinting Type { get; set; }
		public IFormFile TypeImage { get; set; }
		public string ReturnUrl { get; set; }
	}
}
