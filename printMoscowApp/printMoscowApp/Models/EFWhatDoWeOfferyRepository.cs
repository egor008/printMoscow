using System.Collections.Generic;
using System.Linq;

namespace PrintMoscowApp.Models
{

	public class EFWhatDoWeOfferyRepository : IWhatDoWeOfferyRepository
	{
		private ApplicationDbContext context;

		public EFWhatDoWeOfferyRepository(ApplicationDbContext ctx)
		{
			context = ctx;
		}

		public IEnumerable<WhatDoWeOffer> Offers => context.Offers;

		public void SaveOffer(WhatDoWeOffer offer)
		{
			if (offer.Id == 0)
			{
				context.Offers.Add(offer);
			}
			else
			{
				WhatDoWeOffer dbEntry = context.Offers
					.FirstOrDefault(p => p.Id == offer.Id);
				if (dbEntry != null)
				{
					dbEntry.Title = offer.Title;
					dbEntry.Description = offer.Description;
					dbEntry.Image = offer.Image;
                    dbEntry.ImageMimeType = offer.ImageMimeType;
                }
			}
			context.SaveChanges();
		}

		public WhatDoWeOffer DeleteOffer(int id)
		{
			WhatDoWeOffer dbEntry = context.Offers
				.FirstOrDefault(p => p.Id == id);
			if (dbEntry != null)
			{
				context.Offers.Remove(dbEntry);
				context.SaveChanges();
			}
			return dbEntry;
		}
	}
}
