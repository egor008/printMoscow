﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintMoscowApp.Models
{
	public interface IOrderRepository
	{
		IEnumerable<Order> Orders { get; }
		void SaveOrder(Order order);
	}

}
