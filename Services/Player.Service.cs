using Bubelinez.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bubelinez.Services
{
    class PlayerService
    {
        public List<Player> PlayerList;

        public PlayerService(List<Player> playerList) { PlayerList = playerList; }

        public async Task ProcessPlayerList()
        {
            foreach (var player in PlayerList) await Task.Run(() => ProcessPlayer(player));
        }

        private void ProcessPlayer(Player player)
        {
            // Implement player logic here
        }
    }
}
