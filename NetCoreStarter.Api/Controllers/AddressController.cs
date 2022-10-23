using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestPractice.Core.Models.RequestModels;
using TestPractice.Core.Models.ViewModels;
using TestPractice.Core.Services.Interfaces;

namespace TestPractice.Api.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    //[Authorize]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _service;
        public AddressController(IAddressService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<AddressViewModel>> GetAll()
        {
            return await _service.GetAddresses();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddressRequestModel requestModel)
        {
            await _service.SaveAddress(requestModel);
            return Ok();
        }
    }
}
