using AutoMapper;
using Business.Contracts.Repositories;
using Business.Exceptions;
using Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Features.Commands.UserHouses.AddUserHose
{
	public class AddUserHouseCommandHandler : IRequestHandler<AddUserHouseCommand, AddUserHouseResponse>
	{
		private readonly IUserHouseRepository _userHouseRepository;
		private readonly IHouseRepository _houseRepository;
		private readonly IMapper _mapper;

		public AddUserHouseCommandHandler(IUserHouseRepository userHouseRepository, IMapper mapper, IHouseRepository residenceRepository)
		{
			_userHouseRepository = userHouseRepository;
			_mapper = mapper;
			_houseRepository = residenceRepository;
		}
		public async Task<AddUserHouseResponse> Handle(AddUserHouseCommand request, CancellationToken cancellationToken)
		{
			var isExist = await _houseRepository.GetAsync(u => u.Id == request.HouseId);
			if (isExist.State == true)
				throw new NotEmptyException("Dolu daire.");

			var entity = _mapper.Map<UserHouse>(request);
			await _userHouseRepository.AddAsync(entity);

			isExist.State = true;
			await _houseRepository.UpdateAsync(isExist);
			return new AddUserHouseResponse(true);

		}
	}
}
