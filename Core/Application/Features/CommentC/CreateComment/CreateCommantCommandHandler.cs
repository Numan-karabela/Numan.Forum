using Application.Repository;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CommentC.CreateComment
{
    public class CreateCommantCommandHandler : IRequestHandler<CreateCommentCommandRequest, CreateCommentCommandResponse>
    {
        ICommentRepository _commentRepository;

        public CreateCommantCommandHandler(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<CreateCommentCommandResponse> Handle(CreateCommentCommandRequest request, CancellationToken cancellationToken)
        {

       bool sonuc= await  _commentRepository.AddAsync(new()
            {
                Content = request.Content,
                PostId = request.PostId,
                UserId = request.UserId,
                DateTime = DateTime.Now,

       });

            if (sonuc==true)
            {
                return new()
                {
                    message = "true"
                };
            }
            else
            {
                return new()
                {

                    message = "false"
                };
            }
        }
    }
}
