using Application.Features.AppUserC.CreateUser;
using Application.Features.AppUserC.LoginAppUser;
using Application.Repository;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace N_ForumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes ="Admin")]
    public class UserController : ControllerBase
    {

       readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> UserCreate(CreateUserrCommandRequest createUserrCommandRequest)
        {
            CreateUserrCommandResponse response = await _mediator.Send(createUserrCommandRequest);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginUserrCommandRequest loginUserrCommandRequest)
        {
           LoginUserrCommandResponse response = await _mediator.Send(loginUserrCommandRequest);
            return Ok(response);
        }

    }
}
