using AutoMapper;
using Business.Contracts.Repositories;
using Business.Exceptions;
using Business.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Features.Commands.UserHouses.DeleteUserHouse
{
    public class DeleteUserHouseCommandHandler : IRequestHandler<DeleteUserHouseCommand, BaseResponse>
    {
        private readonly IUserHouseRepository _userHouseRepository;
        private readonly IMapper _mapper;

        public DeleteUserHouseCommandHandler(IUserHouseRepository userResidenceRepository, IMapper mapper)
        {
            _userHouseRepository = userResidenceRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(DeleteUserHouseCommand request, CancellationToken cancellationToken)
        {
            var delelteItem = await _userHouseRepository.GetByIdAsync(request.Id);
            if (delelteItem == null)
                throw new NotFoundException(request);
            await _userHouseRepository.RemoveAsync(delelteItem);
            return new BaseResponse(true);
        }
    }
}
