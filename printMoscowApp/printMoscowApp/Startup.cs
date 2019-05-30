﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PrintMoscowApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace printMoscowApp
{
	public class Startup
	{
		IConfiguration Configuration;

		public Startup(IHostingEnvironment env)
		{
			Configuration = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json").Build();
		}

		public IServiceProvider ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>(option =>
			option.UseSqlServer(
				Configuration["Data:PrintMoscowProducts:ConnectionString"]));

			services.AddTransient<IProductRepository, EFProductRepository>();
			services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			services.AddTransient<IOrderRepository, EFOrderRepository>();
			services.AddMvc();
			services.AddMemoryCache();
			services.AddSession();

			return services.BuildServiceProvider();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			app.UseDeveloperExceptionPage();
			app.UseStatusCodePages();
			app.UseStaticFiles();
			app.UseSession();
			app.UseMvc(routes => {
				routes.MapRoute(
					name: null,
					template: "{category}/Page{page:int}",
					defaults: new { controller = "Product", action = "List" }
				);

				routes.MapRoute(
					name: null,
					template: "Page{page:int}",
					defaults: new { controller = "Product", action = "List", page = 1 }
				);

				routes.MapRoute(
					name: null,
					template: "{category}",
					defaults: new { controller = "Product", action = "List", page = 1 }
				);

				routes.MapRoute(
					name: null,
					template: "",
					defaults: new { controller = "Product", action = "List", page = 1 });

				routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");
			});
			SeedData.EnsurePopulated(app);
		}
	}
}
