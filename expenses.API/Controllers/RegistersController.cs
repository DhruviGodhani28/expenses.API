using expenses.API.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace expenses.API.Controllers
{
    // https://localhost:xxxx/api/registers
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        //
        [HttpPost]
        public Task<IActionResult> CreateUserId(Models.DTO.CreateUserIdRequestDto request)
        {
            //Map DTO to Domain Model
            var userId = new Register
            {
                UserId = request.UserId,
                CreatePassword = request.CreatePassword,
                ConfirmPassword = request.ConfirmPassword

            };
            return Ok("HI");
        }
    }
}
