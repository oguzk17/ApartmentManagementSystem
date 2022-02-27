using AutoMapper;
using Business.Contracts.Repositories;
using Business.Exceptions;
using Business.Models.UserHouses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Features.Queries.UserHouses
{
        public class GetHouseQueryHandler : IRequestHandler<GetHouseQuery, List<UserHouseDto>>
        {
            private readonly IUserHouseRepository _userHouseRepository;
            private readonly IMapper _mapper;

            public GetHouseQueryHandler(IUserHouseRepository userResidenceRepository, IMapper mapper)
            {
                _userHouseRepository = userResidenceRepository;
                _mapper = mapper;
            }

            public async Task<List<UserHouseDto>> Handle(GetHouseQuery request, CancellationToken cancellationToken)
            {
                var id = request.UserId;
                var residenceDetail = await _userHouseRepository.GetAllAsync(u => u.UserId == id);
                if (residenceDetail == null || residenceDetail.Count == 0)
                    throw new NotFoundException("Dairesi yok", id);

                return _mapper.Map<List<UserHouseDto>>(residenceDetail);
            }
        }
 }

