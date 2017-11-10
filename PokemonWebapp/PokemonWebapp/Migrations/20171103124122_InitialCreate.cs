using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PokemonWebapp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ComputerFightPoint = table.Column<int>(nullable: false),
                    ComputerPokemon = table.Column<string>(nullable: true),
                    ComputerPokemonId = table.Column<int>(nullable: false),
                    ComputerPokemonLevel = table.Column<int>(nullable: false),
                    ComputerPokemonLuckyNumber = table.Column<int>(nullable: false),
                    Player = table.Column<string>(nullable: true),
                    PlayerFightPoint = table.Column<int>(nullable: false),
                    PlayerPokemon = table.Column<string>(nullable: true),
                    PlayerPokemonId = table.Column<int>(nullable: false),
                    PlayerPokemonLevel = table.Column<int>(nullable: false),
                    PlayerPokemonLuckyNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fights", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fights");
        }
    }
}
