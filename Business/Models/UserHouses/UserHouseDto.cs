using Business.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.UserHouses
{
	public class UserHouseDto
	{
		public UserDto User { get; set; }

		public AddUserHouseDto House { get; set; }

		public string HouseTypeType { get; set; }

	}
}
