using System;
using System.Threading.Tasks;
using TychoGames.LobbyService.Core.Entities;

namespace TychoGames.LobbyService.Core.Interfaces
{
    public interface ILobbyRepository
    {
        public Task<Lobby> GetById(Guid id);
    }
}