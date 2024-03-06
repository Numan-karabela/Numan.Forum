using Domain.Entities.Identity;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CommentC.CreateComment
{
    public class CreateCommentCommandRequest:IRequest<CreateCommentCommandResponse>
    {
        public string Content { get; set; }//içerik 
        public int PostId { get; set; } 
        public int UserId{ get; set; }
        public DateTime DateTime { get; set; }
    }
}
