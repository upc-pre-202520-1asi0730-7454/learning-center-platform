using ACME.LearningCenterPlatform.API.Profiles.Infrastructure.Interfaces.ASP.Configuration.Extensions;
using ACME.LearningCenterPlatform.API.Publishing.Infrastructure.Interfaces.ASP.Configuration.Extensions;
using ACME.LearningCenterPlatform.API.Shared.Infrastructure.Documentation.OpenApi.Configuration.Extensions;
using ACME.LearningCenterPlatform.API.Shared.Infrastructure.Interfaces.ASP.Configuration;
using ACME.LearningCenterPlatform.API.Shared.Infrastructure.Interfaces.ASP.Configuration.Extensions;
using ACME.LearningCenterPlatform.API.Shared.Infrastructure.Mediator.Cortex.Configuration.Extensions;
using ACME.LearningCenterPlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options => options.Conventions.Add(new KebabCaseRouteNamingConvention()));

// Database Configuration
builder.AddDatabaseConfigurationServices();

// OpenAPI/Swagger Configuration
builder.AddOpenApiConfigurationServices();

// Dependency Injection

builder.AddSharedContextServices();
builder.AddPublishingContextServices();
builder.AddProfilesContextServices();

// Mediator Configuration
builder.AddCortexMediatorServices();

var app = builder.Build();

// Verify if the database exists and create it if it doesn't
app.EnsureDatabaseCreated();

// Configure OpenAPI/Swagger middleware
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();