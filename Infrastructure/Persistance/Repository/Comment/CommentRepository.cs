using Application.Repository;
using Domain.Entities;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repository
{
    public class CommentRepository : EfCoreRepository<Comment, ForumDbContext>,ICommentRepository
    {
        public CommentRepository(ForumDbContext context) : base(context)
        {
        }
    }
}
