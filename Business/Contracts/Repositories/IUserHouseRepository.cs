﻿using Business.Contracts.Repositories.Commons;
using Business.Models.UserHouses;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contracts.Repositories
{
	public interface  IUserHouseRepository: IRepositoryBase<UserHouse>
	{
		Task<UserHouseDto> GetUserHouseDetail();
	}
}
