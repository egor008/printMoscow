using System.Collections.Generic;

namespace PrintMoscowApp.Models
{

	public interface IOurTeamRepository
	{
		IEnumerable<OurTeam> Teams { get; }
		void SaveTeam(OurTeam team);
		OurTeam DeleteTeam(int id);
	}
}
