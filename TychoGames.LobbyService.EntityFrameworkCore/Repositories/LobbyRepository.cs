using System;
using System.Threading.Tasks;
using TychoGames.LobbyService.Core.Entities;
using TychoGames.LobbyService.Core.Interfaces;

namespace TychoGames.LobbyService.EntityFrameworkCore.Repositories
{
    public class LobbyRepository : ILobbyRepository
    {
        private readonly AppDbContext _db;

        public LobbyRepository(AppDbContext db)
        {
            _db = db;
        }
        
        public async Task<Lobby> GetById(Guid id)
        {
            return await _db.Lobbies.FindAsync(id);
        }
    }
}