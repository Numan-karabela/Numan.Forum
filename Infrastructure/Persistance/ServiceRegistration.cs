using Application.Abstractions.Token;
using Application.Repository;
using Domain.Entities.Identity;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection; 
using Persistance.Context;
using Persistance.Repository;
using Persistance.Services.Token;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceService(this IServiceCollection service , IConfiguration Configration)
        {
            service.AddDbContext<ForumDbContext>(options => options.UseSqlServer(Configration.GetConnectionString("Sql")));
            service.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ForumDbContext>();
             
            service.AddScoped<ICommentRepository, CommentRepository>();
            service.AddScoped<ITokenHandler,TokenHandler>();
            service.AddScoped<IPostRepository, PostRepository>();
        }


    }
}
