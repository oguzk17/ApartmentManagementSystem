using AutoMapper;
using Business.Models.Users;
using Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Features.Queries.Authentications.SignInUser
{
    public class SignInUserQueryHandler : IRequestHandler<SignInUserQuery, UserModel>
    {
        private readonly UserManager<Users> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<Role> _roleManager;

        public SignInUserQueryHandler(UserManager<Users> userManager,
           IMapper mapper,
           RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
        }
        public async Task<UserModel> Handle(SignInUserQuery request, CancellationToken cancellationToken)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Email == request.Email);

            if (user == null)
                return null;

            var userModel = new UserModel();

            var userSigingResult = await _userManager.CheckPasswordAsync(user, request.Password);

            if (userSigingResult)
            {
                userModel = _mapper.Map<UserModel>(user);
                userModel.Roles = await _userManager.GetRolesAsync(user);
            }
            else
            {
                throw new ApplicationException("Şifre hatalı.");
            }

            return userModel;
        }
    }
}
