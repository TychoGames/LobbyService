using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TychoGames.LobbyService.EntityFrameworkCore.Migrations
{
    public partial class AddLeaderToLobby : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Leader",
                table: "Lobbies",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Leader",
                table: "Lobbies");
        }
    }
}
