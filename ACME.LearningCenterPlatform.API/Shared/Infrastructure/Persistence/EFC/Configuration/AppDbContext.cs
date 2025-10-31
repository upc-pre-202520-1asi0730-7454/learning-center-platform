// using ACME.LearningCenterPlatform.API.IAM.Domain.Model.Aggregates;
// using ACME.LearningCenterPlatform.API.IAM.Infrastructure.Persistence.EFC.Configuration.Extensions;
// using ACME.LearningCenterPlatform.API.Profiles.Infrastructure.Persistence.EFC.Configuration.Extensions;

using ACME.LearningCenterPlatform.API.Profiles.Infrastructure.Persistence.EFC.Configuration.Extensions;
using ACME.LearningCenterPlatform.API.Publishing.Infrastructure.Persistence.EFC.Configuration.Extensions;
using ACME.LearningCenterPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace ACME.LearningCenterPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;

/// <summary>
///     Application database context for the Learning Center Platform
/// </summary>
/// <param name="options">
///     The options for the database context
/// </param>
public class AppDbContext(DbContextOptions options) : DbContext(options)
{
   /// <summary>
   ///     On configuring the database context
   /// </summary>
   /// <remarks>
   ///     This method is used to configure the database context.
   ///     It also adds the created and updated date interceptor to the database context.
   /// </remarks>
   /// <param name="builder">
   ///     The option builder for the database context
   /// </param>
   protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.AddCreatedUpdatedInterceptor();
        base.OnConfiguring(builder);
    }

   /// <summary>
   ///     On creating the database model
   /// </summary>
   /// <remarks>
   ///     This method is used to create the database model for the application.
   /// </remarks>
   /// <param name="builder">
   ///     The model builder for the database context
   /// </param>
   protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Publishing Context
        builder.ApplyPublishingConfiguration();

        // Profiles Context
        builder.ApplyProfilesConfiguration();
        
        // IAM Context
        // TODO: Apply IAM configuration when available
        // builder.ApplyIAMConfiguration();
        
        // General Naming Convention for the database objects
        builder.UseSnakeCaseNamingConvention();
    }
}