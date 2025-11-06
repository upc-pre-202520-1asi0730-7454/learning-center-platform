using ACME.LearningCenterPlatform.API.Shared.Domain.Repositories;
using ACME.LearningCenterPlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace ACME.LearningCenterPlatform.API.Shared.Infrastructure.Interfaces.ASP.Configuration.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static void AddSharedContextServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}