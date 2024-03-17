using Application.Repository;
using MediatR;
using FluentValidation.Results;
using Application.Validators;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http.HttpResults;
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
            Post a = new Post();
            a.Title = request.Title;
            a.Content = request.Content;
            a.UserId = request.UserId;
            a.CommentId = request.CommentId;


            PostValidator valid= new PostValidator();
            ValidationResult result = valid.Validate(a);
            


            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                   string pp = item.ErrorMessage;

                    return new()
                    {
                        message = pp
                    };
                }
               

            }
            
            var sonuc = result.Errors.ToList();
                await _postRepository.AddAsync(new()
                {
                    UserId = request.UserId,
                    CommentId = request.CommentId,
                    Content = request.Content,
                    Title = request.Title,
                    DateTime = DateTime.Now,
                });
                return new()
                {
                    message ="true"
                }; 
        }
    }
}
