using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.PaymentControl
{
	public class RabbitPayDto
	{
		public int HouseBillId { get; set; }
		public int Fee { get; set; }
		public string Name { get; set; }
		public string SurName { get; set; }
		public int CardNumber { get; set; }

	}
}
