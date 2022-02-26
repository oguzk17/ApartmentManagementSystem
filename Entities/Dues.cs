using Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Dues :PayBase
	{
		public ICollection<DuesHouse> DuesHouses { get; set; }
	}
}
