using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts.Repositories
{
	public class DuesHouseRepository : RepositoryBase<DuesHouse>, IDuesHouseRepository

	{
		public DuesHouseRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
		}
	}
}
