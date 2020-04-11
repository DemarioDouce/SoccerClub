using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demario_D_301021637.Models
{
    public static class SeedDataPlayers
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureDeleted();
            context.Database.Migrate();
            if (!context.PlayersDb.Any())
            {
                context.PlayersDb.AddRange(
                    new Players
                    {
                        PlayerName = "Demario Douce",
                        PlayerClub = "Manchester United",
                        PlayerPosition = "Defender",
                    },
                    new Players
                    {
                        PlayerName = "Demarly Lewis",
                        PlayerClub = "Manchester City",
                        PlayerPosition = "Goal Keeper",
                    },
                    new Players
                    {
                        PlayerName = "Richard Blake",
                        PlayerClub = "Liverpool",
                        PlayerPosition = "Defender",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
