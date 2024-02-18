﻿using Application.Repository;
using Domain.Entities.Identity;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Context;
using Persistance.Repository;
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
        public static void AddPersistanceService(this IServiceCollection service)
        {
            service.AddDbContext<ForumDbContext>();
            service.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ForumDbContext>();
             
            service.AddScoped<ICommentRepository, CommentRepository>();
            service.AddScoped<IPostRepository, PostRepository>();
        }


    }
}
