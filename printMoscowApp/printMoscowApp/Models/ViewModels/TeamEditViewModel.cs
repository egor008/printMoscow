using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintMoscowApp.Models.ViewModels
{
	public class TeamEditViewModel
	{
		public OurTeam Team { get; set; }
		public IFormFile TeamImage { get; set; }
		public string ReturnUrl { get; set; }
	}
}
