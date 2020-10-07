using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.DataAccess.Configuration;
using WebShop.Models;

namespace WebShop.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BookAuthorConfiguration());

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    AuthorId = 1,
                    Name = "Vilheml Moberg"
                },
                new Author
                {
                    AuthorId = 2,
                    Name = "Ray Celestin"
                }
            );
            modelBuilder.Entity<Book>().HasData(
                    new Book
                    {
                        BookId = 1,
                        Title = "Utvandrarna"
                    },
                    new Book
                    {
                        BookId = 2,
                        Title = "Yxmannen"
                    }
                );
        }
    }
}
