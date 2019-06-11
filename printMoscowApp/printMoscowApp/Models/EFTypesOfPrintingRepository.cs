using System.Collections.Generic;
using System.Linq;

namespace PrintMoscowApp.Models
{

	public class EFTypesOfPrintingRepository : ITypesOfPrintingRepository
	{
		private ApplicationDbContext context;

		public EFTypesOfPrintingRepository(ApplicationDbContext ctx)
		{
			context = ctx;
		}

		public IEnumerable<TypesOfPrinting> Types => context.TypesOfPrintings;

		public void SaveType(TypesOfPrinting types)
		{
			if (types.Id == 0)
			{
				context.TypesOfPrintings.Add(types);
			}
			else
			{
				TypesOfPrinting dbEntry = context.TypesOfPrintings
					.FirstOrDefault(p => p.Id == types.Id);
				if (dbEntry != null)
				{
					dbEntry.Title = types.Title;
					dbEntry.Description = types.Description;
					dbEntry.Image = types.Image;
                    dbEntry.ImageMimeType = types.ImageMimeType;
                }
			}
			context.SaveChanges();
		}

		public TypesOfPrinting DeleteType(int id)
		{
			TypesOfPrinting dbEntry = context.TypesOfPrintings
				.FirstOrDefault(p => p.Id == id);
			if (dbEntry != null)
			{
				context.TypesOfPrintings.Remove(dbEntry);
				context.SaveChanges();
			}
			return dbEntry;
		}
	}
}
