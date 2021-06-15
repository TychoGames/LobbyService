using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TychoGames.LobbyService.Core.Entities;
using TychoGames.LobbyService.Core.Interfaces;
using TychoGames.LobbyService.Web.Dtos;

namespace TychoGames.LobbyService.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LobbyController : Controller
    {
        private readonly ILobbyRepository _lobbyRepository;
        private readonly IMapper _mapper;

        public LobbyController(ILobbyRepository lobbyRepository, IMapper mapper)
        {
            _lobbyRepository = lobbyRepository;
            _mapper = mapper;
        }
        
        [HttpGet("{id:guid}")]
        public async Task<Lobby> GetById(Guid id)
        {
            return await _lobbyRepository.GetById(id);
        }

        [HttpPost]
        public async Task<Lobby> Create(CreateLobbyDto lobbyDto)
        {
            var lobby = _mapper.Map<CreateLobbyDto, Lobby>(lobbyDto);
            lobby.CreatedDateTime = DateTime.Now;
            return new Lobby();
        }
    }
}
