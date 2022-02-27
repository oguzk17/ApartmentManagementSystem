using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Commands.Authentications.UpdateUser
{
	public class UpdateUserCommand : IRequest<IdentityResult>
	{
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TcNo { get; set; }
        public string CarPlate { get; set; }
    }
}
