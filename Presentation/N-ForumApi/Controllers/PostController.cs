using Application.Features.CommentC.CreateComment;
using Application.Features.PostC.CreatePost;
using Application.Features.PostC.DeletePost;
using Application.Features.PostC.GetPost;
using Application.Features.PostC.UpdatePost;
using Application.Repository;
using Domain.Entities;
using MediatR; 
using Microsoft.AspNetCore.Mvc;
using Persistance.Context;
using System.Data.Entity;


namespace N_ForumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        IMediator _mediator; 

        public PostController(IMediator mediator )
        {
            _mediator = mediator; 
        }

        [HttpPost]
        public async Task<IActionResult> PostCreate(CreatePostCommandRequest createPostCommandRequest)
        {
         
            CreatePostCommandResponse response= await _mediator.Send(createPostCommandRequest);
            return Ok(response);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> PostDelete(DeletePostCommandRequest deletePostCommandRequest)
        {
             DeletePostCommandResponse response= await _mediator.Send(deletePostCommandRequest);
            return Ok(response);

        }
        [HttpPut]
        public async Task<IActionResult> PostUpdate(UpdatePostCommandRequest updatePostCommandRequest)
        {
            UpdatePostCommandResponse response = await _mediator.Send(updatePostCommandRequest);
            return Ok(response);

        }


        [HttpGet]
        public async Task<IActionResult> PostGet([FromQuery]GettPostQueryRequest gettPostQueryRequest)
        {
           GettPostQueryResponse response= await _mediator.Send(gettPostQueryRequest);
            return Ok(response);
        }
    }
}
