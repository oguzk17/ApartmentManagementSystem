using Business.Models.UserHouses;
using Business.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Commands.UserHouses.UpdateUserHouse
{
	public class UpdateUserHouseCommand : UpdateUserHouseDto , IRequest<BaseValueResponse<UpdateUserHouseDto>>
	{
	}
}
