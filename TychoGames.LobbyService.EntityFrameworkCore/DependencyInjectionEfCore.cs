using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TychoGames.LobbyService.Core.Interfaces;
using TychoGames.LobbyService.EntityFrameworkCore.Repositories;

namespace TychoGames.LobbyService.EntityFrameworkCore
{
    public static class DependencyInjectionEfCore
    {
        public static IServiceCollection AddEfCore(this IServiceCollection services, string connectionString)
                {
                    services.AddDbContext<AppDbContext>(x =>
                    {
                        x.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                            .EnableSensitiveDataLogging()
                            .EnableDetailedErrors();
                    });

                    services.AddTransient<ILobbyRepository, LobbyRepository>();
                    
                    return services;
                }
    }
}