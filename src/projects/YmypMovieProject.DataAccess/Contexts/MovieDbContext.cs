using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.DataAccess.Contexts;
public sealed class MovieDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=AKINCENGIZ;Initial Catalog=YmypMovieDb;Integrated Security=True;Trust Server Certificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //MOVIE MODEL CONFIGURATION
        modelBuilder.Entity<Movie>().Property(m => m.Name).HasMaxLength(100).IsRequired();
        modelBuilder.Entity<Movie>().Property(m => m.Description).HasMaxLength(500);
        modelBuilder.Entity<Movie>().Property(p => p.IMDB).HasPrecision(4, 2);
        modelBuilder.Entity<Movie>().HasKey(p => p.Id);
        modelBuilder.Entity<Movie>().HasOne(p => p.Category).WithMany(c => c.Movies).HasForeignKey(p => p.CategoryId);


        //CATEGORY MODEL CONFIGURATION
        modelBuilder.Entity<Category>().Property(c => c.Name).HasMaxLength(50).IsRequired();
        modelBuilder.Entity<Category>().Property(c => c.Description).HasMaxLength(250);

        //DIRECTOR MODEL CONFIGURATION
        modelBuilder.Entity<Director>().Property(d => d.FirstName).HasMaxLength(50).IsRequired();
        modelBuilder.Entity<Director>().Property(d => d.LastName).HasMaxLength(50).IsRequired();
        modelBuilder.Entity<Director>().Property(d => d.Description).HasMaxLength(250);
        base.OnModelCreating(modelBuilder);


        var categoryId = Guid.Parse("7FE0AC2B-FA60-4004-A579-C5967A1746A1");
        var directorId = Guid.Parse("2950D635-D293-4C82-A9FB-F23F8CFA5956");


        //SEED DATA FOR CATEGORIES
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = categoryId, Name = "Aksiyon" },
            new Category { Id = Guid.NewGuid(), Name = "Komedi" },
            new Category { Id = Guid.NewGuid(), Name = "Bilim Kurgu" },
            new Category { Id = Guid.NewGuid(), Name = "Belgesel" },
            new Category { Id = Guid.NewGuid(), Name = "Fantastik" },
            new Category { Id = Guid.NewGuid(), Name = "Korku" }
        );
        //SEED DATA FOR DIRECTORS
        modelBuilder.Entity<Director>().HasData(
            new Director { Id = directorId, FirstName = "Christopher", LastName = "Nolan", BirthDate = new DateTime(1970, 7, 30), Description = "British-American film director, producer, and screenwriter." },
            new Director { Id = Guid.NewGuid(), FirstName = "Steven", LastName = "Spielberg", BirthDate = new DateTime(1946, 12, 18), Description = "American film director, producer, and screenwriter." },
            new Director { Id = Guid.NewGuid(), FirstName = "Martin", LastName = "Scorsese", BirthDate = new DateTime(1942, 11, 17), Description = "American film director, producer, screenwriter, and actor." },
            new Director { Id = Guid.NewGuid(), FirstName = "Quentin", LastName = "Tarantino", BirthDate = new DateTime(1963, 3, 27), Description = "American filmmaker, actor, and screenwriter." },
            new Director { Id = Guid.NewGuid(), FirstName = "James", LastName = "Cameron", BirthDate = new DateTime(1954, 8, 16), Description = "Canadian filmmaker and environmental advocate." }
        );
        

        //SEED DATA FOR MOVIES
        modelBuilder.Entity<Movie>().HasData(
            new Movie { Id = Guid.NewGuid(), Name = "Inception", Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", IMDB = 8.8m, PublishDate = new DateTime(2010, 7, 16), CategoryId = categoryId, DirectorId = directorId },
            new Movie { Id = Guid.NewGuid(), Name = "The Dark Knight", Description = "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", IMDB = 9.0m, PublishDate = new DateTime(2008, 7, 18), CategoryId = categoryId, DirectorId = directorId },
            new Movie { Id = Guid.NewGuid(), Name = "Interstellar", Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", IMDB = 8.6m, PublishDate = new DateTime(2014, 11, 7), CategoryId = categoryId, DirectorId = directorId }
        );



        //modelBuilder.Entity<Deneme>().HasData(
        //    new Deneme { Id = Guid.NewGuid(), Name = "Deneme 1"  },
        //    new Deneme { Id = Guid.NewGuid(), Name = "Deneme 2" },
        //    new Deneme { Id = Guid.NewGuid(), Name = "Deneme 3" },
        //    new Deneme { Id = Guid.NewGuid(), Name = "Deneme 4" }
        //);

    }



    public DbSet<Actor> Actors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Director> Directors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    //public DbSet<Deneme> Denemes { get; set; }
}


