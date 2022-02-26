using Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	
	public class House:EntityBase
	{
		public int Block { get; set; }
		public int Floor { get; set; }
		public string HouseNumber { get; set; }
		public bool State { get; set; } // boş mu dolu mu
		public string HouseTypeId { get; set; } //2+1 3+1
		public HouseType HouseType { get; set; }
		public ICollection<UserHouse> UserHouses { get; set; }

	}
}
