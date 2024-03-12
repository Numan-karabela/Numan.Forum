using Domain.Entities;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Context
{
    public class ForumDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public ForumDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }

        //on created ekle


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Comment>(a =>
            {
                a.Property(i=>i.PostId).IsRequired();
                a.Property(i=>i.UserId).IsRequired();
                a.Property(i=>i.Content).IsRequired();
            });

            builder.Entity<Post>(a =>
            {
                a.Property(i => i.UserId).IsRequired();
                a.Property(i => i.Content).IsRequired();
                a.Property(i=>i.Title).IsRequired(); 

            });
            builder.Entity<AppUser>(a =>
            {
                a.Property(i=>i.Email).IsRequired();
                a.Property(i=>i.Name).IsRequired();
                a.Property(i=>i.SurName).IsRequired();
            });
            //Kalan her şey standart kalmasınu istedim 


            base.OnModelCreating(builder);
        }

    }
}
