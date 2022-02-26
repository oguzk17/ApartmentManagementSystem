using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts.Repositories
{
    public class BillsRepository : RepositoryBase<Bills>, IBillsRepository
    {
        public BillsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
