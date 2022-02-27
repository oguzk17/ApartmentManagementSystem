using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions
{
	 public class FounderException :ApplicationException
	{
		public FounderException(string name)
		   : base($"Entity \"{name}\" was already exist...")
		{
		}
	}
}
