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

namespace Business.Features.Commands.Authentications.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, IdentityResult>
    {
        private readonly UserManager<Users> _userManager;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(UserManager<Users> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IdentityResult> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var updateUser = _userManager.FindByIdAsync(request.UserId.ToString()).Result;

            updateUser.Email = request.Email;
            updateUser.CarPlate = request.CarPlate;
            updateUser.Name = request.Name;
            updateUser.SurName = request.SurName;
            updateUser.TckNo = request.TcNo;

            var result = _userManager.UpdateAsync(updateUser);
            return result.Result;


        }
    }
}
