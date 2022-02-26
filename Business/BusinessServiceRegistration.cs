using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddABusinessService(this IServiceCollection services,
              IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        

            #region FluentValidaton Control
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddControllers()
            .AddNewtonsoftJson(options =>
                        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore)
            .AddFluentValidation(fv =>
            {
                fv.RegisterValidatorsFromAssemblyContaining<SignUpUserValidator>();
                fv.RegisterValidatorsFromAssemblyContaining<SignInUserValidator>();

            }
            );

            #endregion




            return services;
        }
    }
}
