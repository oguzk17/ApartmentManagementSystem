using AutoMapper;
using Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Features.Commands.Authentications.SignUpUser.NewFolder
{
	public class SignUpUserCommandHandler : IRequestHandler<SignUpUserCommand, int>
	{
		private readonly UserManager<Users> _userManager;
		private readonly IMapper _mapper;
		private readonly RoleManager<Role> _roleManager;

		public SignUpUserCommandHandler(UserManager<Users> userManager, RoleManager<Role> roleManager, IMapper mapper)
		{
			_userManager = userManager;
			_roleManager = roleManager;
			_mapper = mapper;
		}
		public Task<int> Handle(SignUpUserCommand request, CancellationToken cancellationToken)
		{
			var userEntity = _mapper.Map<Users>(request);
			throw new NotImplementedException();
		}
	}
}
