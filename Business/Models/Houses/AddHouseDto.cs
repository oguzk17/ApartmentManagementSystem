using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Houses
{
 public class AddHouseDto
	{
        public int Block { get; set; }
        public int Floor { get; set; }
        public int HouseNumber { get; set; }
        public bool State { get; set; }
        public int HouseTypeId { get; set; }
    }
}
