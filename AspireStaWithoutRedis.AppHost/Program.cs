var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireStaWithoutRedis_ApiService>("apiservice");

builder.AddProject<Projects.AspireStaWithoutRedis_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
