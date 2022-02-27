using Business.Contracts.Repositories;
using DataAccess.Contracts.Repositories.Commons;
using DataAccess.Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts.Repositories
{
    public class DuesRepository : RepositoryBase<Dues>, IDuesRepository
    {
        public DuesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }

}