using Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class HouseBill: EntityBase
	{ 
		public int HouseBillId { get; set; }
		public int BillId { get; set; }
		public Bills Bills { get; set; }
		 public int UserHouseId { get; set; }
		public UserHouse UserHouse { get; set; }
		public bool IsPaid { get; set; }
	}
}
