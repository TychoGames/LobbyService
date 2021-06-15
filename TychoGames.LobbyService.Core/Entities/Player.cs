using System;

namespace TychoGames.LobbyService.Core.Entities
{
    public class Player
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}