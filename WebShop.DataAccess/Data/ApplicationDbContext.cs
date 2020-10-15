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
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BookAuthorConfiguration());

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    AuthorId = 1,
                    Name = "Vilhelm Moberg"
                },
                new Author
                {
                    AuthorId = 2,
                    Name = "Ray Celestin"
                },
                new Author
                {
                    AuthorId = 3,
                    Name = "Kajsa Ingemarsson"
                },
                new Author
                {
                    AuthorId = 4,
                    Name = "Doris Lessing"
                },
                new Author
                {
                    AuthorId = 5,
                    Name = "Frida Skybäck"
                },
                new Author
                {
                    AuthorId = 6,
                    Name = "John Steinbeck"
                },
                new Author
                {
                    AuthorId = 7,
                    Name = "Selma Lagerlöf"
                },
                new Author
                {
                    AuthorId = 8,
                    Name = "Nick Hornby"
                },
                new Author
                {
                    AuthorId = 9,
                    Name = "Eva Rönnblom"
                },
                new Author
                {
                    AuthorId = 10,
                    Name = "Hiro Arikawa"
                },
                new Author
                {
                    AuthorId = 11,
                    Name = "E.H. Gombrich"
                },
                new Author
                {
                    AuthorId = 12,
                    Name = "Haruki Murakami"
                },
                new Author
                {
                    AuthorId = 13,
                    Name = "Mikael Bergstrand"
                },
                new Author
                {
                    AuthorId = 14,
                    Name = "James Joyce"
                },
                new Author
                {
                    AuthorId = 15,
                    Name = "Michael Gibson"
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
                    },
                    new Book
                    {
                        BookId = 3,
                        Title = "Den ryske vännen"
                    },
                    new Book
                    {
                        BookId = 4,
                        Title = "Om katter"
                    },
                    new Book
                    {
                        BookId = 5,
                        Title = "Bokhandeln på Riverside Drive"
                    },
                    new Book
                    {
                        BookId = 6,
                        Title = "Möss och människor"
                    },
                    new Book
                    {
                        BookId = 7,
                        Title = "Nils Holgerssons underbara resa genom Sverige"
                    },
                    new Book
                    {
                        BookId = 8,
                        Title = "High fidelity"
                    },
                    new Book
                    {
                        BookId = 9,
                        Title = "Så frön från exotiska frukter"
                    },
                    new Book
                    {
                        BookId = 10,
                        Title = "En katts resedagbok"
                    },
                    new Book
                    {
                        BookId = 11,
                        Title = "Art & Illusion"
                    },
                    new Book
                    {
                        BookId = 12,
                        Title = "Kafka på stranden"
                    },
                    new Book
                    {
                        BookId = 13,
                        Title = "Delhis vackraste händer"
                    },
                    new Book
                    {
                        BookId = 14,
                        Title = "Odysseus"
                    },
                    new Book
                    {
                        BookId = 15,
                        Title = "Grekisk mytologi: Antikens gudar och hjältar"
                    }
                );
        }
    }
}