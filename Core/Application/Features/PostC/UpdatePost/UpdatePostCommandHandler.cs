using Application.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.PostC.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommandRequest, UpdatePostCommandResponse>
    {
        IPostRepository _repository;

        public UpdatePostCommandHandler(IPostRepository repository)
        {
            _repository = repository;
        }

        public async Task<UpdatePostCommandResponse> Handle(UpdatePostCommandRequest request, CancellationToken cancellationToken)
        {
          var a= await   _repository.UpdateAsync(new()
            {   Id=request.id,
                Title= request.Title,
                Content= request.Content,
            });

            if (a==true)
            {
                return new()
                {
                    Message = "true"
                };
            }
                return new()
                {
                    Message = "false"
                };
            
           
          
        }
    }
}
