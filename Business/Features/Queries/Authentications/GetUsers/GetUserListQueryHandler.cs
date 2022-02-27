using AutoMapper;
using Business.Models.Users;
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

namespace Business.Features.Queries.Authentications.GetUsers
{
    public class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, List<UserListModel>>
    {
        private readonly UserManager<Users> _userManager;
        private readonly IMapper _mapper;

        public GetUserListQueryHandler(UserManager<Users> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<List<UserListModel>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            var list = await _userManager.Users.ToListAsync();
            var res = _mapper.Map<List<UserListModel>>(list);
            return res;
        }
    }
}
