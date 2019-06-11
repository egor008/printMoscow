using System.Collections.Generic;

namespace PrintMoscowApp.Models
{

	public interface ITypesOfPrintingRepository
	{
		IEnumerable<TypesOfPrinting> Types { get; }
		void SaveType(TypesOfPrinting Type);
		TypesOfPrinting DeleteType(int id);
	}
}
