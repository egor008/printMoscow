﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintMoscowApp.Models
{
	public class EFOrderRepository: IOrderRepository
	{
		private ApplicationDbContext context;

		public EFOrderRepository(ApplicationDbContext ctx)
		{
			context = ctx;
		}
		public IEnumerable<Order> Orders => context.Orders
			.Include(o => o.Lines)
			.ThenInclude(l => l.Product);
		public void SaveOrder(Order order)
		{
			context.AttachRange(order.Lines.Select(l => l.Product));
			if (order.OrderID == 0)
			{
				context.Orders.Add(order);
			}
			context.SaveChanges();
		}
	}
}
