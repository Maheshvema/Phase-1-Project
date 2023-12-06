using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManagement
{
    public class CricketTeam:ITeam
    {
        public List<IPlayer> players = new List<IPlayer>();

        public bool AddPlayer(IPlayer player)
        {
            if (players.Count >= 11)
            {
                Console.WriteLine("Cannot add more than 11 players to the team.");
                return false;
            }

            players.Add(player);
            return true;
        }

        public bool RemovePlayer(int playerId)
        {
            IPlayer playerToRemove = players.FirstOrDefault(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
                return true;
            }

            Console.WriteLine("Player not found.");
            return false;
        }

        public IPlayer GetPlayerById(int playerId)
        {
            return players.FirstOrDefault(p => p.PlayerId == playerId);
        }

        public IEnumerable<IPlayer> GetPlayersByName(string playerName)
        {
            return players.Where(p => p.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<IPlayer> GetAllPlayers()
        {
            return players;
        }
    }
}

