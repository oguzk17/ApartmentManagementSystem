using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Commands.Authentications.SignUpUser
{
	 public class SignUpUserCommand: IRequest<IdentityResult>
	{
		public string Email { get; set; }
		public string  Name { get; set; }
		public string SurName { get; set; }
		public string CarPlate { get; set; }
		public string TcNo { get; set; }
	}
}
