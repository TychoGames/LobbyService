using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TychoGames.LobbyService.Core.Entities;
using TychoGames.LobbyService.Core.Interfaces;

namespace TychoGames.LobbyService.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LobbyController : Controller
    {
        private readonly ILobbyRepository _lobbyRepository;

        public LobbyController(ILobbyRepository lobbyRepository)
        {
            _lobbyRepository = lobbyRepository;
        }
        
        [HttpGet("{id:guid}")]
        public async Task<Lobby> GetById(Guid id)
        {
            return await _lobbyRepository.GetById(id);
        }
    }
}
