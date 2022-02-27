using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.UserHouses
{
	public class UpdateUserHouseDto
    { 
    public int Id { get; set; }
    public int UserId { get; set; }

    public int HouseId { get; set; }

    public int HouseTypeId { get; set; }
}
}
