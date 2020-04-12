using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demario_D_301021637.Models
{
    public class EFClubsRepository : IClubsRepository
    {
        private ApplicationDbContext context;

        public EFClubsRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Clubs> IClubs => context.ClubsDb;

        public Clubs SaveClubs(Clubs club)
        {
            if (club.ClubID == 0)
            {
                context.ClubsDb.Add(club);
            }
            else
            {
                Clubs dbEntry = context.ClubsDb.FirstOrDefault(c => c.ClubID == club.ClubID);
                    dbEntry.ClubName = club.ClubName;
                    dbEntry.ClubManager = club.ClubManager;
                    dbEntry.ClubDetails = club.ClubDetails;
                
            }
            context.SaveChanges();
            return club;
        }

        public Clubs DeleteClub(int ClubId)
        {
            Clubs dbEntry = context.ClubsDb.FirstOrDefault(c => c.ClubID == ClubId);
            if (dbEntry != null)
            {
                context.ClubsDb.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
