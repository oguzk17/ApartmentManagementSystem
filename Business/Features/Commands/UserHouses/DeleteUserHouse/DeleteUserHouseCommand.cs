using Business.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Commands.UserHouses.DeleteUserHouse
{
	public class DeleteUserHouseCommand : IRequest<BaseResponse>
	{
		public int Id { get; set; }
	}
}
