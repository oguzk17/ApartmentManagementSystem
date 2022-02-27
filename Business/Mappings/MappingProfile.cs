using AutoMapper;
using Business.Features.Commands.Authentications.SignUpUser;
using Business.Features.Commands.Authentications.UpdateUser;
using Business.Models.Users;
using Entities;
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
			CreateMap<Users, UserDto>().ReverseMap();
			CreateMap<Users, UserModel>().ReverseMap();
			CreateMap<SignUpUserCommand, Users>().ReverseMap();
			CreateMap<SignInUserQuery, Users>().ReverseMap();
			CreateMap<Users, UserListModel>().ReverseMap();
			CreateMap<Users, UserUpdateDto>().ReverseMap();
			CreateMap<Users, UpdateUserCommand>().ReverseMap();
		}
		#endregion 

	}
}
