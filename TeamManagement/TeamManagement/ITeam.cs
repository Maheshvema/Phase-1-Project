using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManagement
{
    public interface ITeam
    {
        bool AddPlayer(IPlayer player);
        bool RemovePlayer(int playerId);
        IPlayer GetPlayerById(int playerId);
        IEnumerable<IPlayer> GetPlayersByName(string playerName);
        IEnumerable<IPlayer> GetAllPlayers();
    }
}
