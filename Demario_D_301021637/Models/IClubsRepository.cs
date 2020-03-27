using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demario_D_301021637.Models
{
    public interface IClubsRepository
    {
        IQueryable<Clubs> IClubs { get; }

        void SaveClubs(Clubs club);
        Clubs DeleteClub(int ClubId);
    }
}
