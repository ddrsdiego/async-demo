﻿// <auto-generated />
using AsyncDemo.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AsyncDemo.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20230304151440_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("AsyncDemo.Entities.Author", b =>
                {
                    b.Property<string>("AuthorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = "10ee7609-a4fb-4612-b4f1-8640c3f2248e",
                            FirstName = "George",
                            LastName = "R R Martin"
                        },
                        new
                        {
                            AuthorId = "64e4fd63-bae9-4755-be41-c960af184969",
                            FirstName = "Stephen",
                            LastName = "King"
                        },
                        new
                        {
                            AuthorId = "de234a63-3b75-42e3-b2db-e8c19f471bb6",
                            FirstName = "Bernard",
                            LastName = "Cornwell"
                        },
                        new
                        {
                            AuthorId = "4028a23e-4b18-4c92-bda9-6c7c803c44eb",
                            FirstName = "Ken",
                            LastName = "Follet"
                        },
                        new
                        {
                            AuthorId = "72365587-9a11-4e05-8245-117b2349df32",
                            FirstName = "Conn",
                            LastName = "Iggulden"
                        });
                });

            modelBuilder.Entity("AsyncDemo.Entities.Book", b =>
                {
                    b.Property<string>("BookId")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(2500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = "e4442934-1f90-458b-8ad8-b6be6433cc29",
                            AuthorId = "10ee7609-a4fb-4612-b4f1-8640c3f2248e",
                            Description = "R R Martin",
                            Title = "Guerra dos Tronos"
                        },
                        new
                        {
                            BookId = "a743e7d0-444c-4911-ba0f-ce5f8aa6977e",
                            AuthorId = "10ee7609-a4fb-4612-b4f1-8640c3f2248e",
                            Description = "R R Martin",
                            Title = "Fúria dos Reis"
                        },
                        new
                        {
                            BookId = "0e45f98b-4846-4553-9938-7debe5dbf4b9",
                            AuthorId = "64e4fd63-bae9-4755-be41-c960af184969",
                            Description = "Durante as férias de 1958, em uma pacata cidadezinha chamada Derry, um grupo de sete amigos começa a ver coisas estranhas",
                            Title = "It - A Coisa"
                        },
                        new
                        {
                            BookId = "c9c465f8-6e47-452a-b670-65dad84acf91",
                            AuthorId = "64e4fd63-bae9-4755-be41-c960af184969",
                            Description = "A Torre Negra, é uma série literária misturando alta fantasia, faroeste, ficção científica e terror numa narrativa que forma um mosaico da cultura popular contemporânea, o enredo segue um pistoleiro e sua busca em direção a uma torre, a Torre Negra, cuja natureza é tanto física quanto metafórica.",
                            Title = "A Torre Negra"
                        });
                });

            modelBuilder.Entity("AsyncDemo.Entities.Book", b =>
                {
                    b.HasOne("AsyncDemo.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}