using MaquinaDeTroco.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaquinaDeTroco.Application.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet("Get/{id:Guid}")]
		public IActionResult Get(Guid id)
		{
			if (id == Guid.Empty)
				return BadRequest();

			var result = _userService.GetById(id);

			if (result == null)
				return NotFound();

			return Ok(result);
		}
	}
}
