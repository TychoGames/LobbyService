using AutoMapper;
using TychoGames.LobbyService.Core.Entities;
using TychoGames.LobbyService.Web.Dtos;

namespace TychoGames.LobbyService.Web.Automapper
{
    public class LobbyMapping : Profile
    {
        public LobbyMapping()
        {
            CreateMap<Lobby, CreateLobbyDto>();
        }
    }
}