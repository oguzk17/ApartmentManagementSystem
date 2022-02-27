using AutoMapper;
using Business.Contracts.Repositories;
using Business.Exceptions;
using Business.Models.UserHouses;
using Business.Responses;
using Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Features.Commands.UserHouses.UpdateUserHouse
{
	public class UpdateUserHouseCommandHandler : IRequestHandler<UpdateUserHouseCommand, BaseValueResponse<UpdateUserHouseDto>>
	{
        private IUserHouseRepository _userHouseRepository;
        private readonly IMapper _mapper;

        public UpdateUserHouseCommandHandler(IUserHouseRepository userHouseRepository, IMapper mapper)
        {
            _userHouseRepository = userHouseRepository;
            _mapper = mapper;
        }

        public async Task<BaseValueResponse<UpdateUserHouseDto>> Handle(UpdateUserHouseCommand request, CancellationToken cancellationToken)
        {
            var updateUserHouse = await _userHouseRepository.GetByIdAsync(request.Id);

            if (updateUserHouse == null)
            {
                throw new NotFoundException(nameof(UserHouse), request.Id);
            }
            var checkExist = await _userHouseRepository.GetAsync(r => r.HouseId == request.HouseId);
            if (checkExist != null)
                throw new NotEmptyException(request.Id.ToString());

            _mapper.Map(request, updateUserHouse, typeof(UpdateUserHouseCommand), typeof(UserHouse));

            await _userHouseRepository.UpdateAsync(updateUserHouse);
            //var returnResidence = _mapper.Map<UpdateUserResidenceDto>(updateUserResidence);
            return new BaseValueResponse<UpdateUserHouseDto>(true, request);
        }
    
}
}
