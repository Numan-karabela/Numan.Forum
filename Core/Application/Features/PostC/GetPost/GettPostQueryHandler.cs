using Application.Repository;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PostC.GetPost
{
    public class GettPostQueryHandler : IRequestHandler<GettPostQueryRequest, GettPostQueryResponse>
    {
        
        private readonly IPostRepository _postRepository;

        public GettPostQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<GettPostQueryResponse> Handle(GettPostQueryRequest request, CancellationToken cancellationToken)
        {
           var post= await _postRepository.GetAsync(p=>p.Id==request.id);

            if (post!=null)
            {
                return new()
                {
                    UserId = post.UserId,
                    Title = post.Title,
                    Content = post.Content,
                }; 
            }
            return new();
           
        }
    }
}
