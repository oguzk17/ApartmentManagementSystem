using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Commands.UserHouses.AddUserHose
{
    public class AddUserHouseResponse
    { 
    public AddUserHouseResponse(bool status)
    {
        Status = status;
    }

    public AddUserHouseResponse(bool status, House house) : this(status)
    {

        House = house;
    }
    public bool Status { get; set; }
    public House House { get; set; }
}
}

