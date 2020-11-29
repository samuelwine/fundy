using Fundy.Infrastructure.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Fundy.Infrastructure
{
	public static class StartupSetup
	{
		public static void AddDevelopmentDbContext(this IServiceCollection services, string connectionString)
        {
				services.AddDbContext<AppDbContext>(options =>
				options.UseSqlServer(connectionString)); // will be created in web project root
		}

		public static void AddProductionDbContext(this IServiceCollection services, string accountEndpoint, string accountKey, string databaseName)
		{
			services.AddDbContext<AppDbContext>(options =>
			options.UseCosmos(accountEndpoint, accountKey, databaseName)); 
		}
	}
}
