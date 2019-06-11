using System.Collections.Generic;
using System.Linq;

namespace PrintMoscowApp.Models
{

	public class EFOurTeamRepository : IOurTeamRepository
	{
		private ApplicationDbContext context;

		public EFOurTeamRepository(ApplicationDbContext ctx)
		{
			context = ctx;
		}

		public IEnumerable<OurTeam> Teams => context.OurTeams;

		public void SaveTeam(OurTeam team)
		{
			if (team.Id == 0)
			{
				context.OurTeams.Add(team);
			}
			else
			{
				OurTeam dbEntry = context.OurTeams
					.FirstOrDefault(p => p.Id == team.Id);
				if (dbEntry != null)
				{
					dbEntry.Name = team.Name;
					dbEntry.Position = team.Position;
					dbEntry.Description = team.Description;
					dbEntry.Image = team.Image;
                    dbEntry.ImageMimeType = team.ImageMimeType;
                }
			}
			context.SaveChanges();
		}

		public OurTeam DeleteTeam(int id)
		{
			OurTeam dbEntry = context.OurTeams
				.FirstOrDefault(p => p.Id == id);
			if (dbEntry != null)
			{
				context.OurTeams.Remove(dbEntry);
				context.SaveChanges();
			}
			return dbEntry;
		}
	}
}
