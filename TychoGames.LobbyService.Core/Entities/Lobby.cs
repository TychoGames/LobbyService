using System;
using System.Collections.Generic;

namespace TychoGames.LobbyService.Core.Entities
{
    public class Lobby
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MaxPlayers { get; set; }
        public Guid Game { get; set; }
        public List<Player> Players { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}