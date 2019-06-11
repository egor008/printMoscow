using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintMoscowApp.Models.ViewModels
{
	public class OfferEditViewModel
	{
		public WhatDoWeOffer Offer { get; set; }
		public IFormFile OfferImage { get; set; }
		public string ReturnUrl { get; set; }
	}
}
