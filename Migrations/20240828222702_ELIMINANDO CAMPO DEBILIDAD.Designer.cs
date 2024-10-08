﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POKEMONPRUEBA.Context;

#nullable disable

namespace POKEMONPRUEBA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240828222702_ELIMINANDO CAMPO DEBILIDAD")]
    partial class ELIMINANDOCAMPODEBILIDAD
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("POKEMONPRUEBA.Modelo.Pokemon", b =>
                {
                    b.Property<int>("IdPokemon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPokemon"));

                    b.Property<int>("Atq")
                        .HasColumnType("int");

                    b.Property<int>("AtqEs")
                        .HasColumnType("int");

                    b.Property<int>("Def")
                        .HasColumnType("int");

                    b.Property<int>("DefEs")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ps")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Velo")
                        .HasColumnType("int");

                    b.HasKey("IdPokemon");

                    b.ToTable("Pokemons");
                });
#pragma warning restore 612, 618
        }
    }
}
