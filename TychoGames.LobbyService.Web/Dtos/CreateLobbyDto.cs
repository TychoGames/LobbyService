using System;

namespace TychoGames.LobbyService.Web.Dtos
{
    public class CreateLobbyDto
    {
        public string Name { get; set; }
        public int MaxPlayers { get; set; }
        public Guid Game { get; set; }
    }
}