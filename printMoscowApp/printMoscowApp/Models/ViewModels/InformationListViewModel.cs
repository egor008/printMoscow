using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintMoscowApp.Models.ViewModels
{
	public class InformationListViewModel
	{
		public IEnumerable<WhatDoWeOffer> Offer { get; set; }
		public IEnumerable<TypesOfPrinting> Type { get; set; }
		public IEnumerable<OurTeam> Team { get; set; }
	}
}
