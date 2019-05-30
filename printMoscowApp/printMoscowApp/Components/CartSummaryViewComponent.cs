using Microsoft.AspNetCore.Mvc;
using PrintMoscowApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintMoscowApp.Components
{
	public class CartSummaryViewComponent : ViewComponent
	{
		private Cart cart;

		public CartSummaryViewComponent(Cart cartservice)
		{
			cart = cartservice;
		}
		public IViewComponentResult Invoke()
		{
			return View(cart);
		}
	}
}
