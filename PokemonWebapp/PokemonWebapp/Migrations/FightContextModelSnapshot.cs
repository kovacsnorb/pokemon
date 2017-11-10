using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PokemonWebapp.Entities;

namespace PokemonWebapp.Migrations
{
    [DbContext(typeof(FightContext))]
    partial class FightContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.3");

            modelBuilder.Entity("PokemonWebapp.Models.Fight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ComputerFightPoint");

                    b.Property<string>("ComputerPokemon");

                    b.Property<int>("ComputerPokemonId");

                    b.Property<int>("ComputerPokemonLevel");

                    b.Property<int>("ComputerPokemonLuckyNumber");

                    b.Property<string>("Player");

                    b.Property<int>("PlayerFightPoint");

                    b.Property<string>("PlayerPokemon");

                    b.Property<int>("PlayerPokemonId");

                    b.Property<int>("PlayerPokemonLevel");

                    b.Property<int>("PlayerPokemonLuckyNumber");

                    b.HasKey("Id");

                    b.ToTable("Fights");
                });
        }
    }
}
