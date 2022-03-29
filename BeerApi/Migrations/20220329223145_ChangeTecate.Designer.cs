﻿// <auto-generated />
using BeerApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeerApi.Migrations
{
    [DbContext(typeof(BeerApiContext))]
    [Migration("20220329223145_ChangeTecate")]
    partial class ChangeTecate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BeerApi.Models.Beer", b =>
                {
                    b.Property<int>("BeerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Abv")
                        .HasColumnType("double");

                    b.Property<string>("Brewery")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Style")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BeerId");

                    b.ToTable("Beers");

                    b.HasData(
                        new
                        {
                            BeerId = 1,
                            Abv = 8.0999999999999996,
                            Brewery = "Block15",
                            Name = "Sticky Hands",
                            Style = "IPA"
                        },
                        new
                        {
                            BeerId = 2,
                            Abv = 4.7999999999999998,
                            Brewery = "Wayfinder",
                            Name = "Hell",
                            Style = "Lager"
                        },
                        new
                        {
                            BeerId = 3,
                            Abv = 4.2000000000000002,
                            Brewery = "Guinness",
                            Name = "Guinness",
                            Style = "Stout"
                        },
                        new
                        {
                            BeerId = 4,
                            Abv = 6.0,
                            Brewery = "Great Notion",
                            Name = "Blueberry Muffin",
                            Style = "Sour"
                        },
                        new
                        {
                            BeerId = 5,
                            Abv = 5.0,
                            Brewery = "Blue Moon",
                            Name = "Blue Moon",
                            Style = "Wheat"
                        },
                        new
                        {
                            BeerId = 6,
                            Abv = 4.5,
                            Brewery = "Corona",
                            Name = "Corona",
                            Style = "Lager"
                        },
                        new
                        {
                            BeerId = 7,
                            Abv = 7.0,
                            Brewery = "Great Notion",
                            Name = "Ripe",
                            Style = "IPA"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}