using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demario_D_301021637.Models
{
    public interface IPlayersRepository
    {
        IQueryable<Players> IPlayers { get; }

        void SavePlayers(Players player);
        Players DeletePlayer(int PlayerId);

    }
}
