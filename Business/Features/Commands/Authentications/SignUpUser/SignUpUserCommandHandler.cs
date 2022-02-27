using AutoMapper;
using Business.Exceptions;
using Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Features.Commands.Authentications.SignUpUser
{
    public class SignUpUserCommandHandler : IRequestHandler<SignUpUserCommand, IdentityResult>
    {
        private readonly UserManager<Users> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<Role> _roleManager;
        public SignUpUserCommandHandler(
                 IMapper mapper,
                 UserManager<Users> userManager,
                 RoleManager<Role> roleManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;

        }

        public async Task<IdentityResult> Handle(SignUpUserCommand request, CancellationToken cancellationToken)
        {
            var userEntity = _mapper.Map<Users>(request);

            userEntity.UserName = userEntity.Email;
            var defaultPassword = "Abcd12!!";
            var checkNationalIdentity = await _userManager.Users.FirstOrDefaultAsync(r => r.TckNo == request.TcNo);
            if (checkNationalIdentity != null)
                throw new NotEmptyException("Tc Kimlik Bilgisi kayıtlı .");

            var checkCarPlate = await _userManager.Users.FirstOrDefaultAsync(r => r.CarPlate == request.CarPlate);

            if (checkCarPlate != null)
                throw new NotEmptyException("Araç plaka Bilgisi kayıtlı.");

            var userCreateResult = await _userManager.CreateAsync(userEntity, defaultPassword);

            if (userCreateResult.Succeeded)
            {
                await _userManager.Users.SingleOrDefaultAsync(u => u.Email == request.Email);
                await _userManager.AddToRoleAsync(userEntity, "User");
                return userCreateResult;
            }


            return userCreateResult;
        }


    }
}
