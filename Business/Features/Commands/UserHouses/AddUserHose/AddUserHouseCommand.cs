using Business.Models.UserHouses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Commands.UserHouses.AddUserHose
{
           public class AddUserHouseCommand : AddUserHouseDto, IRequest<AddUserHouseResponse>
	{
	}
}
