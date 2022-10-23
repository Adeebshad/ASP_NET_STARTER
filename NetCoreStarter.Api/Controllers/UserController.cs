using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestPractice.Core.Models.ResponseModels;
using TestPractice.Core.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestPractice.Api.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<UserViewModel>> GetAll()
        {
            return await _service.GetUsers();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserRequestModel requestModel)
        {
            await _service.SaveUser(requestModel);
            return Ok();
        }
    }
}
