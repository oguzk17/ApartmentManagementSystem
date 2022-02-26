using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Users: IdentityUser<int>
	{   
		public string Name { get; set; }
		public string SurName { get; set; }
		public  string TckNo { get; set; }
		public string  CarPlate { get; set; }
		public ICollection<UserHouse> UserHouses { get; set; }

	}
}
