using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintMoscowApp.Models
{
	public static class SeedData
	{
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
			if (!context.Products.Any())
			{
				context.Products.AddRange(
					new Product
					{
						Name = "Test1",
						Discription = "PRIVET",
						Category = "Watersports",
						Price = 275
					},
					new Product
					{
						Name = "Test2",
						Discription = "PRIVET",
						Category = "Watersports",
						Price = 2225
					},
					new Product
					{
						Name = "Test3",
						Discription = "PRIVET",
						Category = "Watersports",
						Price = 27115
					},
					new Product
					{
						Name = "Test4",
						Discription = "PRIVET",
						Category = "Watersports",
						Price = 271
					},
					new Product
					{
						Name = "Test5",
						Discription = "PRIVET",
						Category = "Watersports",
						Price = 27
					}
					);
				context.SaveChanges();
			}
		}
	}
}
