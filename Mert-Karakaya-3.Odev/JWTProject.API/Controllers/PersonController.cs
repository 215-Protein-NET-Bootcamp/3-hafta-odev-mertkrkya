using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTProject.Core.Entities;
using JWTProject.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace JWTProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _service;
        private readonly ILogger<PersonController> _logger;
        public PersonController(IPersonService service, ILogger<PersonController> logger)
        {
            _service = service;
            _logger = logger;
        }
        [HttpGet("GetPeopleByAccountId")]
        public async Task<IActionResult> GetPeopleByAccountId()
        {
            int accountId = -1;
            var controlAccountId = User.Claims.FirstOrDefault(r => r.Type == "AccountId");
            if (controlAccountId == null)
                return BadRequest(new ResponseEntity("Öngörülemeyen bir hata meydana geldi."));
            accountId = Convert.ToInt32(controlAccountId.Value);
            var result = await _service.GetPeopleByAccountIdAsync(accountId);
            if (!result.isSuccess)
                return BadRequest(result);
            _logger.LogInformation($"{User.Identity.Name} kullanıcısının person nesneleri alındı.");
            return Ok(result);
        }
    }
}
