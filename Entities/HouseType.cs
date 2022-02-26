using Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class HouseType:EntityBase
	{
		public string Type { get; set; }
		public ICollection<House> Houses { get; set; }
	}
}
