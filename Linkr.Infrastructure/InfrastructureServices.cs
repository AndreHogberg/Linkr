using Linkr.Application.LinkGroups.Repository;
using Linkr.Application.SingleRedirects.Repository;
using Linkr.Infrastructure.Repositories.LinkGroup;
using Linkr.Infrastructure.Repositories.SingleRedirects;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Linkr.Infrastructure;

public static class InfrastructureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddDbContext<DataContext>(opt => opt.UseSqlite("Data Source=db"));
        services.AddScoped<ISingleRedirectRepository, SingleRedirectRepository>();
        services.AddScoped<ILinkGroupRepository, LinkGroupRepository>();
        return services;
    }
}