using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PostC.CreatePost
{
    public class CreatePostCommandRequest:IRequest<CreatePostCommandResponse>
    {
        public string Title { get; set; }//başlık
        public string Content { get; set; }//içerik 
        public int UserId { get; set; }//yazan kullanıcı
        public int CommentId { get; set; }
        public DateTime DateTime { get; set; }
    }
}
