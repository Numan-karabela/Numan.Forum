using Application.Repository;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace N_ForumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
       private readonly  IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public  async Task<IActionResult> Add(User user)
        {
            var users= await _userRepository.AddAsync(user);
            return Ok(users);
        }
        [HttpDelete("id")]
        public async Task<IActionResult> DeleteById(User user)
        {
         var delete=  await _userRepository.DeleteAsync(user);
            return Ok(delete);
            
        }
    

    }
}
