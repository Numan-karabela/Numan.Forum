using Application.Features.CommentC.CreateComment;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace N_ForumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {

      private readonly IMediator _mediator;

        public CommentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CommentsCreate(CreateCommentCommandRequest createCommentCommandRequest)
        { 
            CreateCommentCommandResponse response= await _mediator.Send(createCommentCommandRequest);
            return Ok(response);
        }

       


    }
}
