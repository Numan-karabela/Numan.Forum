using Application.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PostC.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommandRequest, CreatePostCommandResponse>
    {
        private readonly IPostRepository _postRepository;

        public CreatePostCommandHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<CreatePostCommandResponse> Handle(CreatePostCommandRequest request, CancellationToken cancellationToken)
        {
           var sonuc= await _postRepository.AddAsync(new()
            {
                UserId = request.UserId,
                CommentId = request.CommentId,
                Content = request.Content,
                Title = request.Title,
                DateTime=DateTime.Now,
            });

            if (sonuc==true)
            {
                return new()
                {
                    message = "True"
                };
            }
            else
            {
                return new()
                {
                    message = "False"
                };
            }

        }
    }
}
