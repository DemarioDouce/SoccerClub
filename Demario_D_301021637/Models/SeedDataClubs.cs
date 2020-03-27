using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demario_D_301021637.Models
{
    public static class SeedDataClubs
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.ClubsDb.Any())
            {
                context.ClubsDb.AddRange(
                    new Clubs
                    {
                        ClubName = "Manchester United",
                        ClubManager = "Ole Gunnar Solskjær",
                        ClubDetails = "Manchester United Football Club is a professional football club based in Old Trafford, Greater Manchester, England, that competes in the Premier League, the top flight of English football.",
                    },
                    new Clubs
                    {
                        ClubName = "Manchester City",
                        ClubManager = "Pep Guardiola",
                        ClubDetails = "Manchester City Football Club is an English football club based in Manchester that competes in the Premier League, the top flight of English football. Founded in 1880 as St. Mark's, it became Ardwick Association Football Club in 1887 and Manchester City in 1894.",
                    },
                    new Clubs
                    {
                        ClubName = "Liverpool",
                        ClubManager = "Jürgen Klopp",
                        ClubDetails = "Liverpool Football Club is a professional football club in Liverpool, England, that competes in the Premier League, the top tier of English football.",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
