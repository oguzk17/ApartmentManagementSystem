using Business.Models.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Queries.Authentications.GetUsers
{
	public class GetUserListQuery : IRequest<List<UserListModel>>
	{
	}
}
