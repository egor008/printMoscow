using System.Collections.Generic;

namespace PrintMoscowApp.Models
{

	public interface IWhatDoWeOfferyRepository
	{
		IEnumerable<WhatDoWeOffer> Offers { get; }
		void SaveOffer(WhatDoWeOffer offer);
		WhatDoWeOffer DeleteOffer(int id);
	}
}
