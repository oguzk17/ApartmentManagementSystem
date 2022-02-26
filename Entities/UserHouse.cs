using Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class UserHouse : EntityBase
	{
		public int UserId { get; set; }
		public Users User { get; set; }
		public int HouseId { get; set; }
		public House House { get; set; }
		public int HouseOwnerTypeId { get; set; }
		public HouseOwnerType HouseOwnerTypes { get; set;}
		public IEnumerable<HouseBill> HouseBills { get; set; }
		public IEnumerable<DuesHouse> DuesHouses { get; set; }


	}
}
