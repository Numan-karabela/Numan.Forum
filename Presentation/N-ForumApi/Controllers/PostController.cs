using Application.Features.CommentC.CreateComment;
using Application.Features.PostC.CreatePost;
using MediatR; 
using Microsoft.AspNetCore.Mvc;
 

namespace N_ForumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> PostCreate(CreatePostCommandRequest createPostCommandRequest)
        {
         
            CreatePostCommandResponse response= await _mediator.Send(createPostCommandRequest);
            return Ok(response);
        }
       
        //[HttpDelete("deleteId")]
        //public async Task<IActionResult> PostDelete()
        //{
        //    return Ok();

        //}
        //[HttpGet]
        //public async Task<IActionResult> PostGet()
        //{
        //    return Ok();
        //}
    }
}
