using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demario_D_301021637.Models
{
    public class EFPlayersRepository:IPlayersRepository
    {
        private ApplicationDbContext context;

        public EFPlayersRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Players> IPlayers => context.PlayersDb;

        public void SavePlayers(Players player)
        {
            if (player.PlayerID == 0)
            {
                context.PlayersDb.Add(player);
            }
            else
            {
                Players dbEntry = context.PlayersDb
                    .FirstOrDefault(p => p.PlayerID == player.PlayerID);
                if (dbEntry != null)
                {
                    dbEntry.PlayerName = player.PlayerName;
                    dbEntry.PlayerClub = player.PlayerClub;
                    dbEntry.PlayerPosition = player.PlayerPosition;
                }
            }
            context.SaveChanges();
        }

        public Players DeletePlayer(int PlayerId)
        {
            Players dbEntry = context.PlayersDb
                .FirstOrDefault(p => p.PlayerID == PlayerId);
            if (dbEntry != null)
            {
                context.PlayersDb.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
