using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManagement
{
    public class CricketPlayer:IPlayer
    {
        public int PlayerId { get; }
        public string Name { get; }
        public int Age { get; }

        public CricketPlayer(int playerId, string name, int age)
        {
            PlayerId = playerId;
            Name = name;
            Age = age;
        }
    }
}
