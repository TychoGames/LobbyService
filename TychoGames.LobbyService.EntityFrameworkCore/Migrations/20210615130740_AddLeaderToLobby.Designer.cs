﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TychoGames.LobbyService.EntityFrameworkCore;

namespace TychoGames.LobbyService.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210615130740_AddLeaderToLobby")]
    partial class AddLeaderToLobby
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("TychoGames.LobbyService.Core.Entities.Lobby", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("Game")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Leader")
                        .HasColumnType("char(36)");

                    b.Property<int>("MaxPlayers")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Lobbies");
                });

            modelBuilder.Entity("TychoGames.LobbyService.Core.Entities.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LobbyId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("LobbyId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("TychoGames.LobbyService.Core.Entities.Player", b =>
                {
                    b.HasOne("TychoGames.LobbyService.Core.Entities.Lobby", null)
                        .WithMany("Players")
                        .HasForeignKey("LobbyId");
                });

            modelBuilder.Entity("TychoGames.LobbyService.Core.Entities.Lobby", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
