using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Commons
{
	public class PayBase :EntityBase
	{
		public int Payment { get; set; }
		public int Year { get; set; }
		public int Month { get; set; }
	}
}
