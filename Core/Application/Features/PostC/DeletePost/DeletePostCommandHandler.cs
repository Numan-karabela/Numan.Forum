using Application.Repository;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PostC.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommandRequest, DeletePostCommandResponse>
    {
         IPostRepository _postRepository;

        public DeletePostCommandHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<DeletePostCommandResponse> Handle(DeletePostCommandRequest request, CancellationToken cancellationToken)
        {
           var sonuc=await _postRepository.DeleteAsync(new()
           {
               Id=request.id
           });
            if (sonuc == true)
            { 
                return new()
                {
                    Message = "true"
                };
            }
            return new()
            {
                Message = "false",
            };
            }
        }
    } 
    