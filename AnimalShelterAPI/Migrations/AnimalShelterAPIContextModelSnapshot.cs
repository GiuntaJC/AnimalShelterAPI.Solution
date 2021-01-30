﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelterAPI.Migrations
{
    [DbContext(typeof(AnimalShelterAPIContext))]
    partial class AnimalShelterAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 5,
                            Gender = "Male",
                            Name = "Bender",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 3,
                            Gender = "Male",
                            Name = "Chip",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Gender = "Female",
                            Name = "Emma",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Gender = "Female",
                            Name = "Bella",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 22,
                            Gender = "Male",
                            Name = "Perry",
                            Species = "Parrot"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
