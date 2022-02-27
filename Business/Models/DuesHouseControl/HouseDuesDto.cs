using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.DuesHouseControl
{
	public class HouseDuesDto
	{
        public int Id { get; set; }
        public int DuesYear { get; set; }
        public int DuesMonth { get; set; }
        public int UserHouseHouseBlock { get; set; }
        public int UserHouseHouseFloor { get; set; }
        public int UserHouseHouseHouseNumber { get; set; }
        public string UserHouseName { get; set; }
        public string UserHouseSurName { get; set; }
        public int DuesFee { get; set; }
        public bool IsPaid { get; set; }
        public string UserHouseHouseTypeType { get; set; }
    }
}
