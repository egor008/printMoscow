using Microsoft.AspNetCore.Mvc;
using PrintMoscowApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintMoscowApp.Controllers
{
	public class OrderController : Controller
	{
					public ViewResult Checkout() => View(new Order());
		}
}
