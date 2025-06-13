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
        modelBuilder.Entity<Movie>().Property(p => p.IMDB).HasPrecision(4, 2);
        modelBuilder.Entity<Movie>().Property(p => p.Name).HasMaxLength(100).IsRequired();
        modelBuilder.Entity<Movie>().HasKey(p => p.Id);
        modelBuilder.Entity<Movie>().HasOne(p => p.Category).WithMany(c => c.Movies).HasForeignKey(p => p.CategoryId);

        modelBuilder.Entity<Category>().Property(c => c.Name).HasMaxLength(50).IsRequired();
        modelBuilder.Entity<Category>().Property(c => c.Description).HasMaxLength(250);
        base.OnModelCreating(modelBuilder);



        //SEED DATA
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = Guid.NewGuid(), Name = "Aksiyon" },
            new Category { Id = Guid.NewGuid(), Name = "Komedi" },
            new Category { Id = Guid.NewGuid(), Name = "Bilim Kurgu" },
            new Category { Id = Guid.NewGuid(), Name = "Belgesel" },
            new Category { Id = Guid.NewGuid(), Name = "Fantastik" },
            new Category { Id = Guid.NewGuid(), Name = "Korku" }
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


