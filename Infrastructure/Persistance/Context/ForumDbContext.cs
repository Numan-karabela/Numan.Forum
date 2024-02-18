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
    public class ForumDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NForumDb;Integrated Security=True;");
        }
        
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
