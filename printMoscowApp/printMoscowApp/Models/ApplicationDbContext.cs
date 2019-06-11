using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintMoscowApp.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options) { }
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Category> Categories {get;set;}
		public DbSet<WhatDoWeOffer> Offers { get; set; }
		public DbSet<TypesOfPrinting> TypesOfPrintings { get; set; }
		public DbSet<OurTeam> OurTeams { get; set; }
	}
}
