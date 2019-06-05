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
						Description = "PRIVET",
						Category = "Визитки",
						Price = 275
					},
					new Product
					{
						Name = "Test2",
						Description = "PRIVET",
						Category = "Визитки",
						Price = 2225
					},
					new Product
					{
						Name = "Test3",
						Description = "PRIVET",
						Category = "Визитки",
						Price = 27115
					},
					new Product
					{
						Name = "Test4",
						Description = "PRIVET",
						Category = "Визитки",
						Price = 271
					},
					new Product
					{
						Name = "Test5",
						Description = "PRIVET",
						Category = "Визитки",
						Price = 27
					}
					);
				context.SaveChanges();
			}
			if (!context.Categories.Any())
			{
				context.Categories.AddRange(
					new Category
					{
						Name = "Визитки",
						Price = 300
					},
					new Category
					{
						Name = "Наклейки",
						Price = 400
					}, new Category
					{
						Name = "Листовки",
						Price = 500
					}, new Category
					{
						Name = "Буклеты",
						Price = 600
					}, new Category
					{
						Name = "Флаеры",
						Price = 700
					}, new Category
					{
						Name = "Каталоги",
						Price = 800
					}, new Category
					{
						Name = "Инструкции",
						Price = 900
					}, new Category
					{
						Name = "Открытки",
						Price = 1100
					}, new Category
					{
						Name = "Плакаты",
						Price = 1200
					}, new Category
					{
						Name = "Бланки",
						Price = 1300
					}, new Category
					{
						Name = "Календари",
						Price = 1400
					}, new Category
					{
						Name = "Дипломы",
						Price = 1500
					}, new Category
					{
						Name = "Баннеры",
						Price = 1600
					}, new Category
					{
						Name = "Чертежи",
						Price = 1700
					}, new Category
					{
						Name = "Конверты",
						Price = 1800
					}, new Category
					{
						Name = "Блокноты",
						Price = 1900
					}, new Category
					{
						Name = "Брошюры",
						Price = 2000
					}, new Category
					{
						Name = "Приглашения",
						Price = 2100
					}
					);
				context.SaveChanges();
			}
		}
	}
}
