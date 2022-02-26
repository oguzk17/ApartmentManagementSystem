using Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class DuesHouse :EntityBase
	{
		public int DuesId { get; set; }
		public Dues Dues { get; set; }
		public int UserHouseId { get; set; }
		public UserHouse UserHouses { get; set; }
		public bool IsPaid { get; set; }
	}
}
