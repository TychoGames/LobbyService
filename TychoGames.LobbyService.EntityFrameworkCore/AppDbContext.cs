using Microsoft.EntityFrameworkCore;
using TychoGames.LobbyService.Core.Entities;

namespace TychoGames.LobbyService.EntityFrameworkCore
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Lobby> Lobbies { get; set; }
    }
}