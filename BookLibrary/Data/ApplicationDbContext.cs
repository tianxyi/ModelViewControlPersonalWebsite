using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookLibrary.Models;

namespace BookLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Block> Blocks { get; set; }

        public DbSet<Record> Records { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Book>().HasData(
        //        new Book
        //        {
        //            BookId = 1,
        //            Name = "Journey to the West",
        //            Author = "Chengen Wu",
        //            Genre = "East Magic",
        //            Publisher = "Beijing Publisher"
        //        },

        //        new Book
        //        {
        //            BookId = 2,
        //            Name = "The Three-Body Problem",
        //            Author = "Liu Cixin",
        //            Genre = "East Magic",
        //            Publisher = "Shanghai Publisher"
        //        },

        //        new Book
        //        {
        //            BookId = 3,
        //            Name = "Game of Thrones",
        //            Author = "George R.R. Martin",
        //            Genre = "West Magic",
        //            Publisher = "Bantam Spectra"
        //        },

        //        new Book
        //        {
        //            BookId = 4,
        //            Name = "Harry Potter",
        //            Author = "J.K. Rowling",
        //            Genre = "West Magic",
        //            Publisher = "Pottermore"
        //        }
        //        );
        //}
    }
}