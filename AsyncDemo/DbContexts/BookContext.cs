namespace AsyncDemo.DbContexts
{
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Book?> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author("10ee7609-a4fb-4612-b4f1-8640c3f2248e", "George", "R R Martin"),
                new Author("64e4fd63-bae9-4755-be41-c960af184969", "Stephen", "King"),
                new Author("de234a63-3b75-42e3-b2db-e8c19f471bb6", "Bernard", "Cornwell"),
                new Author("4028a23e-4b18-4c92-bda9-6c7c803c44eb", "Ken", "Follet"),
                new Author("72365587-9a11-4e05-8245-117b2349df32", "Conn", "Iggulden")
            );

            modelBuilder.Entity<Book>().HasData(
                new Book("e4442934-1f90-458b-8ad8-b6be6433cc29", 
                    "10ee7609-a4fb-4612-b4f1-8640c3f2248e",
                    "Guerra dos Tronos", "R R Martin"),
                
                new Book("a743e7d0-444c-4911-ba0f-ce5f8aa6977e", 
                    "10ee7609-a4fb-4612-b4f1-8640c3f2248e",
                    "Fúria dos Reis", "R R Martin"),
                
                new Book("0e45f98b-4846-4553-9938-7debe5dbf4b9", 
                    "64e4fd63-bae9-4755-be41-c960af184969", 
                    "It - A Coisa",
                    "Durante as férias de 1958, em uma pacata cidadezinha chamada Derry, um grupo de sete amigos começa a ver coisas estranhas"),
                
                new Book("c9c465f8-6e47-452a-b670-65dad84acf91", 
                    "64e4fd63-bae9-4755-be41-c960af184969",
                    "A Torre Negra",
                    "A Torre Negra, é uma série literária misturando alta fantasia, faroeste, ficção científica e terror numa narrativa que forma um mosaico da cultura popular contemporânea, o enredo segue um pistoleiro e sua busca em direção a uma torre, a Torre Negra, cuja natureza é tanto física quanto metafórica.")
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}