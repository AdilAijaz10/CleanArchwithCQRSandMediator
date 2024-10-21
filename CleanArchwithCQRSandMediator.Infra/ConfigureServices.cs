using AutoMapper;
using CleanArchwithCQRSandMediator.Domain.Repository;
using CleanArchwithCQRSandMediator.Infra.Data;
using CleanArchwithCQRSandMediator.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchwithCQRSandMediator.Infra
{
    public static class ConfigurationService
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration )
        {
            services.AddDbContext<BlogDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("dbcs")?? throw new InvalidOperationException("Connection String 'dbcs' not found")));
            services.AddTransient<IBlogRepository, BlogRepository>();
            return services;
        }
    }
}
