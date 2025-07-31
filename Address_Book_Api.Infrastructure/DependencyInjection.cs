using Address_Book_Api.Application.Interfaces;
using Address_Book_Api.Application.Services;
using Address_Book_Api.Infrastructure.Data;
using Address_Book_Api.Infrastructure.Repositories;
using Address_Book_Api.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Address_Book_Api.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure
                (this IServiceCollection services, IConfiguration configuration)
        {
           
            services.AddDbContext<AddressBookContext> (options =>
            options.UseInMemoryDatabase("AddressBookDb"));

            services.AddScoped<IAddressBookRepository, AddressBookRepository>();
            services.AddScoped<IEmailService, EmailService>();


          
            return services;
        }
    }
}
