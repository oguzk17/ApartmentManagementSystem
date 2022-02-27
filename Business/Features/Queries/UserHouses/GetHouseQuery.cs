using Business.Models.UserHouses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Queries.UserHouses
{
	public class GetHouseQuery : IRequest<List<UserHouseDto>>
	{
		public int UserId { get; set; }
	}
}
