using Business.Features.Commands.Authentications.SignUpUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{

		[HttpPost("SignUp")]
		public async Task<IActionResult> SignUp(SignUpUserCommand signUpUserCommand)
		{
			return Ok();
		}
	}
}
