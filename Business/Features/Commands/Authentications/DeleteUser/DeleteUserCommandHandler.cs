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

namespace Business.Features.Commands.Authentications.DeleteUser
{
	public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, IdentityResult>
	{
		private readonly UserManager<Users> _userManager;
		private readonly IMapper _mapper;

		public DeleteUserCommandHandler(UserManager<Users> userManager, IMapper mapper)
		{
			_userManager = userManager;
			_mapper = mapper;
		}
		public async Task<IdentityResult> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
		{
			var deleteUser = await _userManager.FindByIdAsync(request.UserId.ToString());
			var result = await _userManager.DeleteAsync(deleteUser);
			return result;
		}
	}
}
