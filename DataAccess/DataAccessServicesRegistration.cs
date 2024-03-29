﻿using Business.Contracts.Repositories.Commons;
using DataAccess.Contracts.Repositories.Commons;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataAccessServicesRegistration
    { 
     public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {

        

        services.AddDbContext<ApplicationDbContext>(options =>
      
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));




            return services;
    }
}
}
