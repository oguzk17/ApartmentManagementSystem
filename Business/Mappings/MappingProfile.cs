using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mappings
{
	public class MappingProfile :Profile
  	{
		#region  Authentications
		public MappingProfile()
		{
			CreateMap<User, SignUpUserCommands>().ReverseMap();
			CreateMap<User, UserModel>().ReverseMap();
		}
		#endregion 

	}
}
