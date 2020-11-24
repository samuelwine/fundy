using Fundy.Infrastructure.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Fundy.Infrastructure
{
	public static class StartupSetup
	{
		public static void AddDbContext(this IServiceCollection services, string connectionString, string databaseName, IWebHostEnvironment _env)
        {
			if (_env.EnvironmentName == "Development")
			{
				services.AddDbContext<AppDbContext>(options =>
				options.UseSqlServer(connectionString)); // will be created in web project root
			}

            if (_env.EnvironmentName == "Production")
            {
				services.AddDbContext<AppDbContext>(options =>
				options.UseCosmos(connectionString, databaseName));
			}
			
		}
	}
			
}
